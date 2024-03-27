namespace EuropeanContracts.Core.Contracts
{
    public interface IRecipientCompanyService
    {
        Task<bool> FindRecipientByIdAsync(string userId);

        Task<string> ReturnRecipientName(string userId);
    }
}
