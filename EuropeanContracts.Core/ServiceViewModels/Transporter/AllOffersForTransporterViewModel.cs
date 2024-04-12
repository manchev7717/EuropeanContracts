namespace EuropeanContracts.Core.ServiceViewModels.Transporter
{
    public class AllOffersForTransporterViewModel
    {
        public const int OffersCountOnPage = 2;

        public int CurrentPage { get; init; } = 1;

        public int TotalOffersCount { get; set; }

        public string IsContract { get; set; } = string.Empty;

        public IEnumerable<OfferTranspoerterViewModel> Offers { get; set; } = new List<OfferTranspoerterViewModel>();
    }
}
