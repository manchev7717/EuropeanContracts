using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ITransportCompanyService
    {
        Task<bool> IsTransporterExistsAsync(string country, string name);
        Task AddAsync(TransportCompany model);
        Task<bool> FindTransporterByIdAsync(string userId);
        Task<string> ReturnTransporterNameAsync(string userId);

        Task<TransportCompany> FindTransporterByUserIdAsync(string userId);

        Task<AllTrucksViewModel> AllTruckAsync(string isTemperatureNeeded,int currentPage, int truckPerPage, int transportCompanyId);
    }
}
