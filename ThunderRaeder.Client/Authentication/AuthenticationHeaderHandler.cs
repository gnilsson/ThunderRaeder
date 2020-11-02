using Blazored.LocalStorage;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using ThunderRaeder.Client.Descriptive;

namespace ThunderRaeder.Client.Authentication
{
    public class AuthenticationHeaderHandler : DelegatingHandler
    {
        private readonly ILocalStorageService _localStorage;

        public AuthenticationHeaderHandler(ILocalStorageService localStorage)
            => this._localStorage = localStorage;

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            if (request.Headers.Authorization?.Scheme != AuthDescriptions.Bearer)
            {
                var savedToken = await this._localStorage.GetItemAsync<string>(AuthDescriptions.TokenKey);

                if (!string.IsNullOrWhiteSpace(savedToken))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue(AuthDescriptions.Bearer, savedToken);
                }
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
