using System;
using System.Collections.Generic;
using System.Text;

namespace ThunderRaeder.Shared.ServerApiContracts
{
    public interface ITimeStampable
    {
        string CreatedDate { get; set; }
        string UpdatedDate { get; set; }
    }
}
