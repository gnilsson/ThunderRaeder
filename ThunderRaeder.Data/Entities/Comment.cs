using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ThunderRaeder.Data.Entities
{
    [Table("Comments")]
    public class Comment : Entity, IIdentifiableEntity
    {
        [Key]
        public Guid Id { get; set; }
        public Guid AnnouncementId { get; set; }
        [ForeignKey(nameof(AnnouncementId))]
        public Announcement Announcement { get; set; }
        public AppUser AppUser { get; set; }
        [Required]
        [MaxLength(280)]
        public string Message { get; set; }
        public string AdditionalContent { get; set; }
        public int Upvotes { get; set; }
    }
}
