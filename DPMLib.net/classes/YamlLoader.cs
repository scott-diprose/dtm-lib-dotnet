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
      // IDeserializer yamlDotNet = new DeserializerBuilder().WithNamingConvention(new CamelCaseNamingConvention()).Build(); // TODO: use this and change all class members to PascalCase
      IDeserializer yamlDotNet = new DeserializerBuilder().Build();
      StreamReader mappingFile = File.OpenText(filePath);
      List<MappedDataSet> loaded = yamlDotNet.Deserialize<List<MappedDataSet>>(mappingFile);
      return loaded;
    }

    public static List<MappedDataSet> LoadFromFolder(string folderPath)
    {
      List<MappedDataSet> accumLoaded = new List<MappedDataSet>();
      IDeserializer yamlDotNet = new DeserializerBuilder().Build();
      try
      {
        DirectoryInfo folderInfo = new DirectoryInfo(folderPath);

        foreach (FileInfo currentFile in folderInfo.EnumerateFiles(@"*.yaml"))
        {
          try
          {
            StreamReader mappingFile = File.OpenText(currentFile.FullName);
            List<MappedDataSet> loaded = yamlDotNet.Deserialize<List<MappedDataSet>>(mappingFile);
            accumLoaded.AddRange(loaded);
          }
          catch (UnauthorizedAccessException unAuthFile)
          {
            Console.WriteLine($"Access denied: {unAuthFile.Message}");
            throw;
          }
          catch (Exception)
          {
            Console.WriteLine($"An error occurred attempting to load: {currentFile.Name}. Assuming invalid file format.");
            throw;
          }
        }
      }
      catch (DirectoryNotFoundException dirNotFound)
      {
        Console.WriteLine($"Directory not found: {dirNotFound.Message}");
        throw;
      }
      catch (UnauthorizedAccessException unAuthDir)
      {
        Console.WriteLine($"Access denied: {unAuthDir.Message}");
        throw;
      }
      catch (PathTooLongException longPath)
      {
        Console.WriteLine($"Path to long: {longPath.Message}");
        throw;
      }
      catch (Exception)
      {
        Console.WriteLine($"An error occurred attempting to access: {folderPath}");
        throw;
      }
      return accumLoaded;
    }

    public static FilteredMappings LoadFromFolder(string folderPath, string filterByTargetConnectionKey)
    {
      FilteredMappings accumLoaded = new FilteredMappings(filterByTargetConnectionKey);
      IDeserializer yamlDotNet = new DeserializerBuilder().Build();

      try
      {
        DirectoryInfo folderInfo = new DirectoryInfo(folderPath);

        foreach (FileInfo currentFile in folderInfo.EnumerateFiles(@"*.yaml"))
        {
          try
          {
            StreamReader mappingFile = File.OpenText(currentFile.FullName);
            List<MappedDataSet> loaded = yamlDotNet.Deserialize<List<MappedDataSet>>(mappingFile);
            foreach (MappedDataSet mapping in loaded)
            {
              if (mapping.target.dataStore.connectionKey == filterByTargetConnectionKey)
              {
                accumLoaded.MappedDataSets.Add(mapping);
              }
            }
          }
          catch (UnauthorizedAccessException unAuthFile)
          {
            Console.WriteLine($"Access denied: {unAuthFile.Message}");
            throw;
          }
          catch (Exception)
          {
            Console.WriteLine($"An error occurred attempting to load: {currentFile.Name}. Assuming invalid file format.");
            throw;
          }
        }
      }
      catch (DirectoryNotFoundException dirNotFound)
      {
        Console.WriteLine($"Directory not found: {dirNotFound.Message}");
        throw;
      }
      catch (UnauthorizedAccessException unAuthDir)
      {
        Console.WriteLine($"Access denied: {unAuthDir.Message}");
        throw;
      }
      catch (PathTooLongException longPath)
      {
        Console.WriteLine($"Path to long: {longPath.Message}");
        throw;
      }
      catch (Exception)
      {
        Console.WriteLine($"An error occurred attempting to access: {folderPath}");
        throw;
      }
      return accumLoaded;
    }

    public static void SaveToFile(MappedDataSet mappedDataSet, string filePath)
    {
      ISerializer yamlDotNet = new SerializerBuilder().Build();
      using (TextWriter outputFile = new StreamWriter(filePath, true))
      {
        yamlDotNet.Serialize(outputFile, mappedDataSet, typeof(MappedDataSet));
      }
    }
  }
}
