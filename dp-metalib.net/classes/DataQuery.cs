﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMetaLib
{
  public class DataQuery
  {
    [YamlMember]
    [JsonProperty]
    public DataStore dataStore { get; set; }//private set; }

    [YamlMember]
    [JsonProperty]
    public string language { get; set; }//private set; }

    [YamlMember]
    [JsonProperty]
    public string code { get; set; }//private set; }

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
