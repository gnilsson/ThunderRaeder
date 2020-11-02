using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;
using ThunderRaeder.Utility.DataType;
using ThunderRaeder.Utility.Identity;

namespace ThunderRaeder.API.Commands.Action
{
    public class InviteUserCommand : IRequest<Response<InvitationResponse>>
    {
        public string InvitedUserEmailAddress { get; }
        public string InviteRedirectUrl { get; }
        public string IdentityId { get; }
        public InviteUserCommand(InviteUserRequest request, HttpContext httpContext)
        {
            InvitedUserEmailAddress = request.InvitedUserEmailAddress;
            InviteRedirectUrl = request.InviteRedirectUrl;
            IdentityId = httpContext.GetUserId();
        }
    }
}