using System;

namespace ThunderRaeder.API.Dtos
{
    public class UserBookDto
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
