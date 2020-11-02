using Microsoft.AspNetCore.Http;
using System.Linq;

namespace ThunderRaeder.Utility.Identity
{
    public static class Extensions
    {
        public static string GetUserId(this HttpContext httpContext)
        {
            return httpContext.User?.Claims.Single(x => x.Type == "id").Value ?? string.Empty;
        }
        public static string GetUserEmail(this HttpContext httpContext)
        {
            return httpContext.User?.Claims.Single(x => x.Type == "emailid").Value ?? string.Empty;
        }
    }
}
