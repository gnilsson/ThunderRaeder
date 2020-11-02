using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.Enums;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Handlers.GenericHandlers
{
    public class DeleteHandler<TEntity, TCommand> :
                 IRequestHandler<TCommand, Response<DeleteResponse>>
                 where TEntity : Entity, IIdentifiableEntity
                 where TCommand : IRequest<Response<DeleteResponse>>, IIdentifiableCommand
    {
        internal readonly IRepositoryWrapper _repositoryWrapper;

        public DeleteHandler(IRepositoryWrapper repositoryWrapper) => 
            (_repositoryWrapper) = 
            (repositoryWrapper);

        public virtual async Task<Response<DeleteResponse>> Handle(
            TCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repositoryWrapper.General.GetSingleAsync<TEntity>(request.Id);
            if (entity == null) return null;
            _repositoryWrapper.General.Delete(entity);

            await _repositoryWrapper.SaveAsync();
            return new Response<DeleteResponse>(
                new DeleteResponse
                { Cascaded = null, Status = DeleteStatus.Deleted.ToString() });
        }
    }
}
