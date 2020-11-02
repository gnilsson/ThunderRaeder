using ThunderRaeder.Shared.Enums;
using ThunderRaeder.Shared.ServerApiContracts.Requests;

namespace ThunderRaeder.API.Infrastructure.Validation.Models
{
    public class AuthorValidationModel : IValidationModel
    {
        public AuthorValidationModel()
        { }
        public AuthorValidationModel(
            ModifyAuthorRequest request) =>
            (Gender, Firstname, Lastname) =
            (request.Gender, request.Firstname, request.Lastname);

        public Gender Gender { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public void Set(object request)
        {
            var author = request as ModifyAuthorRequest;
            Gender = author.Gender;
            Firstname = author.Firstname;
            Lastname = author.Lastname;
        }
    }
}
