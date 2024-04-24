using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ITransportCompanyService
    {
        Task<bool> IsTransporterExistsAsync(string country, string name);
        Task AddAsync(TransportCompany model);
        Task<bool> IsTransporterExistFindByUserIdAsync(string userId);
        Task<string> ReturnTransporterNameAsync(string userId);
        Task<bool> UserIsTransportCompanyOwnerByIdAsync(string userId);

        Task<TransportCompany> ReturnTransporterByUserIdAsync(string userId);

    }
}
