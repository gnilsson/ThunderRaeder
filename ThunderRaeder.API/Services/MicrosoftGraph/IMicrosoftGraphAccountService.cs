using Microsoft.Graph;
using System.Threading.Tasks;
using ThunderRaeder.API.Dtos;

namespace ThunderRaeder.API.Services.MicrosoftGraph
{
    public interface IMicrosoftGraphAccountService
    {
        Task<User> GetMeAsync();
        Task<User> CreateUserAsync();
    }
}
