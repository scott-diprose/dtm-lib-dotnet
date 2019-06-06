using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;

namespace DPMetaLib
{
  public static class YamlLoader
  {
    public static MappedDataSet LoadFromFile(string filePath)
    {
      var yamlDotNet = new DeserializerBuilder().Build();
      StreamReader mappingFile = File.OpenText(filePath);
      LoadedMapping t = yamlDotNet.Deserialize<LoadedMapping>(mappingFile);
      return t.mappedDataSet;
    }

    public static List<MappedDataSet> LoadFromFolder(string folderPath)
    {
      List<MappedDataSet> result = new List<MappedDataSet>();
      var yamlDotNet = new DeserializerBuilder().Build();

      try
      {
        DirectoryInfo folderInfo = new DirectoryInfo(folderPath);

        foreach (FileInfo currentFile in folderInfo.EnumerateFiles())
        {
          try
          {
            StreamReader mappingFile = File.OpenText(currentFile.FullName);
            LoadedMapping loaded = yamlDotNet.Deserialize<LoadedMapping>(mappingFile);
            result.Add(loaded.mappedDataSet);
          }
          catch (UnauthorizedAccessException unAuthFile)
          {
            Console.WriteLine($"{unAuthFile.Message}");
          }
        }
      }
      catch (DirectoryNotFoundException dirNotFound)
      {
        Console.WriteLine($"{dirNotFound.Message}");
      }
      catch (UnauthorizedAccessException unAuthDir)
      {
        Console.WriteLine($"unAuthDir: {unAuthDir.Message}");
      }
      catch (PathTooLongException longPath)
      {
        Console.WriteLine($"{longPath.Message}");
      }
      catch (Exception unhandled)
      {
        Console.WriteLine($"{unhandled.Message}");
      }
      return result;
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
