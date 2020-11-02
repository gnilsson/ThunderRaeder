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
    public class CommentsController : ApiControllerBase
    {
        public CommentsController(IMediator mediator) : base(mediator)
        { }

        [HttpGet(ApiRoutes.Comments.Get)]
        public async Task<IActionResult> GetComments([FromQuery] GetCommentsRequest request)
            => await Mediator
                .Send(new GetDefaultQuery<CommentResponse>(request, ApiRoutes.Comments.Get))
                .ToOkResult();

        [HttpGet(ApiRoutes.Comments.GetById)]
        public async Task<IActionResult> GetComment(Guid commentId)
            => await Mediator
                .Send(new GetByIdQuery<CommentResponse>(commentId))
                .ToOkResult();

        [HttpPost(ApiRoutes.Comments.Create)]
        public async Task<IActionResult> CreateComment([FromBody] ModifyCommentRequest request)
            => await Mediator
                .Send(new CreateCommand<CommentResponse>(request))
                .ToCreatedAtResult<Response<CommentResponse>, CommentResponse, GetCommentRoute>();

        [HttpPut(ApiRoutes.Comments.Update)]
        public async Task<IActionResult> UpdateComment(Guid commentId, [FromBody] ModifyCommentRequest request)
            => await Mediator
                .Send(new UpdateCommand<CommentResponse>(request, commentId))
                .ToOkResult();

        [HttpDelete(ApiRoutes.Comments.Delete)]
        public async Task<IActionResult> DeleteComment(Guid commentId)
            => await Mediator
                .Send(new DeleteCommand<Comment>(commentId))
                .ToOkResult();
    }
}
