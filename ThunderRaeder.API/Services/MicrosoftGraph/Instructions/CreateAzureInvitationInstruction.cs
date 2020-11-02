using Microsoft.Graph;

namespace ThunderRaeder.API.Services.MicrosoftGraph.Instructions
{
    public class CreateAzureInvitationInstruction
    {
        public string InvitedUserEmailAddress { get; set; }
        public string InviteRedirectUrl { get; set; }
        public bool SendInvitationMessage { get; set; } = true;

        public Invitation BuildModel() 
        {
            return new Invitation
            {
                InvitedUserEmailAddress = InvitedUserEmailAddress,
                InviteRedirectUrl = InviteRedirectUrl,
                SendInvitationMessage = SendInvitationMessage,
            };
        }
    }
}
