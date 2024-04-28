using EuropeanContracts.Core.ServiceViewModels.Recipient;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface IRecipientCompanyService
    {
        Task<bool> DoesRecipientExists(string userId);

        Task<bool> DoesRecipientExists(string country, string name);

        Task AddAsync(AddRecipientCompanyModel model);

        Task<RecipientCompany> ReturnRecipientByUserIdAsync(string userId);
    }
}
