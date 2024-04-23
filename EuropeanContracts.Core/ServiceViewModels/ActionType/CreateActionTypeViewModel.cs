using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Infrastructure.Data.Constance;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.ActionType
{
    public class CreateActionTypeViewModel
    {

        [Required]
        [StringLength(DataValidationConstance.ActionTypeNameMaxLength,
            MinimumLength = DataValidationConstance.ActionTypeNameMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        [Display( Name ="Name of action")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(DataValidationConstance.ActionTypeDescriptionMaxLength
            ,ErrorMessage = ModelsErrorMessages.ActionDescriptionLengthtError)]
        [Display(Name = "Action type additional description")]
        public string? Description { get; set; }
    }
}
