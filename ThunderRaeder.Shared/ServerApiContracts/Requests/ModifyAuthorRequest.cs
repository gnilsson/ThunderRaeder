using ThunderRaeder.Shared.Enums;

namespace ThunderRaeder.Shared.ServerApiContracts.Requests
{
    public class ModifyAuthorRequest 
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public Gender Gender { get; set; }
    }
}
