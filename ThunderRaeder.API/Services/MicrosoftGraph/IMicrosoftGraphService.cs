using Microsoft.AspNetCore.Http;
using Microsoft.Graph;
using System.Threading.Tasks;
using ThunderRaeder.API.Services.MicrosoftGraph.Instructions;

namespace ThunderRaeder.API.Services.MicrosoftGraph
{
    public interface IMicrosoftGraphService
    {
        Task<User> GetUserAsync(string userPrincipalName);
        Task<User> CreateUserAsync(CreateAzureAdUserInstruction instruction);
        Task<Invitation> CreateInvitationAsync(CreateAzureInvitationInstruction instruction);
        Task SendMailAsync(string message, string email);
        Task<string> GetAvailableUpnAsync(string email, int? attempt = null);
        Task<List> GetDocumentLibraryAsync();
        Task<DriveItem> AddDcoumentAsync(IFormFile file);
        Task<DriveItem> GetDocumentAsync(string documentId);
    }
}
