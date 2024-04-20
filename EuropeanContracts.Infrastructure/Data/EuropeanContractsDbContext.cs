using EuropeanContracts.Infrastructure.Data.Configuration;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Data
{
    public class EuropeanContractsDbContext : IdentityDbContext<EuropeanContractUser>
    {
        public EuropeanContractsDbContext(DbContextOptions<EuropeanContractsDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<ActionType> ActionsTypes { get; set; } = null!;

        public DbSet<RecipientCompany> RecipientsCompanies {  get; set; } = null!;

        public DbSet<SupplierCompany> SuppliersCompanies { get; set; } = null!;

        public DbSet<Trailer> Trailers { get; set; } = null!;

        public DbSet<TransportCompany> TransportsCompanies { get; set; } = null!;

        public DbSet<AutoTruck> AutoTrucks { get; set; } = null!;

        public DbSet<Offer> Offers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new IdentityUserConfiguration());
            builder.ApplyConfiguration(new ActionTypeConfiguration());
            builder.ApplyConfiguration(new TransportCompanyConfiguration());
            builder.ApplyConfiguration(new SupplierCompanyConfiguration());
            builder.ApplyConfiguration(new RecipientCompanyConfiguration());
            builder.ApplyConfiguration(new TrailerConfiguration());
            builder.ApplyConfiguration(new TruckConfiguration());
            builder.ApplyConfiguration(new OfferConfiguration());

            base.OnModelCreating(builder);
        }

    }
}
