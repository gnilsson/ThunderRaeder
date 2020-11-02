using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using ThunderRaeder.API.Infrastructure.Middleware;
using ThunderRaeder.API.Security.Settings;

namespace ThunderRaeder.API.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void ConfigureExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }

        public static void ConfigureSwagger(this IApplicationBuilder app, IConfiguration configuration)
        {
            var swaggerSettings = new SwaggerSettings().Bind(configuration);
            app.UseSwagger(option => { option.RouteTemplate = swaggerSettings.JsonRoute; });
            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint(swaggerSettings.UIEndpoint, swaggerSettings.Description);
            });
        }
    }
}
//    app.UseSerilogRequestLogging();