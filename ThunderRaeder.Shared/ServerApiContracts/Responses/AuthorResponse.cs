using System.Collections.Generic;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Simplified;

namespace ThunderRaeder.Shared.ServerApiContracts.Responses
{
    public class AuthorResponse : IIdentifiableResponse, IEntityResponse
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public List<BookResponseSimplified> Books { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
    }
}
