using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.API.Dtos;
using ThunderRaeder.API.Queries;
using ThunderRaeder.API.Repositories;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.API.Services;
using ThunderRaeder.API.Services.MicrosoftGraph;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.Enums;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Handlers.QueryHandlers
{
    public class GetMeHandler : IRequestHandler<GetMeQuery, Response<UserResponse>>
    {
        private readonly IRepositoryBase<AppUser,UserDto> _repository;
        private readonly IMapper _mapper;
        private readonly IServiceWrapper _serviceWrapper;

        public GetMeHandler(IRepositoryWrapper repositoryWrapper, IMapper mapper, IServiceWrapper serviceWrapper)
        {
            _repository = repositoryWrapper.Get<AppUser, UserDto>();
            _mapper = mapper;
            _serviceWrapper = serviceWrapper;
        }

        public async Task<Response<UserResponse>> Handle(GetMeQuery request, CancellationToken cancellationToken)
        {
            //      var abc = await _serviceWrapper.Graph.AddDcoumentAsync(null);
            //  var cba = await _serviceWrapper.Graph.GetDocumentAsync("01KCWCIEL3C7ZBKPNI3RE3J2IXU26ECGNS");
            //  var ff = cba;
            //  return null;

            var userDto = await _repository.GetFirstOrDefaultAsync(x => x.IdentityId == request.IdentityId);
            if (userDto == null) return null;

            userDto.AzureUser = userDto.AccountStatus == AccountStatus.Verified ?
                await _serviceWrapper.Graph.GetUserAsync(userDto.UserPrincipalName) : null;
            return new Response<UserResponse>(_mapper.Map<UserResponse>(userDto));
        }
    }
}
