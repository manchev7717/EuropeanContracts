using EuropeanContracts.Core.ServiceViewModels.Offer;
using EuropeanContracts.Core.ServiceViewModels.Transporter;

namespace EuropeanContracts.Core.Contracts
{
    public interface IOfferService
    {
        Task<IEnumerable<string>> AllActionTypesAsync();
        Task<IEnumerable<string>> AllCountryNamesAsync();

        public Task<OffersAndCountViewModel> AllAsync(
                            string? actionType,
                            string? country,
                            string? isTemperatureControlNeeded,
                            int currentPage,
                            int offersCountOnPage);
        
    }
}
