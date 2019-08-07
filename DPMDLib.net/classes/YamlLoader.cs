using System;
using System.IO;
using YamlDotNet.Serialization;

namespace DPMDLib
{
  public static class YamlLoader
  {
    public static MappedDataSet LoadFromFile(string filePath)
    {
      var yamlDotNet = new DeserializerBuilder().Build();
      StreamReader mappingFile = File.OpenText(filePath);
      LoaderResult loaded = yamlDotNet.Deserialize<LoaderResult>(mappingFile);
      return loaded.mappedDataSet;
    }

    // public static MappedDataSet LoadValidatedFromFile(string filePath)
    // {
    // }

      public static LoadedMappings LoadFromFolder(string folderPath, string filterByTargetConnectionKey)
    {
      LoadedMappings accumLoaded = new LoadedMappings(filterByTargetConnectionKey);
      var yamlDotNet = new DeserializerBuilder().Build();

      try
      {
        DirectoryInfo folderInfo = new DirectoryInfo(folderPath);

        foreach (FileInfo currentFile in folderInfo.EnumerateFiles())
        {
          try
          {
            StreamReader mappingFile = File.OpenText(currentFile.FullName);
            LoaderResult loaded = yamlDotNet.Deserialize<LoaderResult>(mappingFile);
            if (loaded.mappedDataSet.target.dataStore.connectionKey == filterByTargetConnectionKey)
            {
              accumLoaded.MappedDataSets.Add(loaded.mappedDataSet);
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
