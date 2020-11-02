using Microsoft.Graph;
using System;
using System.Collections.Generic;
using ThunderRaeder.Shared.Enums;

namespace ThunderRaeder.API.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public UserType UserType { get; set; }
        public string IdentityId { get; set; }
        public string Alias { get; set; }
        public string UserPrincipalName { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public User AzureUser { get; set; }
        public IEnumerable<UserBookDto> AppUserBooks { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
