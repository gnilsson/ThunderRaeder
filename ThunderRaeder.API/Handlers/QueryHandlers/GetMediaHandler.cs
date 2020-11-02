using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.API.Queries;
using ThunderRaeder.API.Services;
using ThunderRaeder.Shared.ServerApiContracts.ExtResponses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;
namespace ThunderRaeder.API.Handlers.QueryHandlers
{
    public class GetMediaHandler : 
                 IRequestHandler<GetMediaQuery, Response<DriveItemResponse>>
    {
        private readonly IServiceWrapper _serviceWrapper;
        public GetMediaHandler(IServiceWrapper serviceWrapper)
            => (_serviceWrapper) = (serviceWrapper);

        public async Task<Response<DriveItemResponse>> Handle(
            GetMediaQuery request,
            CancellationToken cancellationToken)
        {
            var driveItem = await _serviceWrapper.Graph.GetDocumentAsync(request.DriveId);
            return new Response<DriveItemResponse>(
                new DriveItemResponse { Id = driveItem.Id, WebUrl = driveItem.WebUrl });
        }
    }
}
