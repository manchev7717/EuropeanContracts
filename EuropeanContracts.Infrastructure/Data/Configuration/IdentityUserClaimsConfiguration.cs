using EuropeanContracts.Infrastructure.Data.DataSeeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Infrastructure.Data.Configuration
{
    public class IdentityUserClaimsConfiguration : IEntityTypeConfiguration<IdentityUserClaim<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders
            .EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserClaim<string>> builder)
        {
            var data = new DataSeed();

            builder
                .HasData(new IdentityUserClaim<string>[]
                {
                    data.FirstUserClaim,
                    data.SecondUserClaim,
                    data.ThirdUserClaim,
                    data.FourthUserClaim,
                    data.FifthUserClaim,
                    data.SixthUserClaim,
                    data.SeventhUserClaim,
                    data.EighthUserClaim,
                    data.FirstSupplierClaim,
                    data.SecondSupplierClaim,
                    data.ThirdSupplierClaim,
                    data.FirstRecipientClaim,
                    data.SecondRecipientClaim,
                    data.ThirdRecipientClaim,
                    data.FirstTransporterClaim,
                    data.SecondTransporterClaim,
                    data.LawyerClaim,
                    data.TestUserClaim
                }); 
        }
    }
}
