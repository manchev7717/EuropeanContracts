using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EuropeanContracts.Infrastructure.Data.Configuration
{
    public class ActionTypeConfiguration : IEntityTypeConfiguration<ActionType>
    {
        public void Configure(EntityTypeBuilder<ActionType> builder)
        {
            throw new NotImplementedException();
        }
    }
}
