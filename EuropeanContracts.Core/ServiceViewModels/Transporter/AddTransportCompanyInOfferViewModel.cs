using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Core.ServiceViewModels.Trailer;
using EuropeanContracts.Core.ServiceViewModels.Truck;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Transporter
{

    public class AddTransportCompanyInOfferViewModel
    {
        public int OfferId { get; set; }    
        public int TransporterId { get; set; }

        [Display(Name = "Choose truck number")]
        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        public int TruckId { get; set; }

        [Display(Name = "Choose trailer number")]
        public int? TrailerId { get; set; }
        public bool IsTemperatureRequired { get; set; }

        public IEnumerable<TruckIdAndRegistrationViewModel> Trucks { get; set; } = new List<TruckIdAndRegistrationViewModel>();
        public IEnumerable<TrailerIdAndRegistrationViewModel> Trailers { get; set; } = new List<TrailerIdAndRegistrationViewModel>();
    }
}
