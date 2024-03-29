using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Services
{
    public class TruckService : ITruckService
    {
        private readonly IRepository repository;

        public TruckService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddTruckAsync(Truck truckModel)
        {
            await repository.AddAsync(truckModel);
            await repository.SaveChangesAsync();
        }
    }
}
