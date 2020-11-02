using MediatR;
using Microsoft.AspNetCore.Http;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;
using ThunderRaeder.Utility.Identity;

namespace ThunderRaeder.API.Commands.Action
{
    public class VerifyMeCommand : IRequest<Response<VerificationResponse>>
    {
        public string Email { get; }
        public string IdentityId { get; }
        public VerifyMeCommand(HttpContext httpContext)
        {
            IdentityId = httpContext.GetUserId();
            Email = httpContext.GetUserEmail();
        }
    }
}
