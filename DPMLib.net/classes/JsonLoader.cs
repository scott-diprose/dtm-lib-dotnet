using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;

namespace DPMLib
{
  public static class JsonLoader
  {
    public static List<MappedDataSet> LoadFromFile(string filePath)
    {
      // setup readers
      using (TextReader mappingFile = File.OpenText(filePath))
      using (JsonTextReader jsonReader = new JsonTextReader(mappingFile))
      {
        // load metadata file
        JsonSerializer serializer = new JsonSerializer();
        List<MappedDataSet> loaded = serializer.Deserialize<List<MappedDataSet>>(jsonReader);
        return loaded;
      }
    }

    public static MappedDataSet LoadValidatedFromFile(string filePath)
    {
      // setup schema source
      Assembly assembly = typeof(DPMLib.ValidationResult).GetTypeInfo().Assembly;
      string[] names = assembly.GetManifestResourceNames();
      Stream resource = assembly.GetManifestResourceStream("dp-metalib.net.schemas.dp-metadata.json");

      // setup readers
      using (TextReader schemaFile = new StreamReader(resource, Encoding.UTF8))
      using (JsonTextReader schemaReader = new JsonTextReader(schemaFile))
      using (StreamReader mappingFile = File.OpenText(filePath))
      using (JsonTextReader jsonReader = new JsonTextReader(mappingFile))
      {
        // load schema
        JSchema jsonSchema = JSchema.Load(schemaReader);

        // configure validator
        JSchemaValidatingReader validatingReader = new JSchemaValidatingReader(jsonReader);
        validatingReader.Schema = jsonSchema;
        // IList<string> messages = new List<string>();
        // validatingReader.ValidationEventHandler += (o, a) => messages.Add(a.Message);

        // load and validate metadata file
        JsonSerializer serializer = new JsonSerializer();
        List<MappedDataSet> loaded = serializer.Deserialize<List<MappedDataSet>>(validatingReader);
        return loaded[0];
      }
    }
  }
}
