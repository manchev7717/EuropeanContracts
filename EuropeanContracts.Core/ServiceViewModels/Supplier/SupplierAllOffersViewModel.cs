using EuropeanContracts.Core.ServiceViewModels.Offer;

namespace EuropeanContracts.Core.ServiceViewModels.Supplier
{
    public class SupplierAllOffersViewModel
    {
        public const int OffersCountOnPage = 2;

        public int CurrentPage { get; init; } = 1;

        public int TotalOffersCount { get; set; }

        public string IsContract { get; set; } = string.Empty;
        public IEnumerable<OfferDetailViewModel> Offers { get; set; } = new List<OfferDetailViewModel>();
    }
}
