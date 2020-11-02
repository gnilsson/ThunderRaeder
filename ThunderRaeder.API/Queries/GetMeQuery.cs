using MediatR;
using Microsoft.AspNetCore.Http;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;
using ThunderRaeder.Utility.Identity;

namespace ThunderRaeder.API.Queries
{
    public class GetMeQuery : IRequest<Response<UserResponse>>
    {
        public string IdentityId { get; set; }

        public GetMeQuery(HttpContext httpContext)
        {
            IdentityId = httpContext.GetUserId();
        }
    }
}
