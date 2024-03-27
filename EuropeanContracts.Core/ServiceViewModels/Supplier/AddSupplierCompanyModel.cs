using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Infrastructure.Data.Constance;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.SupplierCompany
{
    public class AddSupplierCompanyModel
    {
        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.SupplierNameMaxLength,
            MinimumLength = DataValidationConstance.SupplierNameMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.SupplierCountryMaxLength,
            MinimumLength = DataValidationConstance.SupplierCountryMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.SupplierAddressMaxLength,
            MinimumLength = DataValidationConstance.SupplierAddressMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.SupplierPhoneNumberMaxLength,
            MinimumLength = DataValidationConstance.SupplierPhoneNumberMinLength,
            ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name = "Owner Identifier")]
        public string OwnerId { get; set; } = string.Empty!;

    }
}
