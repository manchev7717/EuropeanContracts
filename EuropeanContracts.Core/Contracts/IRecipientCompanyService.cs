using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface IRecipientCompanyService
    {
        Task<bool> IsRecipientExistFindByUserIdAsync(string userId);

        Task<string> ReturnRecipientName(string userId);

        Task<bool> IsRecipientExists(string country, string name);

        Task AddAsync(RecipientCompany model);
    }
}
