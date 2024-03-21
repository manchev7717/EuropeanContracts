namespace EuropeanContracts.Core.Models
{
    public class OffersAndCountViewModel
    {
        public int AllOffersCount { get; set; }

        public IEnumerable<OfferViewModel> OfferViewModels { get; set; }= new List<OfferViewModel>();
    }
}
