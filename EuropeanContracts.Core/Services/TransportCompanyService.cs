using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Core.Services
{
    public class TransportCompanyService : ITransportCompanyService
    {
        private readonly IRepository repository;
        public TransportCompanyService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(TransportCompany model)
        {
            await repository.AddAsync(model);
            await repository.SaveChangesAsync();
        }

        public async Task<bool> FindTransporterByIdAsync(string userId)
        {
            return await repository.AllReadOnly<TransportCompany>()
                .AnyAsync(t => t.OwnerId == userId);
        }

        public async Task<bool> IsTransporterExists(string country, string name)
        {
            return await repository.AllReadOnly<TransportCompany>()
                .AnyAsync(s => s.Country == country && s.Name == name);
        }

        public async Task<string> ReturnTransporterName(string userId)
        {
            var transporter = await repository.AllReadOnly<TransportCompany>()
                .FirstAsync(t => t.OwnerId == userId) ;

            return transporter.Name;
        }
    }
}
