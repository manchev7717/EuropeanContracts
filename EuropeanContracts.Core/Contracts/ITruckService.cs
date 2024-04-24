using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Core.ServiceViewModels.Truck;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ITruckService
    {
        Task AddTruckAsync(AutoTruck truckModel);

        Task<bool> ExistByIdAsync(int truckId);


        Task<EditAndDeleteTruckViewModel> ReturnEditTruckViewModelByIdAsync(int truckId);

        Task EditAsync(EditAndDeleteTruckViewModel model);

        Task DeleteAsync(int id);

        Task<IEnumerable<TruckIdAndRegistrationViewModel>> GetTruckForOfferAsync(int transporterId);

        Task<bool> HasTruckTemperaturControlAsync(int truckId);

        Task<AllTrucksViewModel> AllTrucksAsync(string isTemperatureNeeded,
                                                string hasCargoSpace,
                                                int currentPage,
                                                int truckPerPage,
                                                int transportCompanyId);


    }
}
