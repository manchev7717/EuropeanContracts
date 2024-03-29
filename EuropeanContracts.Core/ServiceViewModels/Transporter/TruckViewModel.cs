using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Transporter
{
    public class TruckViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Truck make")]
        public string Make { get; set; } = string.Empty;

        [Comment("Truck model")]
        public string Model { get; set; } = string.Empty;

        [Display(Name = "Truck horse power")]
        public int HorsePower { get; set; }

        [Display(Name = "Track image URL")]
        public string? TruckImageURL { get; set; }
        
        [Display(Name = "Is there in truck cargo space")]
        public bool HasCargoSpace { get; set; }

        [Display(Name = "Is there temperature control")]
        public bool HasTemperatureControl { get; set; }

        [Display(Name = "Owner identifier")]
        public int TransportCompanyId { get; set; }
    }
}