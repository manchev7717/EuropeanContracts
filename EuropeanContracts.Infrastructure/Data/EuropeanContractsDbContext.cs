using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Data
{
    public class EuropeanContractsDbContext : IdentityDbContext
    {
        public EuropeanContractsDbContext(DbContextOptions<EuropeanContractsDbContext> options)
            : base(options)
        {
            
        }

    }
}
