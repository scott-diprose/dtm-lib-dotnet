using System.IO;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;

namespace DPMDLib
{
  public static class JsonLoader
  {
    public static MappedDataSet LoadFromFile(string filePath)
    {
      LoaderResult loaded;

      // setup readers
      using (TextReader mappingFile = File.OpenText(filePath))
      using (JsonTextReader jsonReader = new JsonTextReader(mappingFile))
      {
        // load metadata file
        JsonSerializer serializer = new JsonSerializer();
        loaded = serializer.Deserialize<LoaderResult>(jsonReader);
      }
      return loaded.mappedDataSet;
    }

    public static MappedDataSet LoadValidatedFromFile(string filePath)
    {
      LoaderResult loaded;
      // setup schema source
      Assembly assembly = typeof(DPMDLib.ValidationResult).GetTypeInfo().Assembly;
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
        loaded = serializer.Deserialize<LoaderResult>(validatingReader);
      }
      return loaded.mappedDataSet;
    }
  }
}
