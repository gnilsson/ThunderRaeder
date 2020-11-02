using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ThunderRaeder.Client.HttpClients
{
    public class RestClient
    {
        private readonly HttpClient _httpClient;
        private const string Path = "/api/v1";

        public RestClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //public async Task<TResult> GetById<TResult>(string route)
        //{

        //}
    }
}
