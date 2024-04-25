using EuropeanContracts.Core.ServiceViewModels.Supplier;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ISupplierCompanyService
    {
        Task<bool> DoesSupplierExists(string country,string name);

        Task AddAsync(SupplierCompany model);

        Task<bool> DoesSupplierExists(string userId);

        Task<int> ReturnSupplierIdByUserId(string userId);

        
    }
}
