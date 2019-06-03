﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DPMetaLib
{
  public class MappedDataSet
  {
    [YamlMember]
    [JsonProperty]
    // public dynamic MappingName { get; set; }//private set; }
    public string mappingName { get; set; }//private set; }

    [YamlMember]
    [JsonProperty]
    // public dynamic Source { get; set; }//private set; }
    public DataQuery source { get; set; }//private set; }

    [YamlMember]
    [JsonProperty]
    public DataObject target { get; set; }//private set; }

    [YamlMember]
    [JsonProperty]
    public List<MappedDataItem> mappedDataItems { get; set; }//private set; }

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
