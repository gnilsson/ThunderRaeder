using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.API.CommandDefinitions;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Handlers.GenericHandlers
{
    public class GetByIdHandler<TEntity, TDto, TCommand, TResponse> :
                 IRequestHandler<TCommand, Response<TResponse>>
                 where TEntity : Entity, IIdentifiableEntity
                 where TCommand : IRequest<Response<TResponse>>, IIdentifiableCommand
    {
        private readonly IRepositoryBase<TEntity, TDto> _repository;
        private readonly IMapper _mapper;

        public GetByIdHandler(
            IRepositoryWrapper repositoryWrapper,
            IMapper mapper) => 
            (_repository, _mapper) = 
            (repositoryWrapper.Get<TEntity, TDto>(), mapper);

        public virtual async Task<Response<TResponse>> Handle(
            TCommand request, CancellationToken cancellationToken)
        {
            var entityDto = await _repository
                .GetFirstOrDefaultAsync(x => x.Id == request.Id);

            return entityDto == null ? null :
                new Response<TResponse>(
                    _mapper.Map<TResponse>(entityDto));
        }
    }
}
