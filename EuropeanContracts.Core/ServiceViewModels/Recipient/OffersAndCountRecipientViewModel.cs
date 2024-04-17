namespace EuropeanContracts.Core.ServiceViewModels.Recipient
{
    public class OffersAndCountRecipientViewModel
    {
        public int AllOffersCount { get; set; }

        public IEnumerable<OfferRecipientViewModel> OfferViewModels { get; set; } = new List<OfferRecipientViewModel>();
    }
}
