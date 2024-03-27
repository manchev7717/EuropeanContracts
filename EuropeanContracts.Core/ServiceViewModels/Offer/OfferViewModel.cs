using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Offer
{
    public class OfferViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(DataValidationConstance.OfferProductNameMaxLength)]
        [Display(Name = "Product name")]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Product quantity in kilograms")]
        [MaxLength(DataValidationConstance.OfferProductQuantityMaxValue)]
        public int ProductQuantity { get; set; }

        [Required]
        [Display(Name = "Product price in EURO")]
        public decimal ProductPrice { get; set; }

        [Required]
        public string ProductImageURL { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.OfferProductLoadingCountryMaxLength)]
        [Display(Name = "Loading Country")]
        public string LoadingCountry { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.OfferProductLoadingAddressMaxLength)]
        [Display(Name = "Loadring address")]
        public string LoadingAddress { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Product temperature requirement")]
        public bool IsTemperatureControlNeeded { get; set; }

        [Required]
        [Display(Name = "Publication day")]
        public DateTime PublicationDay { get; set; }


        [Display(Name = "Action type identifier")]
        public string? ActionType { get; set; }

        [Required]
        [Comment("Supplier identifier")]
        public int SupplierId { get; set; }

    }
}