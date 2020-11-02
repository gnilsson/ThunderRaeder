using System;
using System.Collections.Generic;
using System.Text;

namespace ThunderRaeder.Shared.Authentication
{
    public class RefreshTokenRequest
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
