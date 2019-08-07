using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMDLib
{
  public class LoaderResult
  {
    [YamlMember]
    [JsonProperty]
    public MappedDataSet mappedDataSet { get; set; }
  }
}
