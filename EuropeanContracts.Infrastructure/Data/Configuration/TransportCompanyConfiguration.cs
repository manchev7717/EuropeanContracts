using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EuropeanContracts.Infrastructure.Data.Configuration
{
    public class TransportCompanyConfiguration : IEntityTypeConfiguration<TransportCompany>
    {
        public void Configure(EntityTypeBuilder<TransportCompany> builder)
        {
        }
    }
}
