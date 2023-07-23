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

            SortPropertiesRecursively(jsonObject);

            string sortedJson = FormatJson(jsonObject);
            return sortedJson;
        }

        static void SortPropertiesRecursively(JObject obj)
        {
            // Sort properties at the current level
            IList<JProperty> sortedProperties = obj.Properties().OrderBy(p => p.Name).ToList();

            // Remove all properties from the object
            obj.RemoveAll();

            // Add sorted properties back to the object
            foreach (var property in sortedProperties)
            {
                obj.Add(property);
                if (property.Value.Type == JTokenType.Object)
                {
                    // Recursively sort properties in nested objects
                    SortPropertiesRecursively((JObject)property.Value);
                }
                else if (property.Value.Type == JTokenType.Array)
                {
                    // Recursively sort properties in arrays of objects
                    foreach (var item in (JArray)property.Value)
                    {
                        if (item.Type == JTokenType.Object)
                        {
                            SortPropertiesRecursively((JObject)item);
                        }
                    }
                }
            }
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
