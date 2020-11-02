using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Threading.Tasks;
using ThunderRaeder.Client.Util;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace ThunderRaeder.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
            => await WebAssemblyHostBuilder
                .CreateDefault(args)
                .AddRootComponents()
                .AddClientServices()
                .Build()
                .UseLoadingBar()
                .RunAsync();
    }
}
