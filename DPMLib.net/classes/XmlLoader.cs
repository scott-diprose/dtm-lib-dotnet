
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace DPMLib
{
  public static class XmlLoader
  {
    public static List<MappedDataSet> LoadFromString(string xml)
    {
      XmlDocument xmlDoc = new XmlDocument();
      xmlDoc.LoadXml(xml);
      string jsonText = JsonConvert.SerializeXmlNode(xmlDoc);
      using (TextReader textReader = new StringReader(jsonText))
      {
        using (JsonReader jsonReader = new JsonTextReader(textReader))
        {
          JsonSerializer serializer = new JsonSerializer();
          List<MappedDataSet> loaded = serializer.Deserialize<List<MappedDataSet>>(jsonReader);
          return loaded;
        }
      }
    }
  }
}
