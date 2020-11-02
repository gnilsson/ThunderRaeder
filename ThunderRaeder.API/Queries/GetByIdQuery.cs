using MediatR;
using System;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Queries
{
    public class GetByIdQuery<TResponse> : 
        IRequest<Response<TResponse>>, 
        IIdentifiableCommand
    {
        public Guid Id { get; set; }
        public GetByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
