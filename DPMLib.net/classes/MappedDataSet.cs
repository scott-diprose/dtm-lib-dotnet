using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;
using YamlDotNet.Serialization;

namespace DPMLib
{
  public class MappedDataSet
  {
    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public string mappingName { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public string mappingDescription { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public bool enabled { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public SchemaExt schemaExt { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public DataQuery source { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public DataObject target { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public List<MappedDataItem> mappedDataItems { get; set; }

    // private MappedDataSet(dynamic source, DataObject target, List<MappedDataItem> mappedDataItems)
    // {
    //   Source = source;
    //   Target = target;
    //   MappedDataItems = mappedDataItems;
    // }

    // public static MappedDataSet CreateNewFrom(DataObject source, DataObject target, List<MappedDataItem> mappedDataItems)
    // {
    //   return new MappedDataSet(source, target, mappedDataItems);
    // }

    // public static MappedDataSet CreateNewFrom(DataQuery source, DataObject target, List<MappedDataItem> mappedDataItems)
    // {
    //   return new MappedDataSet(source, target, mappedDataItems);
    // }
  }
}
