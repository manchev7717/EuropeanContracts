using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EuropeanContracts.Infrastructure.Data.Configuration
{
    public class SupplierCompanyConfiguration : IEntityTypeConfiguration<SupplierCompany>
    {
        public void Configure(EntityTypeBuilder<SupplierCompany> builder)
        {
        }
    }
}
