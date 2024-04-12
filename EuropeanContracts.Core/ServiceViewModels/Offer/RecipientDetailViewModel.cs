using EuropeanContracts.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Offer
{
    public class RecipientDetailViewModel
    {
        [Display(Name = "Country of destination")]
        public string? CountryOfDestination { get; set; }

        [Display(Name = "Address of destination")]
        public string? AddressOfDestination { get; set; }

        [Display(Name = "Is the product is delivered")]
        public bool IsDelivered { get; set; }

        [Display(Name = "Time of delivery")]
        public DateTime? DeliveryTime { get; set; }

        [Display(Name = "Recipient identifier")]
        public int? RecipientId { get; set; }

        public RecipientCompany? Recipient { get; set; }
    }
}
