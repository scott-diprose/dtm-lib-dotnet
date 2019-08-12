using Newtonsoft.Json;
using System;
using System.Xml.Serialization;
using YamlDotNet.Serialization;

namespace DPMLib
{
  [Serializable()]
  public class CalculationDefinition
  {
    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public string calculationName { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public string language { get; set; }

    [XmlElement]
    [YamlMember]
    [JsonProperty]
    public string code { get; set; }

    // private CalculationDefinition(string calculationName, string language, string code)
    // {
    //   CalculationName = calculationName;
    //   Language = language;
    //   Code = code;
    // }

    // public static CalculationDefinition CreateNewFrom(string calculationName, string language, string code)
    // {
    //   return new CalculationDefinition(calculationName, language, code);
    // }
  }
}
