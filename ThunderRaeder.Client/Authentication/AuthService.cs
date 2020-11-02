using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ThunderRaeder.Client.Descriptive;
using ThunderRaeder.Client.HttpClients;
using ThunderRaeder.Shared.Authentication;

namespace ThunderRaeder.Client.Authentication
{
    public class AuthService : IAuthService
    {
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly IdentityClient _identityClient;
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider,
                           IdentityClient identityClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _identityClient = identityClient;
            _localStorage = localStorage;
        }

        public async Task<AuthenticationResult> Login(UserLoginRequest userLoginRequest)
        {
            var content = new StringContent(JsonSerializer.Serialize(userLoginRequest), Encoding.UTF8, HttpContentType.ApplicationJson);
            var response = await _identityClient.PostAsync(IdentityActions.Login, content);
            var authResult = JsonSerializer.Deserialize<AuthenticationResult>(await response.Content.ReadAsStringAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            authResult.Success = response.IsSuccessStatusCode;

            if (!response.IsSuccessStatusCode)
                return authResult;

            await SetTokens(authResult.Token, authResult.RefreshToken);
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(userLoginRequest.Email);

            return authResult;
        }

        public async Task Logout()
        {
            await RemoveTokens();
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
        }

        public async Task<string> RefreshToken()
        {
            var token = await _localStorage.GetItemAsync<string>(AuthDescriptions.TokenKey);
            var refreshToken = await _localStorage.GetItemAsync<string>(AuthDescriptions.RefreshKey);
            var request = JsonSerializer.Serialize(
                new RefreshTokenRequest { Token = token, RefreshToken = refreshToken });

            var refreshResult = await _identityClient.PostAsync(IdentityActions.Refresh, new StringContent(
                request, Encoding.UTF8, HttpContentType.ApplicationJson));
            var result = JsonSerializer.Deserialize<AuthenticationResult>(await refreshResult.Content.ReadAsStringAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (!refreshResult.IsSuccessStatusCode)
                return string.Empty;

            await SetTokens(result.Token, result.RefreshToken);
            return result.Token;
        }

        public async Task<AuthenticationResult> Register(UserRegistrationRequest userRegistrationRequest)
        {
            var response = await _identityClient.PostAsJsonAsync(IdentityActions.Register, userRegistrationRequest);
            var parsedResult = await response.Content.ReadFromJsonAsync<AuthenticationResult>();
            parsedResult.Success = response.IsSuccessStatusCode;
            return parsedResult;
        }

        private async Task SetTokens(string token, string refreshToken)
        {
            await _localStorage.SetItemAsync(AuthDescriptions.TokenKey, token);
            await _localStorage.SetItemAsync(AuthDescriptions.RefreshKey, refreshToken);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AuthDescriptions.Bearer, token);
        }
        private async Task RemoveTokens()
        {
            await _localStorage.RemoveItemAsync(AuthDescriptions.TokenKey);
            await _localStorage.RemoveItemAsync(AuthDescriptions.RefreshKey);
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}
