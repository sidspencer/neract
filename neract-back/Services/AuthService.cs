using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using neract_back.Pocos;

namespace neract_back.Services
{
  /// Singleton service for auth needs.
  public class AuthService 
  {
    /// Private constructor, and an instance...
    private static AuthService inst = null;
    private AuthService() { }


    // The one and only instance.
    public static AuthService Inst 
    { 
      get 
      {
        if (inst == null) { inst = new AuthService(); };
        return inst;
      } 
    }
  

    /// Has the Auth Token expired?
    public bool IsAuthExpired(DateTime dt) 
    {
      return (dt != C.InactiveTimestamp && dt > DateTime.UtcNow.AddTicks(1));
    }


    /// Is it a valid Auth Token?
    public bool IsTokenValid(string tok) 
    {
      return (
        tok != C.InactiveToken && this.IsTrueToken(tok)
      );
    }


    /// Is the token not some crazy string?
    private bool IsTrueToken(string tok) 
    {
      return true;
    }


    /// Is the general Credentials object valid? All parts.
    public bool AreCredsValid(Credentials creds) 
    {
      return (
        this.IsTokenValid(creds.AuthToken) && this.IsAuthExpired(creds.GoodUntil)
      );
    }
  }
}
