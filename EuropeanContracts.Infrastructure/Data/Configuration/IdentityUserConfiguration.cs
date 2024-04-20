using EuropeanContracts.Infrastructure.Data.DataSeeding;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EuropeanContracts.Infrastructure.Data.Configuration
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<EuropeanContractUser>
    {
        public void Configure(EntityTypeBuilder<EuropeanContractUser> builder)
        {
            var data = new DataSeed();

            builder
                .HasData(new EuropeanContractUser[]
                {
                    data.FirstUser,
                    data.SecondUser,
                    data.ThirdUser,
                    data.FourthUser,
                    data.FifthUser,
                    data.SixthUser,
                    data.SeventhUser,
                    data.EighthUser,
                });
        }
    }
}
