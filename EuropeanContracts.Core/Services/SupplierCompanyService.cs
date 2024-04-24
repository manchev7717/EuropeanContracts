using EuropeanContracts.Core.Contracts;
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
