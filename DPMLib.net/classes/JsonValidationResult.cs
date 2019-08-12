using System.Collections.Generic;
using Newtonsoft.Json.Schema;

namespace DPMLib
{
  public struct ValidationResult
  {
    public bool Valid { get; set; }
    public IList<ValidationError> Errors { get; set; }
  }
}
