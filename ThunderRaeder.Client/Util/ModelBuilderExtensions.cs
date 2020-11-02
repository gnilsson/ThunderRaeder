using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Simplified;

namespace ThunderRaeder.Client.Util
{
    // temp solution?
    public static class ModelBuilderExtensions
    {
        public static string GetFullname(this AuthorResponseSimplified authorResponse)
            => $"{authorResponse.LastName}, {authorResponse.FirstName}";
        public static string GetFullname(this AuthorResponse authorResponse)
            => $"{authorResponse.Lastname}, {authorResponse.Firstname}";
    }
}
