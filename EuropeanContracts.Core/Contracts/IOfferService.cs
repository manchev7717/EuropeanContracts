﻿using EuropeanContracts.Core.ServiceViewModels.Offer;

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
