using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EuropeanContracts.Infrastructure.Data.Models
{
    [Comment("Track")]
    public class Truck
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
        [MaxLength(DataValidationConstance.TruckHorsePowerMaxValue)]
        [Comment("Truck horse power")]
        public int HorsePower { get; set; }

        [Required]
        [Comment("Is there in truck cargo space")]
        public bool HasCargoSpace { get; set; }

        public int OwnerId { get; set; }
        [ForeignKey(nameof(OwnerId))]
        public TransportCompany Owner { get; set; } = null!;



    }
}