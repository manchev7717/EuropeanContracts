using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Trailer
{
    public class EditAndDeleteTrailerViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [StringLength(DataValidationConstance.TrailerMakeMaxLength,
            MinimumLength = DataValidationConstance.TrailerMakeMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        [Display(Name = "Trailer make")]
        public string Make { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name = "Registration number")]
        [RegularExpression(ModelsErrorMessages.RegexVehiclePattern, ErrorMessage = ModelsErrorMessages.RegexVehicleNumberError)]
        [StringLength(DataValidationConstance.TrailerRegistrationMaxLength,
            MinimumLength = DataValidationConstance.TrailerRegistrationMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string RegistrationNumber { get; set; } = string.Empty;

        [Display(Name = "Trailer image URL")]
        public string? TrailerImageURL { get; set; }

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name = "Having temperature control")]
        public bool HasTemperatureControl { get; set; }

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Comment("Owner identifier")]
        public int TransportCompanyId { get; set; }
    }
}
