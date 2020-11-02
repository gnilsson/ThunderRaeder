using System.Collections.Generic;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.QueryDefinitions.QueryDetailsConfigurations
{
    public class AuthorQueryConfiguration : QueryConfigurationBase<Author>
    {
        public AuthorQueryConfiguration()
        {
            IncluderDetails = new List<string[]>
            { new[]
            { nameof(Author.Books) } };
        }
    }

}
