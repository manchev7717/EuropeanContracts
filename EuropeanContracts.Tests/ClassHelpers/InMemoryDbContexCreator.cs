using EuropeanContracts.Data;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Tests.ClassHelpers
{
    static class InMemoryDbContexCreator
    {

        public static EuropeanContractsDbContext Create(string contextName)
        {
            var optionsDb = new DbContextOptionsBuilder<EuropeanContractsDbContext>()
                .UseInMemoryDatabase(contextName + DateTime.Now.Ticks.ToString())
                .Options;

            return new EuropeanContractsDbContext(optionsDb);

        }
    }
}
