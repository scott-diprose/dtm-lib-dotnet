﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMDLib
{
  public class MappedDataItem
  {
    [YamlMember]
    [JsonProperty]
    // public dynamic SourceDataItem { get; set; }//private set; }
    public ColumnDefinition sourceDataItem { get; set; }//private set; }

    [YamlMember]
    [JsonProperty]
    public ColumnDefinition targetColumn { get; set; }//private set; }

    // private MappedDataItem(dynamic sourceDataItem, ColumnDefinition targetColumn)
    // {
    //   SourceDataItem = sourceDataItem;
    //   TargetColumn = targetColumn;
    // }

    // public static MappedDataItem CreateNewFrom(ColumnDefinition sourceColumn, ColumnDefinition targetColumn)
    // {
    //   return new MappedDataItem(sourceColumn, targetColumn);
    // }

    // public static MappedDataItem CreateNewFrom(CalculationDefinition sourceCalculation, ColumnDefinition targetColumn)
    // {
    //   return new MappedDataItem(sourceCalculation, targetColumn);
    // }
  }
}
