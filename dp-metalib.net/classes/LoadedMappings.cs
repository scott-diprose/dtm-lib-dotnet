using System.Collections.Generic;

namespace DPMetaLib
{
  public class LoadedMappings
  {
    private string targetConnectionKey;
    private List<MappedDataSet> mappedDataSets;

    public LoadedMappings(string filterByTargetConnectionKey)
    {
      this.targetConnectionKey = filterByTargetConnectionKey;
      this.mappedDataSets = new List<MappedDataSet>();
    }

    public string TargetConnectionKey
    {
      get { return targetConnectionKey; }
    }
    public List<MappedDataSet> MappedDataSets
    {
      get { return mappedDataSets; }
}
  }
}
