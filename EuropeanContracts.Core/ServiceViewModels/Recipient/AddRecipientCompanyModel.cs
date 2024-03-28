using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Infrastructure.Data.Constance;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Recipient
{
    public class AddRecipientCompanyModel
    {
        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.RecipientNameMaxLength,
            MinimumLength = DataValidationConstance.RecipientNameMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.RecipientAddressMaxLength,
            MinimumLength = DataValidationConstance.RecipientAddressMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.RecipientPhoneNumberMaxLength,
            MinimumLength =DataValidationConstance.RecipientPhoneNumberMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        [Display(Name ="Phone number")]
        [RegularExpression(ModelsErrorMessages.RegexPhonePattern, ErrorMessage = ModelsErrorMessages.RegexError)]
        public string PhoneNumber { get; set; } = string.Empty;

        public string OwnerId { get; set; } = string.Empty;
    }
}
