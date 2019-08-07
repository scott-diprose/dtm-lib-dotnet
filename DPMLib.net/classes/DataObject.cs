﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMLib
{
  public class DataObject
  {
    [YamlMember]
    [JsonProperty]
    public DataStore dataStore { get; set; }//private set; }

    [YamlMember]
    [JsonProperty]
    public string objectSchema { get; set; }//private set; }

    [YamlMember]
    [JsonProperty]
    public string objectName { get; set; }//private set; }

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
