using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Infrastructure.Data.Constance;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Supplier
{
    public class AddSupplierCompanyModel
    {
        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.SupplierNameMaxLength,
            MinimumLength = DataValidationConstance.SupplierNameMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string Name { get; set; } = string.Empty;

        
        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.SupplierAddressMaxLength,
            MinimumLength = DataValidationConstance.SupplierAddressMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.SupplierPhoneNumberMaxLength,
            MinimumLength = DataValidationConstance.SupplierPhoneNumberMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        [Display(Name = "Phone Number")]
        [RegularExpression(ModelsErrorMessages.RegexPhonePattern,ErrorMessage = ModelsErrorMessages.RegexError)]
        public string PhoneNumber { get; set; } = string.Empty;

        public string OwnerId { get; set; } = string.Empty!;


    }
}
