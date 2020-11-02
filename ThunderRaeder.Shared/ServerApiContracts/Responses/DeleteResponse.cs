using System;
using System.Collections.Generic;
using System.Text;
using ThunderRaeder.Shared.Enums;

namespace ThunderRaeder.Shared.ServerApiContracts.Responses
{
    public class DeleteResponse
    {
        public List<string> Cascaded { get; set;  }
        public string Status { get; set; }
    }
}
