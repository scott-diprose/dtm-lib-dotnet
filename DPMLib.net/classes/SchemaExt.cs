using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMLib
{
  public class SchemaExt
  {
    [YamlMember]
    [JsonProperty]
    public AzP_EDW AzP_EDW { get; set; }
  }

  public class AzP_EDW
  {
    // [YamlMember]
    // [JsonProperty]
    // public string multiActiveColumnName { get; set; }

    [YamlMember]
    [JsonProperty]
    public underlyingSource underlyingSource { get; set; }
  }

  public class underlyingSource
  {
    [YamlMember]
    [JsonProperty]
    public string objectSchema { get; set; }

    [YamlMember]
    [JsonProperty]
    public string objectName { get; set; }
  }
}
