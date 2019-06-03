using System;
using System.IO;
using YamlDotNet.Serialization;

namespace DPMetaLib
{
  public static class YamlLoader
  {
    public static MappedModel LoadFromFile(string filePath)
    {
      var yamlDotNet = new DeserializerBuilder().Build();
      StreamReader mappingFile = File.OpenText(filePath);
      // return yamlDotNet.Deserialize<MappedDataSet>(mappingFile);
      MappedModel t = yamlDotNet.Deserialize<MappedModel>(mappingFile);
      return t;
    }



    /* Export/Conversion */

    // public static void ConvertYamlFilesToJson(string path)
    // {
    //   string folderPath;
    //   string filePath;

    //   // test if path to file or folder
    //   if (Directory.Exists(path))
    //   {
    //     // folderPath = path;
    //     // filePath = "";
    //     // TODO: Folder traversing for file conversion
    //     throw new NotImplementedException("Folder traversing not yet implemented.");
    //   }
    //   else if (File.Exists(path))
    //   {
    //     folderPath = ""; // TODO: extract file name and folder path
    //     filePath = path.Replace(".yaml", ".json");
    //   }
    //   else
    //   {
    //     throw new FileNotFoundException("Invalid path: " + path);
    //   }

    //   Mapping singleMapping = YamlLoader.LoadFromFile(path);
    //   singleMapping.SaveToFile("JSON", folderPath, filePath);
    // }
  }
}
