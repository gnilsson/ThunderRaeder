using System;
using System.Collections.Generic;
using ThunderRaeder.Shared.Enums;

namespace ThunderRaeder.API.Dtos
{
    public class AuthorDto
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public List<BookDto> Books { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
