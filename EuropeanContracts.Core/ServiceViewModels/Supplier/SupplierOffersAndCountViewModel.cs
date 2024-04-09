namespace EuropeanContracts.Core.ServiceViewModels.Supplier
{
    public class SupplierOffersAndCountViewModel
    {
        public int AllOffersCount { get; set; }

        public IEnumerable<SupplierOfferViewModel> OfferViewModels { get; set; } = new List<SupplierOfferViewModel>();
    }
}

