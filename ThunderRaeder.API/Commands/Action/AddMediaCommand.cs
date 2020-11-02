using MediatR;
using Microsoft.AspNetCore.Http;
using ThunderRaeder.API.Services.MicrosoftGraph.Dtos;
using ThunderRaeder.Shared.ServerApiContracts.ExtResponses;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Commands.Action
{
    public class AddMediaCommand : IRequest<Response<DriveItemResponse>>
    {
        public IFormFile File { get; }
        public AddMediaCommand(AddMediaRequest request, IFormFileCollection files)
        {
            File = files[0];
        }
    }
}
