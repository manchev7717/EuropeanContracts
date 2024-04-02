using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Services
{
    public class TrailerService : ITrailerService
    {
        private readonly IRepository repository;
        public TrailerService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddTruckAsync(Trailer trailerModel)
        {
            await repository.AddAsync(trailerModel);      
            await repository.SaveChangesAsync();
        }
    }
}
