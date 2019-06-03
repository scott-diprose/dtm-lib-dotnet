﻿using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace DPMetaLib
{
  public class CalculationDefinition
  {
    [YamlMember]
    [JsonProperty]
    public string calculationName { get; set; }//private set; }

    [YamlMember]
    [JsonProperty]
    public string language { get; set; }//private set; }

    [YamlMember]
    [JsonProperty]
    public string code { get; set; }//private set; }

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
