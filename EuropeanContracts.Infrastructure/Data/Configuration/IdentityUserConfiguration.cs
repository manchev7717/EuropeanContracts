using EuropeanContracts.Infrastructure.Data.DataSeeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EuropeanContracts.Infrastructure.Data.Configuration
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var data = new DataSeed();

            builder
                .HasData(new IdentityUser[]
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
