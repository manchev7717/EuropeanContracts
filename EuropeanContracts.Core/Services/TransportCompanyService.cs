using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Constance;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Core.Services
{
    public class TransportCompanyService : ITransportCompanyService
    {
        private readonly IRepository repository;
        private readonly UserManager<EuropeanContractUser> userManager;
        public TransportCompanyService(IRepository repository,
            UserManager<EuropeanContractUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }

        public async Task AddAsync(TransportCompany model)
        {
            var user = await userManager.FindByIdAsync(model.OwnerId);

            await repository.AddAsync(model);
            await userManager.AddClaimAsync(user, new System.Security.Claims.Claim(
                CustomUserClaimType.UserCompanyNameCustomClaim, model.Name));
            await repository.SaveChangesAsync();
        }


        public async Task<bool> DoesTransporterExistsAsync(string userId)
        {
            return await repository.AllReadOnly<TransportCompany>()
                .AnyAsync(t => t.OwnerId == userId);
        }

        public async Task<bool> DoesTransporterExistsAsync(string country, string name)
        {
            return await repository.AllReadOnly<TransportCompany>()
                .AnyAsync(s => s.Country == country && s.Name == name);
        }
        public async Task<TransportCompany?> ReturnTransporterByUserIdAsync(string userId)
        {
            return await repository.AllReadOnly<TransportCompany>()
                .Where(t => t.OwnerId == userId)
                .FirstOrDefaultAsync();
        }


    }
}
