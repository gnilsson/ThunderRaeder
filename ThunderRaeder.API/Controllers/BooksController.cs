using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ThunderRaeder.API.Commands.Create;
using ThunderRaeder.API.Commands.Generic;
using ThunderRaeder.API.Commands.Update;
using ThunderRaeder.API.Extensions;
using ThunderRaeder.API.General.ActionRoutes;
using ThunderRaeder.API.Queries;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Controllers
{
    [Authorize]
    public class BooksController : ApiControllerBase
    {
        public BooksController(IMediator mediator) : base(mediator)
        { }

        [HttpGet(ApiRoutes.Books.Get)]
        public async Task<IActionResult> GetBooks([FromQuery] GetBooksRequest request)
            => await Mediator
                .Send(new GetBooksQuery(request))
                .ToOkResult();

        [HttpGet(ApiRoutes.Books.GetById)]
        public async Task<IActionResult> GetBook(Guid bookId)
            => await Mediator
                .Send(new GetByIdQuery<BookResponse>(bookId))
                .ToOkResult();

        [HttpPost(ApiRoutes.Books.Create)]
        public async Task<IActionResult> CreateBook([FromBody] ModifyBookRequest request)
            => await Mediator
                .Send(new CreateBookCommand(request))
                .ToCreatedAtResult<Response<BookResponse>, BookResponse, GetBookRoute>();

        [HttpPut(ApiRoutes.Books.Update)]
        public async Task<IActionResult> UpdateBook(Guid bookId, [FromBody] ModifyBookRequest request)
            => await Mediator
                .Send(new UpdateBookCommand(request, bookId))
                .ToOkResult();

        [HttpDelete(ApiRoutes.Books.Delete)]
        public async Task<IActionResult> DeleteBook(Guid bookId)
            => await Mediator
                .Send(new DeleteCommand<Book>(bookId))
                .ToOkResult();
    }
}
