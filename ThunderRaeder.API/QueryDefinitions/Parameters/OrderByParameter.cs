using System;
using System.ComponentModel;
using ThunderRaeder.Shared.ServerApiContracts;

namespace ThunderRaeder.API.QueryDefinitions.Parameters
{
    public class OrderByParameter
    {
        public ListSortDirection SortDirection { get; private set; }
        public string Node { get; private set; }

        public OrderByParameter(IOrderable orderable)
        {
            var text = orderable.OrderBy.Split(":");
            if (!text[0].Contains("asc", StringComparison.OrdinalIgnoreCase) &&
                !text[0].Contains("desc", StringComparison.OrdinalIgnoreCase))
                return;
            SortDirection = text[0].Contains("asc", StringComparison.OrdinalIgnoreCase) 
                ? ListSortDirection.Ascending 
                : ListSortDirection.Descending;
            Node = text[1];
        }
    }
}

