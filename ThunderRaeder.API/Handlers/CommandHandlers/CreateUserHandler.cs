using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.API.Commands.Create;
using ThunderRaeder.API.Dtos;
using ThunderRaeder.API.Handlers.GenericHandlers;
using ThunderRaeder.API.Infrastructure.Extensions;
using ThunderRaeder.API.Infrastructure.Modifiers;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.API.Services;
using ThunderRaeder.API.Services.MicrosoftGraph.Instructions;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.Enums;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Handlers.CommandHandlers
{
    public class CreateUserHandler : CreateHandler<AppUser, UserDto, CreateUserCommand, UserResponse>,
                                     IRequestHandler<CreateUserCommand, Response<UserResponse>>
    {
        private readonly IServiceWrapper _serviceWrapper;
        private readonly IModifier<AppUser, CreateUserCommand> _modifier;

        public CreateUserHandler(IRepositoryWrapper repositoryWrapper, IMapper mapper,
                                 IServiceWrapper serviceWrapper, IModifier<AppUser, CreateUserCommand> modifier)
                                : base(repositoryWrapper, mapper, modifier)
        {
            _serviceWrapper = serviceWrapper;
            _modifier = modifier;
        }

        public override async Task<Response<UserResponse>> Handle(
            CreateUserCommand request,
            CancellationToken cancellationToken)
        {
            var userPrincipalName = request.Email.ToUserPrincipalName();
            var check = _serviceWrapper.Graph.GetUserAsync(userPrincipalName);
            var identityUser = _repositoryWrapper.General
                .GetFirstByConditionAsync<IdentityUser>(x => x.Id == request.IdentityId);
            await Task.WhenAll(check, identityUser);

            var user = check.Result == null ? await _serviceWrapper.Graph.CreateUserAsync(
                new CreateAzureAdUserInstruction(userPrincipalName, request.Email)) :
                await _serviceWrapper?.GetGraphMailService(request.Email)?.GetMeAsync();

            if (user == null || !user.UserPrincipalName.Equals(
                 userPrincipalName, StringComparison.OrdinalIgnoreCase))
                userPrincipalName = null;

            var accountStatus = string.IsNullOrWhiteSpace(userPrincipalName) ?
                AccountStatus.Inactive : 
                AccountStatus.Verified;

            _modifier.Append(
                (nameof(AppUser.IdentityId), identityUser.Result.Id),
                (nameof(AppUser.UserPrincipalName), userPrincipalName),
                (nameof(AppUser.AccountStatus), accountStatus),
                (nameof(AppUser.Username),userPrincipalName));

            return await base.Handle(request, cancellationToken);
        }
    }
}
