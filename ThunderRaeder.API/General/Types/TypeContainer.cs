using MediatR;
using System;
using System.Collections.Generic;
using ThunderRaeder.API.Dtos;
using ThunderRaeder.API.Handlers.GenericHandlers;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;

namespace ThunderRaeder.API.General.Types
{
    public class TypeContainer : List<ITypes>
    {
        public TypeContainer()
        {
            AddRange(new List<ITypes>
            {
                new BookTypes<Book,BookDto,BookResponse>(),
                new AuthorTypes<Author,AuthorDto,AuthorResponse>(),
                new UserTypes<AppUser,UserDto,UserResponse>(),
                new UserBookTypes<AppUserBook>(),
                new AnnouncementTypes<Announcement, AnnouncementDto, AnnouncementResponse>(),
                new CommentTypes<Comment,CommentDto,CommentResponse>()
            });
        }

        public List<Type[]> HandlerTypes => new List<Type[]>()
        {
           new [] { typeof(IRequestHandler<,>), typeof(CreateHandler<,,,>) },
           new [] { typeof(IRequestHandler<,>), typeof(GetHandler<,,,>) },
           new [] { typeof(IRequestHandler<,>), typeof(GetByIdHandler<,,,>) },
           new [] { typeof(IRequestHandler<,>), typeof(UpdateHandler<,,,>) },
           new [] { typeof(IRequestHandler<,>), typeof(DeleteHandler<,>) }
        };
    }
}
