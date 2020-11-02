using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ThunderRaeder.API.General.Descriptive;
using ThunderRaeder.API.Infrastructure.Extensions;

namespace ThunderRaeder.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(o => 
            { o.JsonSerializerOptions.PropertyNameCaseInsensitive = true; });
            services.AddDatabase(Configuration);
            services.AddCors(Cors.Policy);
            services.AddTypeContainerItems();
            services.AddRepositoryWrapper();
            services.AddInfrastructure();
            services.AddJwt(Configuration);
            services.AddAuthorizationHandlers();
            services.AddSwagger();
            services.AddServiceWrapper(Configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.ConfigureExceptionMiddleware();
            app.ConfigureSwagger(Configuration);
            app.UseHttpsRedirection();
            app.UseCors(Cors.Policy);
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
