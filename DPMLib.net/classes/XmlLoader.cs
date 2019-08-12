using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DPMLib
{
  public static class XmlLoader
  {
    public static List<MappedDataSet> LoadFromString(string xmlString)
    {
      using (var stringReader = new StringReader(xmlString))
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<MappedDataSet>));
        List<MappedDataSet> loaded = (List<MappedDataSet>)xmlSerializer.Deserialize(stringReader);
        return loaded;
      }
    }

    public static string SaveToString(List<MappedDataSet> mappedDataSets)
    {
      using (TextWriter textWriter = new StringWriter())
      {
        XmlSerializer xmlSerialiser = new XmlSerializer(typeof(List<MappedDataSet>));
        xmlSerialiser.Serialize(textWriter, mappedDataSets);
        return textWriter.ToString();
      }
    }
  }
}
