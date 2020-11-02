using System;

namespace ThunderRaeder.API.Dtos
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Message { get; set; }
        public string AdditionalContent { get; set; }
        public int Upvotes { get; set; }
        public Guid AnnouncementId { get; set; }
    }
}
