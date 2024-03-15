using EuropeanContracts.Infrastructure.Data.DataSeeding;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EuropeanContracts.Infrastructure.Data.Configuration
{
    public class TrailerConfiguration : IEntityTypeConfiguration<Trailer>
    {
        public void Configure(EntityTypeBuilder<Trailer> builder)
        {
            var data = new DataSeed();

            builder
                .HasData(new Trailer[]
                {
                    data.FirstTrailer,
                    data.SecondTrailer,
                    data.ThirdTrailer
                });
        }
    }
}
