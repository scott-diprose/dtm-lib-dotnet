using DPMLib;
using System;
using System.IO;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace test
{
  public class TestDidLoadXml
  {
    private readonly ITestOutputHelper output;
    private List<MappedDataSet> mappings;

    public TestDidLoadXml(ITestOutputHelper output)
    {
      this.output = output;
      TextReader xmlString = File.OpenText(@"..\..\..\resources\metadata\sample.xml");
      mappings = XmlLoader.LoadFromString(xmlString.ToString());
    }

    /* Start of Tests */

    [Fact]
    public void EnsureLoadedSomething()
    {
      if (mappings.Count == 0)
        throw new Exception("ERROR: No items in collection.");
    }
  }
}
