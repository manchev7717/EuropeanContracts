using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ITransportCompanyService
    {
        Task<bool> DoesTransporterExistsAsync(string country, string name);
        Task AddAsync(TransportCompany model);
        Task<bool> DoesTransporterExistFindByUserIdAsync(string userId);
        Task<bool> DoesUserIsTransportCompanyOwnerByIdAsync(string userId);

        Task<TransportCompany> ReturnTransporterByUserIdAsync(string userId);

    }
}
