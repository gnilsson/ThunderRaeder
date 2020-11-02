using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThunderRaeder.Shared.ServerApiContracts.Requests;

namespace ThunderRaeder.Client.Models.PostRequests
{
    public class InviteUserRequestModel : InviteUserRequest, IPostRequest<InviteUserRequest>
    {
        public InviteUserRequest ToRequest()
        {
            return this;
        }
    }
}
