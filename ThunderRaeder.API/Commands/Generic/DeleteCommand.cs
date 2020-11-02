using MediatR;
using System;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;


namespace ThunderRaeder.API.Commands.Generic
{
    public class DeleteCommand<TEntity> : 
        IRequest<Response<DeleteResponse>>, 
        IIdentifiableCommand where TEntity : Entity
    {
        public Guid Id { get; set; }
        public DeleteCommand(Guid entityId) => 
            (Id) = (entityId);
        
    }
}
