using System;
using System.Collections.Generic;
using ThunderRaeder.Shared.ServerApiContracts.Requests;
using ThunderRaeder.Shared.ServerApiContracts.Responses;

namespace ThunderRaeder.Client.Models.PostRequests
{
    public class CreateBookRequestModel : ModifyBookRequest, IPostRequest<ModifyBookRequest>
    {
        public IEnumerable<AuthorResponse> AuthorOptions { get; set; }
        public AuthorResponse SelectedAuthor { get; set; }

        public ModifyBookRequest ToRequest()
        {
            return new ModifyBookRequest()
            {
                AuthorId = new Guid(SelectedAuthor.Id),
                Title = this.Title,
                Description = this.Description,
                Genre = this.Genre, // ?
                DriveId = this.DriveId ?? string.Empty
            };            
        }
    }
}
