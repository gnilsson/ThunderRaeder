using System.Collections.Generic;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.QueryDefinitions.QueryDetailsConfigurations
{
    public class UserQueryConfiguration : QueryConfigurationBase<AppUser>
    {
        public UserQueryConfiguration()
        {
            IncluderDetails = new List<string[]>
            { new[]
            { nameof(AppUser.AppUserBooks), nameof(AppUserBook.Book) } };
        }
    }
}
