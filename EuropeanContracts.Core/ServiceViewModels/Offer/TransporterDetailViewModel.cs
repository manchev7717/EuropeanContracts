using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Offer
{
    using EuropeanContracts.Infrastructure.Data.Models;
    public class TransporterDetailViewModel
    {
        [Display(Name = "Transport company identifier")]
        public int? TransporterId { get; set; }

        public TransportCompany? TransportCompany { get; set; }

        public int? TruckId { get; set; }

        public AutoTruck? Truck { get; set; } 

        public int? TrailerId { get; set; }

        public Trailer? Trailer { get; set; }
    }
}
