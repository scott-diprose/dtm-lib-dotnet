﻿using Newtonsoft.Json;
using System.Xml.Serialization;
using YamlDotNet.Serialization;

namespace DPMLib
{
  public class ColumnDefinition
  {
    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public string columnName { get; set; }

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
