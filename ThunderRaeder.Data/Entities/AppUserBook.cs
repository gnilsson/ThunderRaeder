using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThunderRaeder.Data.Entities
{
    [Table("AppUserBooks")]
    public class AppUserBook : Entity
    {
        public AppUserBook()
        {

        }
        [Required]
        public AppUser AppUser { get; set; }
        [Required]
        public Book Book { get; set; }
        public Guid AppUserId { get; set; }
        public Guid BookId { get; set; }
        public int PercentageRead { get; set; }
    }
}
