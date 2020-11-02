using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ThunderRaeder.Client.Descriptive;

namespace ThunderRaeder.Client.HttpClients
{
    public class IdentityClient
    {
        private readonly HttpClient _httpClient;
        private const string Path = "/api/v1/identity";

        public IdentityClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> PostAsync(string action, StringContent content)
        {
            return await _httpClient.PostAsync($"{Path}{action}", content);
        }

        public async Task<HttpResponseMessage> PostAsJsonAsync<TRequest>(string action, TRequest content)
        {
            return await _httpClient.PostAsJsonAsync($"{Path}{action}", content);
        }
    }
}
