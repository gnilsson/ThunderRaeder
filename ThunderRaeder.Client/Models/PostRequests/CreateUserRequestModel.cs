using ThunderRaeder.Shared.ServerApiContracts.Requests;

namespace ThunderRaeder.Client.Models.PostRequests
{
    public class CreateUserRequestModel : ModifyUserRequest, IPostRequest<ModifyUserRequest>
    {
        public ModifyUserRequest ToRequest()
        {
            return this;
        }
    }
}
