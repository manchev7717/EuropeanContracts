using EuropeanContracts.Core.ServiceViewModels.Offer;
using EuropeanContracts.Core.ServiceViewModels.Recipient;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface IOfferService
    {
        Task<IEnumerable<string>> AllActionTypesAsync();
        Task<IEnumerable<string>> AllCountryNamesAsync();

        Task<OffersAndCountViewModel> AllAsync(
                            string? actionType,
                            string? country,
                            string? isTemperatureControlNeeded,
                            int currentPage,
                            int offersCountOnPage);

        Task<IEnumerable<ActionType>> ActionTypesAsync();

        Task CreateOfferAsync(CreateOfferViewModel model);

        Task<DetailOfferViewModel> DetailsOfferAsync(int offerId);

        Task AddTransporterInOfferAsync(AddTransportCompanyInOfferViewModel model);
        Task AddRecipientInOfferAsync(AddRecipientCompanyInOfferViewModel model);

    }
}
