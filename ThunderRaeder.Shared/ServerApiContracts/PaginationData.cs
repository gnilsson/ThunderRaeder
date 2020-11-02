using System;
using System.Collections.Generic;
using System.Text;

namespace ThunderRaeder.Shared.ServerApiContracts
{
    public class PaginationData : IPaginateable
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
