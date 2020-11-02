using ThunderRaeder.Shared.ServerApiContracts.Responses.Simplified;

namespace ThunderRaeder.Shared.ServerApiContracts.Responses
{
    public class BookResponse : IIdentifiableResponse, IEntityResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public AuthorResponseSimplified Author { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public string DriveId { get; set; }
    }
}
