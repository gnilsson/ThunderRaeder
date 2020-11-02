using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;
using System;
using System.Net;
using ThunderRaeder.API.Security.Authentication;
using ThunderRaeder.API.Security.Settings;

namespace ThunderRaeder.API.Services.MicrosoftGraph
{
    public class GraphServiceClientFactory
    {
        private readonly MsGraphSettings _configuration;

        public GraphServiceClientFactory(MsGraphSettings msGraphSettings)
        {
            _configuration = msGraphSettings;
        }
        public IGraphServiceClient Initialize()
        {
            if (_configuration == null)
            {
                throw new ArgumentNullException($"{_configuration} cannot be null.");
            }

            GraphServiceClient graphClient;

            try
            {
                // Initiate client application
                var confidentialClientApplication = ConfidentialClientApplicationBuilder
                    .Create(_configuration.ClientId)
                    .WithTenantId(_configuration.TenantId)
                    .WithClientSecret(_configuration.ClientSecret)
                    .Build();

                // Create the auth provider
                var authProvider = new ClientCredentialProvider(confidentialClientApplication);

                // Create Graph Service Client
                graphClient = new GraphServiceClient(authProvider);
            }
            catch (ServiceException ex)
            {
                //throw new GraphApiClientException(
                //    HttpStatusCode.BadRequest,
                //    $"Could not create a Graph Service Client: {ex.Message}");
                throw ex;
            }

            // Return
            return graphClient;
        }

        public IGraphServiceClient InitializeAccount()
        {
            var authProvider = new DeviceCodeAuthProvider(
            _configuration.ClientId, _configuration.Scopes.Split(';'));
            return new GraphServiceClient(authProvider);
        }

        public IGraphServiceClient InitializeMail(IMicrosoftGraphService graphService, string email)
        {
            try
            {
                var authProvider = new DeviceCodeAuthProvider(
                _configuration.ClientId, _configuration.Scopes.Split(';'), graphService, email);
                return new GraphServiceClient(authProvider);
            }
            catch
            {
                // logger
                return null;
            }
        }
    }
}
