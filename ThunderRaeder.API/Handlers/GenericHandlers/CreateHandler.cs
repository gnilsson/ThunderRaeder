using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Handlers.CommandHandlers;
using ThunderRaeder.API.Infrastructure.Modifiers;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Handlers.GenericHandlers
{
    public class CreateHandler<TEntity, TDto, TCommand, TResponse> :
                 CommandHandlerBase, IRequestHandler<TCommand, Response<TResponse>>
                 where TEntity : Entity, IIdentifiableEntity
                 where TCommand : ICommand, IRequest<Response<TResponse>>
    {
        internal readonly IRepositoryBase<TEntity, TDto> _repository;
        internal readonly IRepositoryWrapper _repositoryWrapper;
        internal readonly IMapper _mapper;

        private readonly IModifier<TEntity, TCommand>.CreateDelegate _creator;

        public CreateHandler(IRepositoryWrapper repositoryWrapper,
                             IMapper mapper,
                             IModifier<TEntity, TCommand> modifier) =>
            (_repositoryWrapper, _repository, _mapper, _creator) = 
            (repositoryWrapper, repositoryWrapper.Get<TEntity, TDto>(), mapper, modifier.Creator);

        public virtual async Task<Response<TResponse>> Handle(
            TCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(_creator(request));
            return await SaveAndReturnAsync<TEntity, TDto, TResponse>(
                _repositoryWrapper, _repository, _mapper, request.Id);
        }
    }
}
