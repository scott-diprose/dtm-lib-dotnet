﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DPMetaLib
{
  public class ModelMappings
  {
    [YamlMember]
    [JsonProperty]
    public List<MappedDataSet> mappedDataSets { get; set; }
  }
}
