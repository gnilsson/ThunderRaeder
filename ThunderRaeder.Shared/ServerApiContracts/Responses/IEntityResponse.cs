using System;
using System.Collections.Generic;
using System.Text;

namespace ThunderRaeder.Shared.ServerApiContracts.Responses
{
    public interface IEntityResponse
    {
        string CreatedDate { get; set; }
        string UpdatedDate { get; set; }
    }
}
