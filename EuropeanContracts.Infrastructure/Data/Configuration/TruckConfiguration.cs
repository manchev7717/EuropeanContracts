using EuropeanContracts.Infrastructure.Data.DataSeeding;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EuropeanContracts.Infrastructure.Data.Configuration
{
    public class TruckConfiguration : IEntityTypeConfiguration<AutoTruck>
    {
        public void Configure(EntityTypeBuilder<AutoTruck> builder)
        {
            var data = new DataSeed();

            builder
                .HasData(new AutoTruck[]
                {
                    data.FirstTruck,
                    data.SecondTruck,
                    data.ThirdTruck,
                    data.FourthTruck
                });
        }
    }
}
