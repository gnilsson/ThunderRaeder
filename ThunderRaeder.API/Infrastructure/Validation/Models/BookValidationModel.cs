using System;
using ThunderRaeder.Shared.Enums;
using ThunderRaeder.Shared.ServerApiContracts.Requests;

namespace ThunderRaeder.API.Infrastructure.Validation.Models
{
    public class BookValidationModel : IValidationModel
    {
        public BookValidationModel()
        { }
        public BookValidationModel(
            ModifyBookRequest request) =>
            (AuthorId, Genre) =
            (request.AuthorId, request.Genre);

        public Guid AuthorId { get; set; }
        public Genre Genre { get; set; }

        public void Set(object request)
        {
            var book = request as ModifyBookRequest;
            AuthorId = book.AuthorId;
            Genre = book.Genre;


            //    public Guid Id { get; set; }
            //    internal string Title { get; }
            //    internal string Description { get; }
            //    internal Genre Genre { get; }
            //    internal Guid AuthorId { get; }
            //    internal string DriveId { get; }
            //    internal int PopularityScore { get; }
        }
    }
}
