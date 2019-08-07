﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMDLib
{
  public class DataStore
  {
    [YamlMember]
    [JsonProperty]
    public string connectionKey { get; set; }//private set; }

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
