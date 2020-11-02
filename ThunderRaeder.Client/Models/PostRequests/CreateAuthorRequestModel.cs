using ThunderRaeder.Shared.ServerApiContracts.Requests;

namespace ThunderRaeder.Client.Models.PostRequests
{
    public class CreateAuthorRequestModel : ModifyAuthorRequest, IPostRequest<ModifyAuthorRequest>
    {
        public ModifyAuthorRequest ToRequest()
        {
            return new ModifyAuthorRequest
            {
                Firstname = this.Firstname,
                Lastname = this.Lastname,
                Gender = this.Gender
            };
        }
    }
}
