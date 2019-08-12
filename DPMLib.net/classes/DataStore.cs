using Newtonsoft.Json;
using System;
using System.Xml.Serialization;
using YamlDotNet.Serialization;

namespace DPMLib
{
  [Serializable()]
  public class DataStore
  {
    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public string connectionKey { get; set; }

    // private DataStore(string connectionKey)
    // {
    //   ConnectionKey = connectionKey;
    // }

    // public static DataStore CreateNewFrom(string connectionKey)
    // {
    //   return new DataStore(connectionKey);
    // }
  }
}
