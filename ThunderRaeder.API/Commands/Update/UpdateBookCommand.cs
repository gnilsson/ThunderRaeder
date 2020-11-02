using System;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Infrastructure.Validation.Models;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;

namespace ThunderRaeder.API.Commands.Update
{
    public class UpdateBookCommand : CommandReciever<BookResponse,BookValidationModel>
    {
        public UpdateBookCommand(ModifyBookRequest request, Guid bookId) 
            : base(request, bookId)
        { }
    }
}
