using System;
using neract_back.Services;

namespace neract_back.Pocos
{
    public class User
    {
        public DateTime CreationDate { get; set; } = C.InactiveTimestamp;
        public string DisplayName { get; set; } = C.DefaultDisplayName;
        public string Username { get; set; } = C.DefaultUsername;
        public string Password { get; set; } = C.DefaultPassword;
        private Credentials Creds { get; set; } = new Credentials();

        public bool IsLoggedIn {
          get
          {
            return AuthService.Inst.AreCredsValid(this.Creds);
          }
        }
    }
}
