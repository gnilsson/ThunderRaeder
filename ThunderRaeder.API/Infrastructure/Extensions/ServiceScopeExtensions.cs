using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Threading.Tasks;
using ThunderRaeder.Data.Contexts;

namespace ThunderRaeder.API.Infrastructure.Extensions
{
    public static class ServiceScopeExtensions
    {
        public static async Task TryMigrateDatabaseAsync(this IServiceScope scope)
        {
            try
            {
                var context = scope.ServiceProvider.GetRequiredService<ThunderRaederDbContext>();
                await context.Database.MigrateAsync();

                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if (roleManager == null)
                    return;

                if (!await roleManager.RoleExistsAsync("Admin"))
                {
                    var adminRole = new IdentityRole("Admin");
                    await roleManager.CreateAsync(adminRole);
                }
                if (!await roleManager.RoleExistsAsync("Premium"))
                {
                    var premiumRole = new IdentityRole("Premium");
                    await roleManager.CreateAsync(premiumRole);
                }

            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Catched an error while migrating the database.");
            }
        }
    }
}
