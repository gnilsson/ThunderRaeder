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
    public class AuthorsController : ApiControllerBase
    {
        public AuthorsController(IMediator mediator) : base(mediator)
        { }

        [HttpGet(ApiRoutes.Authors.Get)]
        //[Authorize(Policy = "Custom")]
        public async Task<IActionResult> GetAuthors([FromQuery] GetAuthorsRequest request)
            => await Mediator
                .Send(new GetAuthorsQuery(request))
                .ToOkResult();

        [HttpGet(ApiRoutes.Authors.GetById)]
        public async Task<IActionResult> GetAuthor(Guid authorId)
            => await Mediator
                .Send(new GetByIdQuery<AuthorResponse>(authorId))
                .ToOkResult();

        [HttpPost(ApiRoutes.Authors.Create)]
        public async Task<IActionResult> CreateAuthor([FromBody] ModifyAuthorRequest request)
            => await Mediator
                .Send(new CreateAuthorCommand(request))
                .ToCreatedAtResult<Response<AuthorResponse>, AuthorResponse, GetAuthorRoute>();

        [HttpPut(ApiRoutes.Authors.Update)]
        public async Task<IActionResult> UpdateBook(Guid authorId, [FromBody] ModifyAuthorRequest request)
            => await Mediator
                .Send(new UpdateAuthorCommand(request, authorId))
                .ToOkResult();

        [HttpDelete(ApiRoutes.Authors.Delete)]
        public async Task<IActionResult> DeleteBook(Guid authorId)
            => await Mediator
                .Send(new DeleteCommand<Author>(authorId))
                .ToOkResult();
    }
}
