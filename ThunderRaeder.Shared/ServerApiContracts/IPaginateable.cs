using System;
using System.Collections.Generic;
using System.Text;

namespace ThunderRaeder.Shared.ServerApiContracts
{
    public interface IPaginateable
    {
        int PageNumber { get; set; }

        int PageSize { get; set; }
    }
}
