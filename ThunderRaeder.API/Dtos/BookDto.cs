using System;
using ThunderRaeder.Shared.Enums;

namespace ThunderRaeder.API.Dtos
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
        public AuthorDto Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string DriveId { get; set; }
    }
}
