using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ITrailerService
    {
        Task AddTruckAsync(Trailer trailerModel);
    }
}
