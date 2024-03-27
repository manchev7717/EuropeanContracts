namespace EuropeanContracts.Core.ServiceViewModels.Offer
{
    public class OffersAndCountViewModel
    {
        public int AllOffersCount { get; set; }

        public IEnumerable<OfferViewModel> OfferViewModels { get; set; } = new List<OfferViewModel>();
    }
}
