using System;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Infrastructure.Validation.Models;

namespace ThunderRaeder.API.Commands.Generic
{
    public class UpdateCommand<TResponse> :
        CommandReciever<TResponse, NoValidation>
    {
        public UpdateCommand(object request, Guid id) :
            base(request, id)
        { }
    }
}
