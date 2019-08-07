using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMLib
{
  public class LoaderResult
  {
    [YamlMember]
    [JsonProperty]
    public MappedDataSet mappedDataSet { get; set; }
  }
}
