using System;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Infrastructure.Validation.Models;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;

namespace ThunderRaeder.API.Commands.Create
{
    public class CreateAuthorCommand : CommandReciever<AuthorResponse, AuthorValidationModel>
    {
        public CreateAuthorCommand(ModifyAuthorRequest request) :
            base(request, Guid.NewGuid())
        { }
    }
}
