using YamlDotNet.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DPMetaLib
{
  public class MappedDataSet
  {
    [YamlMember]
    [JsonProperty]
    // public dynamic MappingName { get; set; }//private set; }  // TODO: review for understanding
    public string mappingName { get; set; }

    [YamlMember]
    [JsonProperty]
    public string mappingDescription { get; set; }

    [YamlMember]
    [JsonProperty]
    public bool enabled { get; set; }

    [YamlMember]
    [JsonProperty]
    public SchemaExt schemaExt { get; set; }

    [YamlMember]
    [JsonProperty]
    public DataQuery source { get; set; }

    [YamlMember]
    [JsonProperty]
    public DataObject target { get; set; }

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
