using System.Collections.Generic;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.QueryDefinitions.QueryDetailsConfigurations
{
    public class BookQueryConfiguration : QueryConfigurationBase<Book>
    {
        public BookQueryConfiguration()
        {
            IncluderDetails = new List<string[]> 
            { new[] 
            { nameof(Book.Author) } };
        }
    }
}
