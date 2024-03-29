using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ITruckService
    {
        Task AddTruckAsync(Truck truckModel);
    }
}
