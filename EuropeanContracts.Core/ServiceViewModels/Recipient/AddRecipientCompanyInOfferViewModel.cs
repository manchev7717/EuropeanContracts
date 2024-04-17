using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Infrastructure.Data.Constance;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Recipient
{
    public class AddRecipientCompanyInOfferViewModel
    {
        public int OfferId { get; set; }
        public int RecipientId { get; set; }

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.OfferProductAddressOfDestinationMaxValue,
            MinimumLength = DataValidationConstance.OfferProductAddressOfDestinationMinValue,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]

        [Display(Name = "Address of destination")]
        public string AddressOfDestination { get; set; } = string.Empty;
        [Display(Name = "Country of destination")]
        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        public string CountryOfDestination { get; set; } = string.Empty;
    }
}
