using System.ComponentModel.DataAnnotations;

namespace ThunderRaeder.Shared.ServerApiContracts.Requests
{
    public class InviteUserRequest
    {
        [Required]
        [EmailAddress]
        public string InvitedUserEmailAddress { get; set; }
        [Required]
        public string InviteRedirectUrl { get; set; }
    }
}
