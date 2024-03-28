using EuropeanContracts.Core.Contracts;
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

        public async Task<bool> FindRecipientByIdAsync(string userId)
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
    }
}
