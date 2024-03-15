using EuropeanContracts.Infrastructure.Data.DataSeeding;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EuropeanContracts.Infrastructure.Data.Configuration
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            var data = new DataSeed();

            builder
                .HasData(new Offer[]
                {
                    data.TopOffer,
                    data.FirstOffer,
                    data.SecondOffer
                });
        }
    }
}
