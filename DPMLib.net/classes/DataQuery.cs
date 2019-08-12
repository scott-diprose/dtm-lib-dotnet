using Newtonsoft.Json;
using System.Xml.Serialization;
using YamlDotNet.Core;
using YamlDotNet.Serialization;

namespace DPMLib
{
  public class DataQuery
  {
    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public DataStore dataStore { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public string language { get; set; }

    [XmlElement]
    [YamlMember(ScalarStyle = ScalarStyle.Literal)]
    [JsonProperty]
    public string code { get; set; }

    // private DataQuery(DataStore dataStore, string language, string code)
    // {
    //   DataStore = dataStore;
    //   Language = language;
    //   Code = code;
    // }

    // public static DataQuery CreateNewFrom(DataStore dataStore, string language, string code)
    // {
    //   return new DataQuery(dataStore, language, code);
    // }
  }
}
