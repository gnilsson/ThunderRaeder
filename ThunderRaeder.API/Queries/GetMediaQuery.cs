using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThunderRaeder.Shared.ServerApiContracts.ExtResponses;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Queries
{
    public class GetMediaQuery : IRequest<Response<DriveItemResponse>>
    {
        public string DriveId { get; }
        public GetMediaQuery(string driveId)
        {
            DriveId = driveId;
        }
    }
}

