using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Offer;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

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
        
        public async Task<IEnumerable<ActionType>> ActionTypesAsync()
        {
            var result = await repository.AllReadOnly<ActionType>()
                .ToListAsync();

            return result;
        }

        public async Task CreateOfferAsync(CreateOfferViewModel model)
        {
            Offer newOffer = new Offer()
            {
                ProductName = model.ProductName,
                ProductDescription = model.ProductDescription,
                ProductQuantity = model.ProductQuantity,
                ProductPrice = model.ProductPrice,
                ProductImageURL= model.ProductImageURL,
                LoadingCountry = model.LoadingCountry,
                LoadingAddress= model.LoadingAddress,
                CountryOfDestination = model.CountryOfDestination,
                IsTemperatureControlNeeded= model.IsTemperatureControlNeeded,
                PublicationDay = model.PublicationDay,
                SupplierId= model.SupplierId,
                ActionTypeId = model.ActionTypeId,
            };
            await repository.AddAsync(newOffer);
            await repository.SaveChangesAsync();
        }
    }
}
