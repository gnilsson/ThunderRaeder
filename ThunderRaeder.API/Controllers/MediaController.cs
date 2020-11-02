using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ThunderRaeder.API.Commands.Action;
using ThunderRaeder.API.Extensions;
using ThunderRaeder.API.Queries;
using ThunderRaeder.Shared.ServerApiContracts;
namespace ThunderRaeder.API.Controllers
{
    [Authorize]
    public class MediaController : ApiControllerBase
    {
        public MediaController(IMediator mediator) : base(mediator)
        { }

        [HttpGet(ApiRoutes.Media.Get)]
        public async Task<IActionResult> GetMedia(string driveId)
            => await Mediator
                .Send(new GetMediaQuery(driveId))
                .ToOkResult();


        [HttpPost(ApiRoutes.Media.Add)]
        public async Task<IActionResult> AddMedia() // [FromBody] AddMediaRequest request
            => await Mediator
                .Send(new AddMediaCommand(null, Request.Form.Files))
                .ToCreatedResult(ApiRoutes.Media.Add);

    }
}