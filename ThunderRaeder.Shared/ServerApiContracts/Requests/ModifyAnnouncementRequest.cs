using System;

namespace ThunderRaeder.Shared.ServerApiContracts.Requests
{
    public class ModifyAnnouncementRequest
    {
        public Guid AppUserId { get; set; }
        public string Message { get; set; }
        public string AdditionalContent { get; set; }
        public int Upvotes { get; set; }
    }
}
