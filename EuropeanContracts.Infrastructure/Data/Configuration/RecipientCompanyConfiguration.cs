using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EuropeanContracts.Infrastructure.Data.Configuration
{
    public class RecipientCompanyConfiguration : IEntityTypeConfiguration<RecipientCompany>
    {
        public void Configure(EntityTypeBuilder<RecipientCompany> builder)
        {
        }
    }
}
