namespace EuropeanContracts.Core.Contracts
{
    public interface ITransportCompanyService
    {
        Task<bool> FindTransporterByIdAsync(string userId);
        Task<string> ReturnTransporterName(string userId);
    }
}
