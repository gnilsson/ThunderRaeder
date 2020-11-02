using System.ComponentModel.DataAnnotations;

namespace ThunderRaeder.Shared.ServerApiContracts.Requests
{
    public class CreateUserRequest
    {
        public string Alias { get; set; }
        //public string GivenName { get; set; }
        //public string Surname { get; set; }
    }
}
