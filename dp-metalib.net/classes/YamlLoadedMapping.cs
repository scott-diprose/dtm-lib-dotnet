using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMetaLib
{
  public class YamlLoadedMapping
  {
    [YamlMember]
    [JsonProperty]
    public MappedDataSet mappedDataSet { get; set; }
  }
}
