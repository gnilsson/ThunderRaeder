using System;
using ThunderRaeder.Shared.Enums;

namespace ThunderRaeder.Shared.ServerApiContracts.Requests
{
    public class ModifyBookRequest
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public Genre Genre { get; set; }

        public Guid AuthorId { get; set; }

        public string DriveId { get; set; }

        public int PopularityScore { get; set; }
    }
}
