using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema.Generation;

namespace DPMLib
{
  public static class JsonTools
  {
    public static string ObjectModelToSchema()
    {
      JSchemaGenerator generator = new JSchemaGenerator();
      JSchema schema = generator.Generate(typeof(LoadedMappings));
      return schema.ToString();
    }

    public static ValidationResult ValidateJson(LoadedMappings objectModel)
    {
      throw new NotImplementedException();
    }

    public static ValidationResult ValidateJson(string jsonText)
    {
      // load schema
      Assembly assembly = typeof(DPMLib.ValidationResult).GetTypeInfo().Assembly;
      string[] names = assembly.GetManifestResourceNames();
      Stream resource = assembly.GetManifestResourceStream("dp-metalib.net.schemas.dp-metadata.json");
      string schemaText;
      using (var reader = new StreamReader(resource, Encoding.UTF8))
      {
        schemaText = reader.ReadToEnd();
      }
      JSchema jsonSchema = JSchema.Parse(schemaText);
      JToken metadataJson = JToken.Parse(jsonText);

      // validate json
      IList<ValidationError> errors;
      bool valid = metadataJson.IsValid(jsonSchema, out errors);

      // return outcome + errors and line info
      return new ValidationResult
      {
        Valid = valid,
        Errors = errors
      };
    }
  }
}
