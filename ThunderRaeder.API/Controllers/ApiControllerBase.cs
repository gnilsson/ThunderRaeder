using MediatR;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Serilog.Core;

namespace ThunderRaeder.API.Controllers
{
    public abstract class ApiControllerBase : ControllerBase
    {
        internal IMediator Mediator { get; }
        internal ApiControllerBase(IMediator mediator)
        {
            Mediator = mediator;
        }       
    }
}
