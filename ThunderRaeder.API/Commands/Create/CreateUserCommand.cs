using Microsoft.AspNetCore.Http;
using System;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Infrastructure.Validation.Models;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Utility.Identity;

namespace ThunderRaeder.API.Commands.Create
{
    public class CreateUserCommand : CommandReciever<UserResponse, UserValidationModel>
    {
        public CreateUserCommand(ModifyUserRequest request, HttpContext httpContext)
            : base(request, Guid.NewGuid())
        {
            IdentityId = httpContext.GetUserId();
            Email = httpContext.GetUserEmail();
        }

        public string IdentityId { get; }
        public string Email { get; }
    }
}
