﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMetaLib
{
  public class MappedModel
  {
    [YamlMember]
    [JsonProperty]
    public MappedDataSet mappedDataSet { get; set; }
  }
}
