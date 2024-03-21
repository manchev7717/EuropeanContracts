using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.Models;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace EuropeanContracts.Core.Services
{
    public class OfferService : IOfferService
    {
        private readonly IRepository repository;
        public OfferService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<string>> AllActionTypesAsync()
        {
            return await repository.AllReadOnly<ActionType>()
                .Select(a => a.Name)
                .ToListAsync();
        }
        public async Task<IEnumerable<string>> AllCountryNamesAsync()
        {
            return await repository.AllReadOnly<Offer>()
                .Select(a => a.LoadingCountry)
                .ToListAsync();
        }

        public async Task<OffersAndCountViewModel> AllAsync(
                            string? actionType,
                            string? country,
                            string? isTemperatureControlNeeded,
                            int currentPage,
                            int offersCountOnPage)
        {


            var offers = await repository.AllReadOnly<Offer>()
                .Include(a => a.ActionType)
                .ToListAsync();

            if (actionType != null)
            {
                offers = offers
                    .Where(o => o.ActionType.Name == actionType)
                    .ToList();
            }
            if (country != null)
            {
                offers = offers
                    .Where(o => o.LoadingCountry == country)
                    .ToList();
            }
            if (isTemperatureControlNeeded != null)
            {
                bool result = isTemperatureControlNeeded =="true" ? true : false;

                offers = offers
                    .Where(o => o.IsTemperatureControlNeeded == result)
                    .ToList();
            }

            var offerResult = offers
                .Skip((currentPage - 1) * offersCountOnPage)
                .Take(offersCountOnPage)
                .Select(o => new OfferViewModel()
                {
                    Id = o.Id,
                    ProductName = o.ProductName,
                    ProductImageURL = o.ProductImageURL,
                    ProductQuantity = o.ProductQuantity,
                    ProductPrice = o.ProductPrice,
                    LoadingAddress = o.LoadingAddress,
                    LoadingCountry = o.LoadingCountry,
                    IsTemperatureControlNeeded = o.IsTemperatureControlNeeded,
                    PublicationDay = o.PublicationDay,
                    ActionType = o.ActionType.Name,
                    SupplierId = o.SupplierId,
                })
                .ToList();

            return new OffersAndCountViewModel()
            {
                OfferViewModels = offerResult,
                AllOffersCount = offers.Count()
            };
        }



    }
}
