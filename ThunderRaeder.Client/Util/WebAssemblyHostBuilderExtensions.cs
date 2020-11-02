using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using Tewr.Blazor.FileReader;
using ThunderRaeder.Client.Authentication;
using ThunderRaeder.Client.Descriptive;
using ThunderRaeder.Client.HttpClients;
using ThunderRaeder.Client.Services;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace ThunderRaeder.Client.Util
{
    public static class WebAssemblyHostBuilderExtensions
    {
        private const string RestClientName = "ThunderRaeder.ServerAPI";
        public static WebAssemblyHostBuilder AddRootComponents(this WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("app");
            return builder;
        }

        public static WebAssemblyHostBuilder AddClientServices(this WebAssemblyHostBuilder builder)
        {
            builder.Services.AddLoadingBar();
            builder.Services.AddHttpClient<IdentityClient>(client =>
                client.BaseAddress = new Uri(
                    builder.Configuration.GetSection(
                        ConfigurationDescriptions.ExternalApis)[ConfigurationDescriptions.IdentityApiUrlKey]));
            builder.Services.AddApiAuthorization();
            builder.Services
                .AddBlazoredLocalStorage()
                .AddScoped<ApiAuthenticationStateProvider>()
                .AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>()
                .AddScoped(sp => sp
                    .GetRequiredService<IHttpClientFactory>()
                        .CreateClient(RestClientName))
                .AddTransient<IAuthService, AuthService>()
                .AddScoped<RefreshTokenService>()
                .AddTransient<AuthenticationHeaderHandler>()
                .AddHttpClient(RestClientName, (sp, client) =>
                {
                    client.BaseAddress = new Uri(
                        builder.Configuration.GetSection(
                            ConfigurationDescriptions.ExternalApis)[ConfigurationDescriptions.ServerApiUrlKey]);
                    client.EnableIntercept(sp);
                })
                .AddHttpMessageHandler<AuthenticationHeaderHandler>();

            builder.Services.AddHttpClientInterceptor();
            builder.Services.AddScoped<HttpInterceptorService>();
            builder.Services.AddFileReaderService(o => o.UseWasmSharedBuffer = true);
            return builder;
        }
    }
}
