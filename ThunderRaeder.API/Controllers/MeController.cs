using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ThunderRaeder.API.Extensions;
using ThunderRaeder.API.Queries;
using ThunderRaeder.Shared.ServerApiContracts;

namespace ThunderRaeder.API.Controllers
{
    [Authorize]
    public class MeController : ApiControllerBase
    {
        public MeController(IMediator mediator) : base(mediator)
        { }

        [HttpGet(ApiRoutes.Me.Get)]
        public async Task<IActionResult> GetMe()
           => await Mediator
               .Send(new GetMeQuery(HttpContext))
               .ToOkResult();

        [HttpGet(ApiRoutes.Me.Verify)]
        public async Task <IActionResult> VerifyMe()
        {
            return NotFound();
        }

        [HttpGet(ApiRoutes.Me.Books)]
        public IActionResult GetMeBooks()
        {
            return NotFound();
        }

        [HttpPost(ApiRoutes.Me.AddBook)]
        public IActionResult AddMeBook()
        {
            return NotFound();
        }
    }
}
