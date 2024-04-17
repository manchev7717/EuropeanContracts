using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Transporter
{
    using EuropeanContracts.Infrastructure.Data.Models;
    public class TransporterDetailViewModel
    {
        [Display(Name = "Transport company identifier")]
        public int? TransporterId { get; set; }

        public string TransporterName { get; set; } = string.Empty; 
        public string TransporterCountry { get; set; } = string.Empty; 
        public string TransporterPhoneNumber{ get; set; } = string.Empty; 

        public string? TruckUrl  { get; set;} = string.Empty;
        public string TruckMake {  get; set; } = string.Empty;
        public string TruckModel {  get; set; } = string.Empty;
        public string TruckRegistration {  get; set; } = string.Empty;

        public string? TrailerUrl { get; set; } = string.Empty;
        public string TrailerMake { get; set; } = string.Empty;
        public string TrailerRegistration { get; set; } = string.Empty;

    }
}
