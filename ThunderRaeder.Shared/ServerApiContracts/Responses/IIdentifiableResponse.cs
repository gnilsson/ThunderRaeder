using System;
using System.Collections.Generic;
using System.Text;

namespace ThunderRaeder.Shared.ServerApiContracts.Responses
{
    public interface IIdentifiableResponse
    {
        string Id { get; set; }
    }
}
