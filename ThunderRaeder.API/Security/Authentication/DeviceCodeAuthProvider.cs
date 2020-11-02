using Microsoft.Graph;
using Microsoft.Identity.Client;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ThunderRaeder.API.Services.MicrosoftGraph;

namespace ThunderRaeder.API.Security.Authentication
{
    public class DeviceCodeAuthProvider : IAuthenticationProvider
    {
        private readonly IPublicClientApplication _msalClient;
        private readonly string[] _scopes;
        private IAccount _userAccount;
        private readonly IMicrosoftGraphService _graphService;
        private readonly string _email;

        public DeviceCodeAuthProvider(string appId, string[] scopes)
        {
            _scopes = scopes;
            _msalClient = PublicClientApplicationBuilder
                .Create(appId)
                .WithAuthority(AadAuthorityAudience.AzureAdAndPersonalMicrosoftAccount, true)
                .Build();
        }

        public DeviceCodeAuthProvider(string appId, string[] scopes, IMicrosoftGraphService graphService, string email)
        {
            _scopes = scopes;
            _msalClient = PublicClientApplicationBuilder
                .Create(appId)
                .WithAuthority(AadAuthorityAudience.AzureAdAndPersonalMicrosoftAccount, true)
                .Build();
            _graphService = graphService;
            _email = email;
        }

        public async Task<string> GetAccessToken()
        {
            if (_userAccount == null)
            {
                try
                {
                    var result = await _msalClient.AcquireTokenWithDeviceCode(_scopes, async callback =>
                    {
                        if (_email == null)
                        {
                            Console.WriteLine(callback.Message);
                        }
                        else
                        {
                            await _graphService.SendMailAsync(callback.Message, _email);
                        }
                        await Task.Delay(100);
                        return;
                    }).ExecuteAsync();

                    _userAccount = result.Account;
                    return result.AccessToken;
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Error getting access token: {exception.Message}");
                    return null;
                }
            }
            else
            {
                var result = await _msalClient
                    .AcquireTokenSilent(_scopes, _userAccount)
                    .ExecuteAsync();
                return result.AccessToken;
            }
        }

        public async Task AuthenticateRequestAsync(HttpRequestMessage requestMessage)
        {
            requestMessage.Headers.Authorization =
                new AuthenticationHeaderValue("bearer", await GetAccessToken());
        }
    }
}
