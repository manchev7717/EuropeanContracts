using EuropeanContracts.Infrastructure.Data.DataSeeding;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EuropeanContracts.Infrastructure.Data.Configuration
{
    public class RecipientCompanyConfiguration : IEntityTypeConfiguration<RecipientCompany>
    {
        public void Configure(EntityTypeBuilder<RecipientCompany> builder)
        {
            var data = new DataSeed();

            builder
                .HasData(new RecipientCompany[]
                {
                    data.FirstRecipientCompany,
                    data.SecondRecipientCompany,
                    data.ThirdRecipientCompany,
                });
        }
    }
}
