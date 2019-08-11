using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DPMLib
{
  public static class XmlLoader
  {
    public static List<MappedDataSet> LoadFromString(string xml)
    {
      // XmlSerializer serializer = new XmlSerializer(typeof(MappedDataSet));

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
