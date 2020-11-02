using Microsoft.AspNetCore.WebUtilities;

namespace ThunderRaeder.API.Extensions
{
    public static class WebExtensions
    {
        public static string AppendQueryString(this string uri, string queryName, string queryValue)
        {
            return QueryHelpers.AddQueryString(uri, queryName, queryValue);
        }
    }
}
