using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace DPMLib
{
  public static class YamlLoader
  {
    public static List<MappedDataSet> LoadFromFile(string filePath)
    {
      // var yamlDotNet = new DeserializerBuilder().WithNamingConvention(new CamelCaseNamingConvention()).Build(); // TODO: use this and change all class members to PascalCase
      var yamlDotNet = new DeserializerBuilder().Build();
      StreamReader mappingFile = File.OpenText(filePath);
      List<MappedDataSet> loaded = yamlDotNet.Deserialize<List<MappedDataSet>>(mappingFile);
      return loaded;
    }

    // public static MappedDataSet LoadValidatedFromFile(string filePath)
    // {
    // }

    public static FilteredMappings LoadFromFolder(string folderPath, string filterByTargetConnectionKey)
    {
      FilteredMappings accumLoaded = new FilteredMappings(filterByTargetConnectionKey);
      var yamlDotNet = new DeserializerBuilder().Build();

      try
      {
        DirectoryInfo folderInfo = new DirectoryInfo(folderPath);

        foreach (FileInfo currentFile in folderInfo.EnumerateFiles(@"*.yaml"))
        {
          try
          {
            StreamReader mappingFile = File.OpenText(currentFile.FullName);
            List<MappedDataSet> loaded = yamlDotNet.Deserialize<List<MappedDataSet>>(mappingFile);
            if (loaded[0].target.dataStore.connectionKey == filterByTargetConnectionKey)
            {
              accumLoaded.MappedDataSets.Add(loaded[0]);
            }
          }
          catch (UnauthorizedAccessException unAuthFile)
          {
            Console.WriteLine($"{unAuthFile.Message}");
          }
          catch (Exception)
          {
            Console.WriteLine($"An error occurred attempting to load: {currentFile.Name}. Assuming invalid file format.");
            throw;
          }
        }
      }
      //catch (DirectoryNotFoundException dirNotFound)
      //{
      //  Console.WriteLine($"{dirNotFound.Message}");
      //}
      //catch (UnauthorizedAccessException unAuthDir)
      //{
      //  Console.WriteLine($"unAuthDir: {unAuthDir.Message}");
      //}
      //catch (PathTooLongException longPath)
      //{
      //  Console.WriteLine($"{longPath.Message}");
      //}
      catch (Exception)
      {
        Console.WriteLine($"An error occurred attempting to access: {folderPath}");
        throw;
      }
      return accumLoaded;
    }
  }
}
