using Microsoft.AspNetCore.Authorization;

namespace ThunderRaeder.API.Security.Authorization
{
    public class WorksForCompanyRequirement : IAuthorizationRequirement
    {
        public string DomainName { get; set; }
        public WorksForCompanyRequirement(string domainName)
        {
            DomainName = domainName;
        }

    }
}
