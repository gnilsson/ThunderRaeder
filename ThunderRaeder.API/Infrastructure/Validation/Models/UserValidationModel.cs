using ThunderRaeder.Shared.ServerApiContracts.Requests;

namespace ThunderRaeder.API.Infrastructure.Validation.Models
{
    public class UserValidationModel : IValidationModel
    {
        public UserValidationModel()
        { }

        public UserValidationModel(ModifyUserRequest request) =>
            (Alias) = (request.Alias);

        public string Alias { get; set; }

        public void Set(object request)
        {
            var user = request as ModifyUserRequest;
            Alias = user.Alias;
        }
    }
}
