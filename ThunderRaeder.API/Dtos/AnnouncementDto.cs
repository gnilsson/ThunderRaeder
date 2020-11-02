using System;
using System.Collections.Generic;

namespace ThunderRaeder.API.Dtos
{
    public class AnnouncementDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Message { get; set; }
        public string AdditionalContent { get; set; }
        public int Upvotes { get; set; }
        public List<CommentDto> Comments { get; set; }
        public List<BookDto> Books { get; set; }
    }
}
