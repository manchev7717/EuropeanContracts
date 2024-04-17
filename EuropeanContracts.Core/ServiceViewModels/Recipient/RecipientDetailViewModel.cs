using EuropeanContracts.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Recipient
{
    public class RecipientDetailViewModel
    {
        public int? RecipientId { get; set; }

        [Display(Name = "Recipient Name")]
        public string? RecipientName { get; set; } 
        [Display(Name = "Recipient Country")]
        public string? RecipientCountry { get; set; } 

        [Display(Name = "Recipient Phone number")]
        public string? RecipientPhoneNumber { get; set; } 

        [Display(Name = "Country of destination")]
        public string? CountryOfDestination { get; set; }

        [Display(Name = "Address of destination")]
        public string? AddressOfDestination { get; set; }
    }
}
