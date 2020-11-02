using System;
using System.Collections.Generic;
using System.Text;

namespace ThunderRaeder.Shared.ServerApiContracts.Responses
{

    public class AnnouncementResponse : IIdentifiableResponse, IEntityResponse
    {
        public string Id { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public string Message { get; set; }
        public string AdditionalContent { get; set; }
        public int Upvotes { get; set; }
    }
}
