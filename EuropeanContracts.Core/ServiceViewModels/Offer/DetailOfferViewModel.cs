using System.ComponentModel.DataAnnotations;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Recipient;
using EuropeanContracts.Core.ServiceViewModels.Transporter;

namespace EuropeanContracts.Core.ServiceViewModels.Offer
{
    public class DetailOfferViewModel 
    {

        [Display(Name = "Product additional description")]
        public string? ProductDescription { get; set; }


        public TransporterDetailViewModel TransporterDetail { get; set; } = new TransporterDetailViewModel();

        public RecipientDetailViewModel RecipientDetail { get; set; } = new RecipientDetailViewModel();

        public OfferDetailViewModel OfferViewModel { get; set; } = new OfferDetailViewModel();

    }
}
