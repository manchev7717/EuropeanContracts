using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Microsoft.AspNetCore.Builder
{
    public static class WebApplicationBuilderExtention
    {
        public static async Task CreateAdminRoleAsync(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();

            var service = scope.ServiceProvider;
            var userManager = service.GetRequiredService<UserManager<EuropeanContractUser>>();
            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();

            if (userManager!= null && 
                roleManager != null && 
                await roleManager.RoleExistsAsync(RoleConstance.AdminRole) == false )
            {
                var role = new IdentityRole(RoleConstance.AdminRole);
                await roleManager.CreateAsync(role);
                var adminLayer = await userManager.FindByEmailAsync(RoleConstance.AdminEmail);

                if (adminLayer!= null)
                {
                    await userManager.AddToRoleAsync(adminLayer, role.Name);
                }
            }

        }
    }
}
