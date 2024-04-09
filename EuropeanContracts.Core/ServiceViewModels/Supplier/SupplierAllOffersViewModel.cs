using EuropeanContracts.Core.ServiceViewModels.Offer;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Supplier
{
    public class SupplierAllOffersViewModel
    {
        public const int OffersCountOnPage = 2;

        public int CurrentPage { get; init; } = 1;

        public int TotalOffersCount { get; set; }

        public string IsContract { get; set; } = string.Empty;
        public IEnumerable<SupplierOfferViewModel> Offers { get; set; } = new List<SupplierOfferViewModel>();
    }
}
