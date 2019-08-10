﻿using Newtonsoft.Json;
using System.Xml.Serialization;
using YamlDotNet.Serialization;

namespace DPMLib
{
  public class DataObject
  {
    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public DataStore dataStore { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public string objectSchema { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public string objectName { get; set; }

    // private DataObject(DataStore dataStore, string schemaName, string objectName)
    // {
    //   DataStore = dataStore;
    //   SchemaName = schemaName;
    //   ObjectName = objectName;
    // }

    // public static DataObject CreateNewFrom(DataStore dataStore, string schemaName, string objectName)
    // {
    //   return new DataObject(dataStore, schemaName, objectName);
    // }
  }
}
