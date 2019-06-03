﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMetaLib
{
  public class ColumnDefinition
  {
    [YamlMember]
    [JsonProperty]
    public string columnName { get; set; }//private set; }

    // private ColumnDefinition(string columnName)
    // {
    //   ColumnName = columnName;
    // }

    // public static ColumnDefinition CreateNewFrom(string columnName)
    // {
    //   return new ColumnDefinition(columnName);
    // }
  }
}
