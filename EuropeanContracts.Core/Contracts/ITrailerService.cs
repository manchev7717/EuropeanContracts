using EuropeanContracts.Core.ServiceViewModels.Trailer;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Core.ServiceViewModels.Truck;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ITrailerService
    {
        Task AddTruckAsync(Trailer trailerModel);
        Task EditAsync(EditAndDeleteTrailerViewModel model);

        Task DeleteAsync(int id);

        Task<bool> ExistByIdAsync(int trailerId);
        Task<EditAndDeleteTrailerViewModel> ReturnEditTrailerViewModelByIdAsync(int trailerId);

        Task<bool> HasTrailerTemperaturControlAsync(int? trailerId);
        Task<IEnumerable<TrailerIdAndRegistrationViewModel>> GetTrailerForOfferAsync(bool isTemperatureRequired, 
                                                                                     int transporterId);
        Task<AllTrailersViewModel> AllTrailersAsync(string isTemperatureControlNeeded,
                                                    int currentPage,
                                                    int trailersCountOnPage,
                                                    int transportCompanyId);

    }
}
