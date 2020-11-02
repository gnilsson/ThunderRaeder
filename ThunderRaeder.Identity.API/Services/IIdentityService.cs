using System.Threading.Tasks;
using ThunderRaeder.Identity.API.Results;

namespace ThunderRaeder.Identity.API.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
        Task<AuthenticationResult> LoginAsync(string email, string password);
        Task<AuthenticationResult> RefreshTokenAsync(string token, string refreshToken);
    }
}
