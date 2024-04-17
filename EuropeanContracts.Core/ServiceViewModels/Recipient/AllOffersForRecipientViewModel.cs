using EuropeanContracts.Core.ServiceViewModels.Transporter;

namespace EuropeanContracts.Core.ServiceViewModels.Recipient
{
    public  class AllOffersForRecipientViewModel
    {
        public const int OffersCountOnPage = 2;

        public int CurrentPage { get; init; } = 1;

        public int TotalOffersCount { get; set; }

        public string IsContract { get; set; } = string.Empty;

        public IEnumerable<OfferRecipientViewModel> Offers { get; set; } = new List<OfferRecipientViewModel>();
    }
}
