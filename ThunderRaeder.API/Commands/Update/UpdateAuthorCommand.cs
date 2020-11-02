using System;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Infrastructure.Validation.Models;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;

namespace ThunderRaeder.API.Commands.Update
{
    public class UpdateAuthorCommand : CommandReciever<AuthorResponse, AuthorValidationModel>
    {
        public UpdateAuthorCommand(ModifyAuthorRequest request, Guid authorId) 
            : base(request, authorId)
        { }
    }
}
