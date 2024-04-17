using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Recipient;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Core.Services
{
    public class RecipientCompanyService : IRecipientCompanyService
    {
        private readonly IRepository repository;
        public RecipientCompanyService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<bool> IsRecipientExistFindByUserIdAsync(string userId)
        {
            return await repository.AllReadOnly<RecipientCompany>()
                .AnyAsync(r => r.OwnerId == userId);
        }

        public async Task<string> ReturnRecipientName(string userId)
        {
            var recipient = await repository.AllReadOnly<RecipientCompany>()
                 .FirstAsync(r => r.OwnerId == userId);

            return recipient.Name;
        }
        public async Task<bool> IsRecipientExists(string country, string name)
        {
            return await repository.AllReadOnly<RecipientCompany>()
                .AnyAsync(s => s.Country == country && s.Name == name);
        }

        public async Task AddAsync(RecipientCompany model)
        {
            await repository.AddAsync(model);
            await repository.SaveChangesAsync();

        }

        public async Task<OffersAndCountRecipientViewModel> AllOffersAsync(string isContract,
                                                                     int currentPage, 
                                                                     int offersCountOnPage,
                                                                     string userId)
        {
            var currentRecipient = await repository.AllReadOnly<RecipientCompany>()
                .Where(t => t.OwnerId == userId)
                .FirstAsync();

            var offers = await repository.AllReadOnly<Offer>()
               .Include(a => a.ActionType)
               .Where(o => o.RecipientId == currentRecipient.Id)
               .ToListAsync();

            if (!string.IsNullOrEmpty(isContract))
            {
                bool result = isContract == "true" ? true : false;

                offers = offers
                    .Where(o => o.IsContract == result)
                    .ToList();
            }

            var offerResult = offers
                .Skip((currentPage - 1) * offersCountOnPage)
                .Take(offersCountOnPage)
                .Select(o => new OfferRecipientViewModel()
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
                    IsContract = o.IsContract,
                })
                .ToList();

            return new OffersAndCountRecipientViewModel()
            {
                OfferViewModels = offerResult,
                AllOffersCount = offers.Count()
            };
        }

        public async Task<RecipientCompany> ReturnRecipientByUserIdAsync(string userId)
        {
            return await repository.AllReadOnly<RecipientCompany>()
                .Where(t => t.OwnerId == userId)
                .FirstAsync();
        }
    }
}
