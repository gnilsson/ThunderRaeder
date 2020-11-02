using System;
using System.Collections.Generic;
using System.Text;
using ThunderRaeder.Shared.Enums;

namespace ThunderRaeder.Shared.ServerApiContracts.Responses
{
    public class VerificationResponse
    {
        public AccountStatus AccountStatus { get; set; }
        public string Message { get; set; }
    }
}
