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
      //TextReader xmlString = File.OpenText(@"C:\Users\scott\dev\OSS\DPMLib.net\test\resources\metadata\sample.xml");
      StreamReader xmlReader = File.OpenText(@"..\..\..\resources\metadata\sample.xml");
      string xmlString = xmlReader.ReadToEnd();
      mappings = XmlLoader.LoadFromString(xmlString);
    }

    /* Start of Tests */

    [Fact]
    public void EnsureLoadedSomething()
    {
      Assert.NotEmpty(mappings);
    }
  }
}
