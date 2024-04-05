using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ITransportCompanyService
    {
        Task<bool> IsTransporterExistsAsync(string country, string name);
        Task AddAsync(TransportCompany model);
        Task<bool> IsTransporterExistFindByIdAsync(string userId);
        Task<string> ReturnTransporterNameAsync(string userId);

        Task<TransportCompany> ReturnTransporterByUserIdAsync(string userId);

        Task<AllTrucksViewModel> AllTrucksAsync(string isTemperatureNeeded,
                                                string hasCargoSpace, 
                                                int currentPage, 
                                                int truckPerPage, 
                                                int transportCompanyId);

        Task<AllTrailersViewModel> AllTrailersAsync(string isTemperatureControlNeeded,
                                                    int currentPage,
                                                    int trailersCountOnPage,
                                                    int transportCompanyId);

        public Task<OffersAndCountTransporterViewModel> AllOffersAsync(
                            string isContract,
                            int currentPage,
                            int offersCountOnPage,
                            string userId);
    }
}
