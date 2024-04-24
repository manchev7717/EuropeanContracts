using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Recipient;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Constance;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Core.Services
{
    public class RecipientCompanyService : IRecipientCompanyService
    {
        private readonly IRepository repository;
        private readonly UserManager<EuropeanContractUser> userManager;
        public RecipientCompanyService(IRepository repository
            ,UserManager<EuropeanContractUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
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
            var user = await userManager.FindByIdAsync(model.OwnerId);

            await repository.AddAsync(model);
            await userManager.AddClaimAsync(user, new System.Security.Claims.Claim(
                        CustomUserClaimType.UserCompanyNameCustomClaim, model.Name));
            await repository.SaveChangesAsync();

        }

        public async Task<RecipientCompany> ReturnRecipientByUserIdAsync(string userId)
        {
            return await repository.AllReadOnly<RecipientCompany>()
                .Where(t => t.OwnerId == userId)
                .FirstAsync();
        }
    }
}
