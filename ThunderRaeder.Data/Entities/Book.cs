using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThunderRaeder.Shared.Enums;

namespace ThunderRaeder.Data.Entities
{
    public class Book : Entity, IIdentifiableEntity
    {
        public Book()
        {
            this.AppUserBooks = new HashSet<AppUserBook>();
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        [Required]
        [MaxLength(2500)]
        public string Description { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
        public ICollection<AppUserBook> AppUserBooks { get; set; }
        public string DriveId { get; set; }
        public int PopularityScore { get; set; }
    }
}
