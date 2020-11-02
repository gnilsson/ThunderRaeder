using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ThunderRaeder.Data.Entities
{
    [Table("Announcements")]
    public class Announcement : Entity , IIdentifiableEntity
    {
        public Announcement()
        {
            this.Comments = new HashSet<Comment>();
            this.Books = new HashSet<Book>();
        }
        [Key]
        public Guid Id { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Book> Books { get; set; }
        public Guid AppUserId { get; set; }
        [ForeignKey(nameof(AppUserId))]
        public AppUser AppUser { get; set; }
        [Required]
        [MaxLength(5000)]
        public string Message { get; set; }
        public string AdditionalContent { get; set; }
        public int Upvotes { get; set; }
    }
}
