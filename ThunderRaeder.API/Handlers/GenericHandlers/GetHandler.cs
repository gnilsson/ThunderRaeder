using AutoMapper;
using MediatR;
using Serilog;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.API.Infrastructure.Utility;
using ThunderRaeder.API.QueryDefinitions;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.API.Services;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Handlers.GenericHandlers
{
    public class GetHandler<TEntity, TDto, TCommand, TResponse> : 
                 IRequestHandler<TCommand, PagedResponse<TResponse>>
                 where TEntity : Entity
                 where TCommand : QueryReciever<GetRequest>, 
                 IRequest<PagedResponse<TResponse>>
    {
        private readonly IRepositoryBase<TEntity, TDto> _repository;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly ILogger _logger;

        public GetHandler(
            IRepositoryWrapper repositoryWrapper, 
            IMapper mapper, 
            IUriService uriService, 
            ILogger logger) =>
            (_repository, _mapper, _uriService, _logger) =
            (repositoryWrapper.Get<TEntity, TDto>(), mapper, uriService, logger);

        public virtual async Task<PagedResponse<TResponse>> Handle(
            TCommand request, CancellationToken cancellationToken)
        {
            var queryData = await _repository.GetQueriedResultAsync(request);
            var response = _mapper.Map<List<TResponse>>(queryData.Items);
            return PaginationUtil.CreatePaginatedResponse(
                _uriService, request.PaginationQuery,
                response, request.RequestRoute, queryData.Total);
        }
    }
}
