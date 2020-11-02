using MediatR;
using System;
using ThunderRaeder.API.Commands.Generic;
using ThunderRaeder.API.Handlers.GenericHandlers;
using ThunderRaeder.API.Infrastructure.Modifiers;
using ThunderRaeder.API.Queries;
using ThunderRaeder.API.QueryDefinitions.QueryDetailsConfigurations;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.General.Types
{
    public class EntityTypes<TEntity, TDto, TResponse>
                 where TEntity : Entity, IIdentifiableEntity
    {
        public Type EntityType => typeof(TEntity);
        public virtual Type QueryConfiguration => typeof(DefaultQueryConfiguration<TEntity>);
        public virtual Type[] GetHandler =>
            new[] { typeof(IRequestHandler<GetDefaultQuery<TResponse>, PagedResponse<TResponse>>),
                    typeof(GetHandler<TEntity, TDto, GetDefaultQuery<TResponse>, TResponse>) };
        public virtual Type[] DeleteHandler =>
            new[] { typeof(IRequestHandler<DeleteCommand<TEntity>, Response<DeleteResponse>>),
                    typeof(DeleteHandler<TEntity, DeleteCommand<TEntity>>) };
        public virtual Type[] GetByIdHandler =>
            new[] { typeof(IRequestHandler<GetByIdQuery<TResponse>, Response<TResponse>>),
                    typeof(GetByIdHandler<TEntity, TDto, GetByIdQuery<TResponse>, TResponse>) };
        public virtual Type[] CreateModifier =>
            new[] { typeof(IModifier<TEntity, CreateCommand<TResponse>>),
                    typeof(Modifier<TEntity,CreateCommand<TResponse>>) };
        public virtual Type[] UpdateModifier =>
            new[] { typeof(IModifier<TEntity, UpdateCommand<TResponse>>),
                    typeof(Modifier<TEntity, UpdateCommand<TResponse>>) };
        public virtual Type[] CreateHandler =>
            new[] { typeof(IRequestHandler<CreateCommand<TResponse>, Response<TResponse>>),
                    typeof(CreateHandler<TEntity, TDto, CreateCommand<TResponse>, TResponse>) };
        public virtual Type[] UpdateHandler =>
            new[] { typeof(IRequestHandler<UpdateCommand<TResponse>, Response<TResponse>>),
                    typeof(UpdateHandler<TEntity, TDto, UpdateCommand<TResponse>, TResponse>) };
    }
}
