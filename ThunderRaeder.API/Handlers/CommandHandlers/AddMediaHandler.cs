using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.API.Commands.Action;
using ThunderRaeder.API.Services;
using ThunderRaeder.API.Services.MicrosoftGraph.Dtos;
using ThunderRaeder.Shared.ServerApiContracts.ExtResponses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Handlers.CommandHandlers
{
    public class AddMediaHandler : 
                 IRequestHandler<AddMediaCommand, Response<DriveItemResponse>>
    {
        private readonly IServiceWrapper _serviceWrapper;
        public AddMediaHandler(IServiceWrapper serviceWrapper) 
            => (_serviceWrapper) = (serviceWrapper);
       
        public async Task<Response<DriveItemResponse>> Handle(
            AddMediaCommand request, 
            CancellationToken cancellationToken)    
        {
            var driveItem = await _serviceWrapper.Graph.AddDcoumentAsync(request.File);
            return new Response<DriveItemResponse>(
                new DriveItemResponse { Id = driveItem.Id, WebUrl = driveItem.WebUrl });
        }
    }
}
