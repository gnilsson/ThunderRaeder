using System.Collections.Generic;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Simplified;

namespace ThunderRaeder.Shared.ServerApiContracts.Responses
{
    public class UserResponse : IIdentifiableResponse, IEntityResponse
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; }
        public string Alias { get; set; }
        public string AccountStatus { get; set; }
        public AzureAdUserResponse AzureUser { get; set; }
        public IEnumerable<UserBookResponseSimplified> Books { get; set; }
        public string UserPrincipalName { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
    }
}
