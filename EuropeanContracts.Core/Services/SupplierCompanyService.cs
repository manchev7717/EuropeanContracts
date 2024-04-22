﻿using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Offer;
using EuropeanContracts.Core.ServiceViewModels.Supplier;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Constance;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Core.Services
{
    public class SupplierCompanyService : ISupplierCompanyService
    {
        private readonly IRepository repository;
        private readonly UserManager<EuropeanContractUser> userManager;
        public SupplierCompanyService(IRepository repository,
            UserManager<EuropeanContractUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }

        public async Task AddAsync(SupplierCompany model)
        {
            var user = await userManager.FindByIdAsync(model.OwnerId);

            await repository.AddAsync(model);
            await userManager.AddClaimAsync(user, new System.Security.Claims.Claim(
                CustomUserClaimType.UserCompanyNameCustomClaim, model.Name));
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
                .Include(a => a.Supplier)
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
                .Select(o => new OfferDetailViewModel()
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
                    CreatorPhoneNumber = o.Supplier.PhoneNumber,
                    CreatorName = o.Supplier.Name,
                    ActionDescription = o.ActionType.Description
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
