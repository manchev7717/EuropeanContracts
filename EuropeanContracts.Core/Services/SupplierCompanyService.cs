using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Core.Services
{
    public class SupplierCompanyService : ISupplierCompanyService
    {
        private readonly IRepository repository;
        public SupplierCompanyService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(SupplierCompany model)
        {
             await repository.AddAsync(model);
             await repository.SaveChangesAsync();
        }

        public async Task<bool> FindSupplierByIdAsync(string userId)
        {
            return await repository.AllReadOnly<SupplierCompany>()
                .AnyAsync(s => s.OwnerId == userId);
        }

        public async Task<bool> IsSupplierExists(string country, string name)
        {
            return await repository.AllReadOnly<SupplierCompany>()
                .AnyAsync(s => s.Country == country && s.Name == name);
        }

        public async Task<string> ReturnSupplierName(string userId)
        {
            var supplier = await repository.AllReadOnly<SupplierCompany>()
                .FirstAsync(s => s.OwnerId == userId);

            return supplier.Name;
        }
    }
}
