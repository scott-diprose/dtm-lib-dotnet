using System.Collections.Generic;
using Newtonsoft.Json.Schema;

namespace DPMDLib
{
  public struct ValidationResult
  {
    public bool Valid { get; set; }
    public IList<ValidationError> Errors { get; set; }
  }
}
