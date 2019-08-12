using Newtonsoft.Json;
using System;
using System.Xml.Serialization;
using YamlDotNet.Serialization;

namespace DPMLib
{
  [Serializable()]
  public class MappedDataItem
  {
    [XmlElement]
    [YamlMember]
    [JsonProperty]
    // public dynamic SourceDataItem { get; set; }
    public ColumnDefinition sourceDataItem { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public ColumnDefinition targetColumn { get; set; }

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
