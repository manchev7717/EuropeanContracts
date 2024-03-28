using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Infrastructure.Data.Constance;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Transporter
{
    public class AddTransportCompanyModel
    {
        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.TransporterNameMaxLength,
            MinimumLength = DataValidationConstance.TransporterNameMinLength
            ,ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.TransporterAddressMaxLength,
            MinimumLength = DataValidationConstance.TransporterAddressMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.TransporterPhoneNumberMaxLength,
            MinimumLength = DataValidationConstance.TransporterPhoneNumberMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        [Display(Name = "Phone number")]
        [RegularExpression(ModelsErrorMessages.RegexPhonePattern, ErrorMessage = ModelsErrorMessages.RegexError)]
        public string PhoneNumber { get; set; } = string.Empty;

        public string OwnerId { get; set; } = string.Empty;
    }
}
