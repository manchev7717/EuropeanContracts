using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EuropeanContracts.Infrastructure.Data.Models
{
    [Comment("Track")]
    [Index(nameof(RegistrationNumber), IsUnique = true)]
    public class AutoTruck
    {
        [Key]
        [Comment("Truck identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Truck make")]
        [MaxLength(DataValidationConstance.TruckMakeMaxLength)]
        public string Make { get; set; } = string.Empty;

        [Required]
        [Comment("Truck model")]
        [MaxLength(DataValidationConstance.TruckModelMaxLength)]
        public string Model { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.TruckRegistrationMaxLength)]
        [Comment("Truck registration number")]
        public string RegistrationNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.TruckHorsePowerMaxValue)]
        [Comment("Truck horse power")]
        public int HorsePower { get; set; }

        [Comment("Track image URL")]
        public string? TruckImageURL { get; set; }

        [Required]
        [Comment("Is there in truck cargo space")]
        public bool HasCargoSpace { get; set; }

        [Required]
        [Comment("Is there temperature control")]
        public bool HasTemperatureControl { get; set; }

        [Required]
        [Comment("Owner identifier")]
        public int TransportCompanyId { get; set; }
        [ForeignKey(nameof(TransportCompanyId))]
        public TransportCompany TransportCompany { get; set; } = null!;
    }
}