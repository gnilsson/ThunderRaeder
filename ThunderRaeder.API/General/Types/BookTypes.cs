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
    public class BookTypes<TEntity, TDto, TResponse> :
                 EntityTypes<TEntity, TDto, TResponse>, ITypes
                 where TEntity : Entity, IIdentifiableEntity

    {
        public override Type QueryConfiguration => typeof(BookQueryConfiguration);
        public override Type[] CreateModifier =>
            new[] { typeof(IModifier<TEntity, CreateBookCommand>),
                    typeof(Modifier<TEntity,CreateBookCommand>) };
        public override Type[] UpdateModifier =>
            new[] { typeof(IModifier<TEntity, UpdateBookCommand>),
                    typeof(Modifier<TEntity, UpdateBookCommand>) };
        public override Type[] CreateHandler =>
            new[] { typeof(IRequestHandler<CreateBookCommand, Response<BookResponse>>),
                    typeof(CreateHandler<TEntity, TDto, CreateBookCommand, BookResponse>) };
        public override Type[] GetHandler =>
            new[] { typeof(IRequestHandler<GetBooksQuery, PagedResponse<BookResponse>>),
                    typeof(GetHandler<TEntity, TDto, GetBooksQuery, BookResponse>) };
        public override Type[] UpdateHandler => 
            new[] { typeof(IRequestHandler<UpdateBookCommand, Response<BookResponse>>),
                    typeof(UpdateHandler<TEntity, TDto, UpdateBookCommand, BookResponse>) };
    };
}
