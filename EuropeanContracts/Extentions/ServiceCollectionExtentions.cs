using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.Services;
using EuropeanContracts.Data;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Extentions
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IOfferService, OfferService>();
            services.AddScoped<ISupplierCompanyService, SupplierCompanyService>();
            services.AddScoped<ITransportCompanyService, TransportCompanyService>();
            services.AddScoped<IRecipientCompanyService, RecipientCompanyService>();
            services.AddScoped<ITruckService, TruckService>();
            return services;
        }

        public static IServiceCollection AddApplicationDbContex(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<EuropeanContractsDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
                options.EnableSensitiveDataLogging();
            });

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;

        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services)
        {
            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;

            }).AddEntityFrameworkStores<EuropeanContractsDbContext>();

            return services;
        }
    }
}
