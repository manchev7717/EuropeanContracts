namespace EuropeanContracts.Core.Contracts
{
    public interface IOfferModel
    {
        public string ProductName { get; set; }
        public string LoadingCountry { get; set; }
        public string LoadingAddress { get; set; }

        public string? ActionType { get; set; }

    }
}
