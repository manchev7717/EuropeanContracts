using EuropeanContracts.Core.ServiceViewModels.Truck;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ITruckService
    {
        Task AddTruckAsync(AutoTruck truckModel);

        Task<bool> ExistByIdAsync(int truckId);

        Task<bool> UserIsTransportCompanyOwnerByIdAsync(string userId);

        Task<EditAndDeleteTruckViewModel> ReturnEditTruckViewModelById(int truckId);

        Task EditAsync(EditAndDeleteTruckViewModel model);

        Task DeleteAsync(int id);

        Task<IEnumerable<TruckIdAndRegistrationViewModel>> GetTruckForOffer(int transporterId);

        Task<bool> HasTruckTemperaturControl(int truckId);

    }
}
