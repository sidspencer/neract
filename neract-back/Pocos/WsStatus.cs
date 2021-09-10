using System;

namespace neract_back {
  public class WsStatus
  {
    public bool Success { get; set; } = false;
    public string WarningMessage { get; set; } = string.Empty;
    public string DebugInfo { get; set; } = string.Empty;
  } 
}