using MediatR;
using System;
using ThunderRaeder.API.Commands.Create;
using ThunderRaeder.API.Commands.Update;
using ThunderRaeder.API.Handlers.GenericHandlers;
using ThunderRaeder.API.Infrastructure.Modifiers;
using ThunderRaeder.API.Queries;
using ThunderRaeder.API.QueryDefinitions.QueryDetailsConfigurations;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;


namespace ThunderRaeder.API.General.Types
{
    public class AuthorTypes<TEntity, TDto, TResponse> :
                 EntityTypes<TEntity, TDto, TResponse>, ITypes
                 where TEntity : Entity, IIdentifiableEntity
    {
        public override Type QueryConfiguration => typeof(AuthorQueryConfiguration);
        public override Type[] CreateModifier => 
            new[] { typeof(IModifier<TEntity, CreateAuthorCommand>), 
                    typeof(Modifier<TEntity,CreateAuthorCommand>) };
        public override Type[] UpdateModifier => 
            new[] { typeof(IModifier<TEntity, UpdateAuthorCommand>), 
                    typeof(Modifier<TEntity,UpdateAuthorCommand>) };
        public override Type[] CreateHandler =>
            new[] { typeof(IRequestHandler<CreateAuthorCommand, Response<AuthorResponse>>),
                    typeof(CreateHandler<TEntity, TDto, CreateAuthorCommand, AuthorResponse>) };
        public override Type[] GetHandler =>
            new[] { typeof(IRequestHandler<GetAuthorsQuery, PagedResponse<AuthorResponse>>),
                    typeof(GetHandler<TEntity, TDto, GetAuthorsQuery, AuthorResponse>) };
        public override Type[] UpdateHandler =>
            new[] { typeof(IRequestHandler<UpdateAuthorCommand, Response<AuthorResponse>>),
                    typeof(UpdateHandler<TEntity, TDto, UpdateAuthorCommand, AuthorResponse>) };
    }
}
