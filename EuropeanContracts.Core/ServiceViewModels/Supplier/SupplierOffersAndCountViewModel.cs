using EuropeanContracts.Core.ServiceViewModels.Offer;

namespace EuropeanContracts.Core.ServiceViewModels.Supplier
{
    public class SupplierOffersAndCountViewModel
    {
        public int AllOffersCount { get; set; }

        public IEnumerable<OfferDetailViewModel> OfferViewModels { get; set; } = new List<OfferDetailViewModel>();
    }
}

