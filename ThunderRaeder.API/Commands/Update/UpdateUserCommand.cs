using System;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Infrastructure.Validation.Models;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;

namespace ThunderRaeder.API.Commands.Update
{
    public class UpdateUserCommand : CommandReciever<UserResponse, UserValidationModel>
    {
        public UpdateUserCommand(ModifyUserRequest request, Guid userId) 
            : base(request, userId)
        { }
    }
}
