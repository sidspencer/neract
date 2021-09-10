using System;

using neract_back.Services;

namespace neract_back.Pocos
{
  public class Credentials 
  {
    public string Username { get; set; } = C.DefaultUsername;
    public string Password { get; set; } = C.DefaultPassword;
    public string AuthToken { get; set; } = C.InactiveToken;
    public DateTime GoodUntil { get; set; } = C.InactiveTimestamp;
  }
}