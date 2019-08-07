using System.Collections.Generic;

namespace DPMLib
{
  public class FilteredMappings
  {
    private string targetConnectionKey;
    private List<MappedDataSet> mappedDataSets;

    public FilteredMappings(string filterByTargetConnectionKey)
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
