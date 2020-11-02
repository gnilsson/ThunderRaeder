using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.API.Commands.Action;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.API.Services;
using ThunderRaeder.API.Services.MicrosoftGraph.Instructions;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Wrappers;

namespace ThunderRaeder.API.Handlers.CommandHandlers
{
    public class InviteUserHandler : CommandHandlerBase, IRequestHandler<InviteUserCommand, Response<InvitationResponse>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IServiceWrapper _sericeWrapper;

        public InviteUserHandler(IRepositoryWrapper repository, IMapper mapper, IServiceWrapper serviceWrapper)
        {
            _repository = repository;
            _mapper = mapper;
            _sericeWrapper = serviceWrapper;
        }

        public async Task<Response<InvitationResponse>> Handle(InviteUserCommand request, CancellationToken cancellationToken)
        {
            var invitation = await _sericeWrapper.Graph.CreateInvitationAsync(new CreateAzureInvitationInstruction
            {
                InvitedUserEmailAddress = request.InvitedUserEmailAddress,
                InviteRedirectUrl = request.InviteRedirectUrl
            });

            return invitation == null ? null : _mapper.Map<Response<InvitationResponse>>(invitation);
        }
    }
}
