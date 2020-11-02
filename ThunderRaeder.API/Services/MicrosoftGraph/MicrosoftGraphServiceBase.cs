using Microsoft.Graph;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace ThunderRaeder.API.Services.MicrosoftGraph
{
    public abstract class MicrosoftGraphServiceBase
    {
        private readonly IGraphServiceClient _graphClient;

        public MicrosoftGraphServiceBase(IGraphServiceClient graphClient)
        {
            _graphClient = graphClient;
        }
        public async Task<T> SendAsync<T, U>(HttpRequestMessage httpMessage, U command)
        {
            httpMessage.Method = HttpMethod.Post;
            httpMessage.Content = new StringContent(_graphClient.HttpProvider.Serializer.SerializeObject(command));
            httpMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _graphClient.HttpProvider.SendAsync(httpMessage);

            return _graphClient.HttpProvider.Serializer
                .DeserializeObject<T>(await response.Content
                    .ReadAsStringAsync());
        }

        public async Task<T> GetAsync<T>(HttpRequestMessage httpMessage, string request = null)
        {
            httpMessage.Method = HttpMethod.Get;
            httpMessage.RequestUri = request == null ? httpMessage.RequestUri : new Uri(request);
            var response = await _graphClient.HttpProvider.SendAsync(httpMessage);
           return JsonSerializer.Deserialize<T>(await response.Content
                    .ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
