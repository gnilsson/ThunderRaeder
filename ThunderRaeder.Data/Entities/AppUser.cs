using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ThunderRaeder.Shared.Enums;

namespace ThunderRaeder.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : Entity, IIdentifiableEntity
    {
        public AppUser()
        {
            this.AppUserBooks = new HashSet<AppUserBook>();
            this.Comments = new HashSet<Comment>();
            this.Announcements = new HashSet<Announcement>();
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Username { get; set; }
        public string IdentityId { get; set; }
        [ForeignKey(nameof(IdentityId))]
        public IdentityUser User { get; set; }
        public UserType UserType { get; set; }
        public ICollection<AppUserBook> AppUserBooks { get; set; }
        public string Alias { get; set; }
        public string UserPrincipalName { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Announcement> Announcements { get; set; }
    }
}
