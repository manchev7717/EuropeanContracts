namespace EuropeanContracts.Core.ServiceViewModels.Offer
{
    public class OffersAndCountViewModel
    {
        public int AllOffersCount { get; set; }

        public IEnumerable<OfferDetailViewModel> OfferViewModels { get; set; } = new List<OfferDetailViewModel>();
    }
}
