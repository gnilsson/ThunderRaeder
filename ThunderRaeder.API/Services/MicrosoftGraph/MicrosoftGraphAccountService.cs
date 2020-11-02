using Microsoft.Graph;
using System;
using System.Threading.Tasks;
using ThunderRaeder.API.Dtos;

namespace ThunderRaeder.API.Services.MicrosoftGraph
{
    public class MicrosoftGraphAccountService : MicrosoftGraphServiceBase, IMicrosoftGraphAccountService
    {
        private readonly IGraphServiceClient _graphClient;

        public MicrosoftGraphAccountService(IGraphServiceClient graphClient) : base(graphClient)
        {
            _graphClient = graphClient;
        }

        public Task<User> CreateUserAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetMeAsync()
        {
            try
            {
                return await _graphClient.Me.Request().GetAsync();
            }
            catch
            {
                return null;
            }
        }
    }
}
