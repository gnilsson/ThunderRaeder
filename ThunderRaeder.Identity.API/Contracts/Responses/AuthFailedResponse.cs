using System.Collections.Generic;

namespace ThunderRaeder.Identity.API.Contracts.Responses
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
