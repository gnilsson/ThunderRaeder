using System;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Infrastructure.Validation.Models;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;

namespace ThunderRaeder.API.Commands.Create
{
    public class CreateBookCommand : CommandReciever<BookResponse, BookValidationModel>
    {
        public CreateBookCommand(ModifyBookRequest request) : 
            base(request, Guid.NewGuid())
        { }

    }
}
