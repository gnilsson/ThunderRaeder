using System.Collections.Generic;

namespace ThunderRaeder.Shared.ServerApiContracts.Requests
{
    public class AddUserBooksRequest
    {
        public string UserId { get; set; }

        public IEnumerable<string> BookIds { get; set; }
    }
}
