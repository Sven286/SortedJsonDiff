using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SortedJsonDiff
{
    public class JsonSorter
    {

        public string LoadJsonContent(string jsonString)
        {
            string result = null;
            var writerOptions = new JsonWriterOptions
            {
                Indented = true,
                
            };

            var documentOptions = new JsonDocumentOptions
            {
                CommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true,
            };

            //using (FileStream stream = File.Create("a.json"))
            using (var stream = new MemoryStream())
            {
                using (var writer = new Utf8JsonWriter(stream, options: writerOptions))
                {
                    using (JsonDocument document = JsonDocument.Parse(jsonString, documentOptions))
                    {



                        JsonElement root = document.RootElement;

                        if (root.ValueKind == JsonValueKind.Object)
                        {
                            writer.WriteStartObject();
                        }
                        else
                        {
                            return result;
                        }

                        foreach (JsonProperty property in root.EnumerateObject().OrderBy(jp => jp.Name))
                        {
                            property.WriteTo(writer);
                        }

                        writer.WriteEndObject();

                    }
                        writer.Flush();
                }
                result = Encoding.UTF8.GetString(stream.ToArray());
            }
            return result;
        }
    }
}
