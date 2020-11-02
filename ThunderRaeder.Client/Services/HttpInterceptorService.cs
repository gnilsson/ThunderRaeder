using System.Net.Http.Headers;
using Toolbelt.Blazor;

namespace ThunderRaeder.Client.Services
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor _interceptor;
        private readonly RefreshTokenService _refreshTokenService;

        public HttpInterceptorService(HttpClientInterceptor interceptor, RefreshTokenService refreshTokenService)
        {
            _interceptor = interceptor;
            _refreshTokenService = refreshTokenService;
        }

        public void RegisterEvent() => _interceptor.BeforeSend += InterceptBeforeHttp;

        public async void InterceptBeforeHttp(object sender, HttpClientInterceptorEventArgs e)
        {
            var absPath = e.Request.RequestUri.AbsolutePath;
            if (!absPath.Contains("token") && !absPath.Contains("identity"))
            {
                var token = await _refreshTokenService.TryRefreshToken();
                if (!string.IsNullOrEmpty(token))
                    e.Request.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            }
        }

        public void DisposeEvent() => _interceptor.BeforeSend -= InterceptBeforeHttp;
    }
}
