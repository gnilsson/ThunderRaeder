using System.Collections.Generic;

namespace ThunderRaeder.Identity.API.Results
{
    public class AuthenticationResult
    {
        public string Token { get; set; }

        public bool Success { get; set; }

        public IEnumerable<string> Errors { get; set; }
        public string RefreshToken { get; set; }
    }
}
