using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ThunderRaeder.API.Commands.Action;
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
    public class UsersController : ApiControllerBase
    {
        public UsersController(IMediator mediator) : base(mediator)
        { }

        //      [Authorize(Policy = AuthorizePolicy.AnagnosEmployee)]
        [HttpGet(ApiRoutes.Users.Get)]
        public async Task<IActionResult> GetUsers([FromQuery] GetUsersRequest request)
            => await Mediator
                .Send(new GetUsersQuery(request))
                .ToOkResult();

        //[Authorize(Roles = "Premium")]
        [HttpGet(ApiRoutes.Users.GetById)]
        public async Task<IActionResult> GetUser(Guid userId)
            => await Mediator
                .Send(new GetByIdQuery<UserResponse>(userId))
                .ToOkResult();

        [HttpPost(ApiRoutes.Users.Create)]
        public async Task<IActionResult> CreateUser([FromBody] ModifyUserRequest request)
            => await Mediator
                .Send(new CreateUserCommand(request, HttpContext))
                .ToCreatedAtResult<Response<UserResponse>, UserResponse, GetUserRoute>();

        [HttpPost(ApiRoutes.Users.AddBooks)]
        public async Task<IActionResult> AddBooks([FromBody] AddUserBooksRequest request)
            => await Mediator
                .Send(new AddUserBooksCommand(request))
                .ToCreatedAtResult<Response<UserResponse>, UserResponse, GetUserRoute>();

        [HttpPost(ApiRoutes.Users.Invite)]
        public async Task<IActionResult> Invite([FromBody] InviteUserRequest request)
            => await Mediator
                .Send(new InviteUserCommand(request, HttpContext))
                .ToOkResult();

        [HttpPut(ApiRoutes.Users.Update)]
        public async Task<IActionResult> UpdateBook(Guid userId, [FromBody] ModifyUserRequest request)
            => await Mediator
                .Send(new UpdateUserCommand(request, userId))
                .ToOkResult();

        [HttpDelete(ApiRoutes.Users.Delete)]
        public async Task<IActionResult> DeleteBook(Guid userId)
            => await Mediator
                .Send(new DeleteCommand<AppUser>(userId))
                .ToOkResult();
    }
}
