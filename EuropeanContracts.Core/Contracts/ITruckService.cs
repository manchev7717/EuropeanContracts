using EuropeanContracts.Core.ServiceViewModels.Truck;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ITruckService
    {
        Task AddTruckAsync(Truck truckModel);

        Task<bool> ExistByIdAsync(int truckId);

        Task<bool> UserIsTransportCompanyOwnerByIdAsync(string userId);

        Task<EditTruckViewModel> ReturnEditTruckViewModelById(int truckId);

        Task EditAsync(EditTruckViewModel model);
    }
}
