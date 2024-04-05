namespace EuropeanContracts.Core.ServiceViewModels.Transporter
{
    public class OffersAndCountTransporterViewModel
    {
        public int AllOffersCount { get; set; }

        public IEnumerable<OfferTranspoerterViewModel> OfferViewModels { get; set; } = new List<OfferTranspoerterViewModel>();
    }
}
