using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;

namespace SortedJsonDiff
{
    public class JsonSorter
    {

        public string LoadJsonContent(string json)
        {
            JObject jsonObject = JObject.Parse(json);

            var sorted = SortPropertiesRecursively(jsonObject);

            string sortedJson = FormatJson(sorted);
            return sortedJson;
        }

        static JObject SortPropertiesRecursively(JObject obj)
        {
            var result = new JObject();

			// Sort properties at the current level
			IList<JProperty> sortedProperties = obj.Properties().OrderBy(p => p.Name).ToList();

            // Remove all properties from the object
            //obj.RemoveAll();

            // Add sorted properties back to the object
            foreach (var property in sortedProperties)
            {
                //obj.Add(property);
                if (property.Value.Type == JTokenType.Object)
                {
					// Recursively sort properties in nested objects
					result.Add(property.Name, SortPropertiesRecursively((JObject)property.Value));
                }
                else if (property.Value.Type == JTokenType.Array)
                {
                    // Recursively sort properties in arrays of objects
                    var array = property.Value.AsJEnumerable();

                    //var v = property.Value.Values();
                    //var h = property.Value.HasValues;
                    //var a = property.Value.Ancestors();
                    var c = property.Value.Children<JObject>();
                    var p = c.Any(cd => cd.ContainsKey("path"));

                    if (p)
                    {
                        array = array.OrderBy(j => j.Value<string>("path")).AsJEnumerable();

					}

                    var newArray = new JArray();
					foreach (var item in array)
                    {
                        if (item.Type == JTokenType.Object)
                        {
							newArray.Add(SortPropertiesRecursively((JObject)item));
                        }
                        else
                        {
                            newArray.Add(item);
						}
                    }
                    result.Add(property.Name, newArray);
                }
                else
                {
                    result.Add(property);
                }
            }
            return result;
		}

        static string FormatJson(JObject obj)
        {
            using (var stringWriter = new StringWriter())
            {
                using (var jsonWriter = new JsonTextWriter(stringWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    jsonWriter.IndentChar = '\t';
                    jsonWriter.Indentation = 1;

                    obj.WriteTo(jsonWriter);
                }

                return stringWriter.ToString();
            }
        }
    }
}
