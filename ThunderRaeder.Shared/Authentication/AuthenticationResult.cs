﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ThunderRaeder.Shared.Authentication
{
    public class AuthenticationResult
    {
        public string Token { get; set; }

        public bool Success { get; set; }

        public IEnumerable<string> Errors { get; set; }
        public string RefreshToken { get; set; }
    }
}
