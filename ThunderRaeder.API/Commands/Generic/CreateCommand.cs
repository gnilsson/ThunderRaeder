using System;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Infrastructure.Validation.Models;

namespace ThunderRaeder.API.Commands.Generic
{
    public class CreateCommand<TResponse> :
        CommandReciever<TResponse, NoValidation>
    {
        public CreateCommand(object request) :
            base(request, Guid.NewGuid())
        { }
    }
}
