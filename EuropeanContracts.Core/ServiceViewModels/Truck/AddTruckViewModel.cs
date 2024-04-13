using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Infrastructure.Data.Constance;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Truck
{
    public class AddTruckViewModel
    {
        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name ="Truck make")]
        [StringLength(DataValidationConstance.TruckMakeMaxLength,
            MinimumLength =DataValidationConstance.TruckMakeMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string Make { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name ="Truck model")]
        [StringLength(DataValidationConstance.TruckModelMaxLength,
            MinimumLength =DataValidationConstance.TruckModelMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Range(DataValidationConstance.TruckHorsePowerMinValue,
            DataValidationConstance.TruckHorsePowerMaxValue,
            ErrorMessage = ModelsErrorMessages.RangeError)]
        [Display(Name = "Truck horse power")]
        public int HorsePower { get; set; }

        [Display(Name = "Track image URL")]
        public string? TruckImageURL { get; set; }

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name = "Having cargo space")]
        public bool HasCargoSpace { get; set; }

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name = "Having temperature control")]
        public bool HasTemperatureControl { get; set; }

        [Required(ErrorMessage = ModelsErrorMessages.RequiredError)]
        [Display(Name = "Registration number")]
        [RegularExpression(ModelsErrorMessages.RegexVehiclePattern,
            ErrorMessage = ModelsErrorMessages.RegexVehicleNumberError)]
        [StringLength(DataValidationConstance.TruckRegistrationMaxLength,
            MinimumLength = DataValidationConstance.TruckRegistrationMinLength,
            ErrorMessage = ModelsErrorMessages.StringLengthtError)]
        public string RegistrationNumber { get; set; } = string.Empty;

        
        [Display(Name = "Owner identifier")]
        public int TransportCompanyId { get; set; }
    }
}
