using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThunderRaeder.Shared.ServerApiContracts;

namespace ThunderRaeder.Client.Util
{
    public static class QueryBuildingExtensions
    {
        public static string AppendPaginationQuery(this string query, IPaginateable pagination)
        {
            return pagination == null ? query : $"{query}?pageNumber={pagination.PageNumber}&pageSize={pagination.PageSize}";
        }
    }
}
