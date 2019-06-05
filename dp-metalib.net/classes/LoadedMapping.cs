﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMetaLib
{
  public class LoadedMapping
  {
    [YamlMember]
    [JsonProperty]
    public MappedDataSet mappedDataSet { get; set; }
  }
}
