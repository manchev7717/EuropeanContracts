using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Core.ServiceViewModels.Trailer;
using EuropeanContracts.Core.ServiceViewModels.Truck;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Recipient
{
    public class AddRecipientCompanyInOfferViewModel
    {
        public int OfferId { get; set; }
        public int RecipientId { get; set; }

        

        public IEnumerable<TruckIdAndRegistrationViewModel> Trucks { get; set; } = new List<TruckIdAndRegistrationViewModel>();
        public IEnumerable<TrailerIdAndRegistrationViewModel> Trailers { get; set; } = new List<TrailerIdAndRegistrationViewModel>();
    }
}
