using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Infrastructure.Data.Constance;
using EuropeanContracts.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Offer
{
    public class CreateOfferViewModel
    {
        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.OfferProductNameMaxLength,
            MinimumLength = DataValidationConstance.OfferProductNameMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        [Display( Name ="Product name")]
        public string ProductName { get; set; } = string.Empty;

        [MaxLength(DataValidationConstance.OfferProductDescriptionMaxLength)]
        [Display( Name ="Product additional description")]
        public string? ProductDescription { get; set; }

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name ="Product quantity in kilograms")]
        [Range(DataValidationConstance.OfferProductQuantityMinValue, DataValidationConstance.OfferProductQuantityMaxValue,
            ErrorMessage = ModelsErrorMessages.RangeError)]
        public int ProductQuantity { get; set; }

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        //[Column(TypeName = "decimal(18, 6)")]
        [Range((double)DataValidationConstance.OfferProductPriceMinValue, (double)DataValidationConstance.OfferProductPriceMaxValue,ErrorMessage = ModelsErrorMessages.RangeError)]
        [Display(Name = "Product price in EURO")]
        public decimal ProductPrice { get; set; }

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name = "Product picture URL")]
        public string ProductImageURL { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.OfferProductLoadingCountryMaxLength)]
        [Display(Name = "Loading Country")]
        public string LoadingCountry { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [MaxLength(DataValidationConstance.OfferProductLoadingAddressMaxLength)]
        [Display(Name = "Loadring address")]
        public string LoadingAddress { get; set; } = string.Empty;

        [MaxLength(DataValidationConstance.OfferProductCountryOfDestinationMaxValue)]
        [Display(Name = "Country of destination")]
        public string? CountryOfDestination { get; set; }

        [MaxLength(DataValidationConstance.OfferProductAddressOfDestinationMaxValue)]
        [Display(Name = "Address of destination")]
        public string? AddressOfDestination { get; set; }

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name = "Product temperature requirement")]
        public bool IsTemperatureControlNeeded { get; set; }

        public DateTime PublicationDay { get; set; } = DateTime.Now;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display( Name ="Action type identifier")]
        public int ActionTypeId { get; set; }
        public IEnumerable<ActionType> ActionTypes { get; set; } = new List<ActionType>();

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name = "Supplier identifier")]
        public int SupplierId { get; set; }
        
    }
}
