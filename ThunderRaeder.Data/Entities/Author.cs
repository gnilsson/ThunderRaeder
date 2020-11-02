using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThunderRaeder.Shared.Enums;

namespace ThunderRaeder.Data.Entities
{
    public class Author : Entity, IIdentifiableEntity
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(150)]
        public string Lastname { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
