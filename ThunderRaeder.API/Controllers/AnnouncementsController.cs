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
    public class AnnouncementsController : ApiControllerBase
    {
        public AnnouncementsController(IMediator mediator) : base(mediator)
        { }

        [HttpGet(ApiRoutes.Announcements.Get)]
        public async Task<IActionResult> GetAnnouncements([FromQuery] GetAnnouncementsRequest request)
            => await Mediator
                .Send(new GetDefaultQuery<AnnouncementResponse>(request, ApiRoutes.Announcements.Get))
                .ToOkResult();

        [HttpGet(ApiRoutes.Announcements.GetById)]
        public async Task<IActionResult> GetAnnouncement(Guid announcementId)
            => await Mediator
                .Send(new GetByIdQuery<AnnouncementResponse>(announcementId))
                .ToOkResult();

        [HttpPost(ApiRoutes.Announcements.Create)]
        public async Task<IActionResult> CreateAnnouncement([FromBody] ModifyAnnouncementRequest request)
            => await Mediator
                .Send(new CreateCommand<AnnouncementResponse>(request))
                .ToCreatedAtResult<Response<AnnouncementResponse>, AnnouncementResponse, GetAnnouncementRoute>();

        [HttpPut(ApiRoutes.Announcements.Update)]
        public async Task<IActionResult> UpdateAnnouncement(Guid announcementId, [FromBody] ModifyAnnouncementRequest request)
            => await Mediator
                .Send(new UpdateCommand<AnnouncementResponse>(request, announcementId))
                .ToOkResult();

        [HttpDelete(ApiRoutes.Announcements.Delete)]
        public async Task<IActionResult> DeleteAnnouncement(Guid announcementId)
            => await Mediator
                .Send(new DeleteCommand<Announcement>(announcementId))
                .ToOkResult();
    }
}
