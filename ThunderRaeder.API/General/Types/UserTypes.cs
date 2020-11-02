using MediatR;
using System;
using ThunderRaeder.API.Commands.Create;
using ThunderRaeder.API.Commands.Update;
using ThunderRaeder.API.Handlers.CommandHandlers;
using ThunderRaeder.API.Handlers.GenericHandlers;
using ThunderRaeder.API.Infrastructure.Modifiers;
using ThunderRaeder.API.Queries;
using ThunderRaeder.API.QueryDefinitions.QueryDetailsConfigurations;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.General.Types
{
    public class UserTypes<TEntity, TDto, TResponse> :
                 EntityTypes<TEntity, TDto, TResponse>, ITypes
                 where TEntity : Entity, IIdentifiableEntity
    {
        public override Type QueryConfiguration => typeof(UserQueryConfiguration);
        public override Type[] CreateModifier => 
            new[] { typeof(IModifier<AppUser, CreateUserCommand>),
                   typeof(Modifier<TEntity,CreateUserCommand>) };
        public override Type[] UpdateModifier => 
            new[] { typeof(IModifier<AppUser, UpdateUserCommand>),
                    typeof(Modifier<TEntity,UpdateUserCommand>) };
        public override Type[] CreateHandler => 
            new[] { typeof(IRequestHandler<CreateUserCommand, Response<UserResponse>>),
                    typeof(CreateUserHandler)};
        public override Type[] GetHandler => 
            new[] { typeof(IRequestHandler<GetUsersQuery, PagedResponse<UserResponse>>),
                    typeof(GetHandler<TEntity, TDto, GetUsersQuery, UserResponse>) };
        public override Type[] UpdateHandler => 
            new[] { typeof(IRequestHandler<UpdateUserCommand, Response<UserResponse>>),
                    typeof(UpdateHandler<TEntity, TDto, UpdateUserCommand, UserResponse>) };
    }
}
