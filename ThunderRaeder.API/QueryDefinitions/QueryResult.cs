using System.Collections.Generic;

namespace ThunderRaeder.API.QueryDefinitions
{
    public class QueryResult<TDto>
    {
        public int? Total { get; }
        public IEnumerable<TDto> Items { get; }
        public QueryResult(int? total, IEnumerable<TDto> items)
        {
            Total = total;
            Items = items;
        }
    }
}
