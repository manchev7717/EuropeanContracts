using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Offer;
using EuropeanContracts.Core.ServiceViewModels.Supplier;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace EuropeanContracts.Core.Services
{
    public class SupplierCompanyService : ISupplierCompanyService
    {
        private readonly IRepository repository;
        public SupplierCompanyService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(SupplierCompany model)
        {
            await repository.AddAsync(model);
            await repository.SaveChangesAsync();
        }

        public async Task<SupplierOffersAndCountViewModel> AllOffersAsync(int currentPage, 
                                                                          int offersCountOnPage,
                                                                          string isContract,
                                                                          int supplierId)
        {
            var offers = await repository.AllReadOnly<Offer>()
                .Where(o=>o.SupplierId == supplierId)
                .Include(a => a.ActionType)
                .ToListAsync();

            if (isContract != null)
            {
                bool result = isContract == "true" ? true : false;

                offers = offers
                    .Where(o => o.IsContract == result)
                    .ToList();
            }

            var offerResult = offers
                .Skip((currentPage - 1) * offersCountOnPage)
                .Take(offersCountOnPage)
                .Select(o => new SupplierOfferViewModel()
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

            return new SupplierOffersAndCountViewModel()
            {
                OfferViewModels = offerResult,
                AllOffersCount = offers.Count()
            };
        }

        public async Task<bool> FindSupplierByIdAsync(string userId)
        {
            return await repository.AllReadOnly<SupplierCompany>()
                .AnyAsync(s => s.OwnerId == userId);
        }

        public async Task<bool> IsSupplierExists(string country, string name)
        {
            return await repository.AllReadOnly<SupplierCompany>()
                .AnyAsync(s => s.Country == country && s.Name == name);
        }

        public async Task<int> ReturnSupplierIdByUserId(string userId)
        {
            var supplier = await repository.AllReadOnly<SupplierCompany>()
                .Where(s=>s.OwnerId == userId)
                .FirstAsync();

            return supplier.Id;
        }

        public async Task<string> ReturnSupplierName(string userId)
        {
            var supplier = await repository.AllReadOnly<SupplierCompany>()
                .FirstAsync(s => s.OwnerId == userId);

            return supplier.Name;
        }
    }
}
