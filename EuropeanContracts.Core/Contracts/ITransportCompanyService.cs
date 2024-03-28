using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ITransportCompanyService
    {
        Task<bool> IsTransporterExists(string country, string name);
        Task AddAsync(TransportCompany model);
        Task<bool> FindTransporterByIdAsync(string userId);
        Task<string> ReturnTransporterName(string userId);
    }
}
