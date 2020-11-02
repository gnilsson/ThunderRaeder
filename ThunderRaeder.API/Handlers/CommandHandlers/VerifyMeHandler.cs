using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.API.Commands.Action;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.API.Services;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Handlers.CommandHandlers
{
    public class VerifyMeHandler : CommandHandlerBase, IRequestHandler<VerifyMeCommand, Response<VerificationResponse>>
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IServiceWrapper _serviceWrapper;

        public VerifyMeHandler(IRepositoryWrapper repositoryWrapper, IServiceWrapper serviceWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _serviceWrapper = serviceWrapper;
        }
        public Task<Response<VerificationResponse>> Handle(VerifyMeCommand request, CancellationToken cancellationToken)
        {
            // var upn = _serviceWrapper.Graph.GetAvailableUpnAsync(request.Email);
            //_repository.Identity.ConfirmUserEmail(identityUser.Result);
            return null;
        }
    }
}
