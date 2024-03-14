using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EuropeanContracts.Infrastructure.Data.Models
{
    [Comment("Trailer")]
    public class Trailer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataValidationConstance.TrailerMakeMaxLength)]
        [Comment("Trailer make")]
        public string Make { get; set; } = string.Empty;

        [Required]
        [Comment("Is there temperature control")]
        public bool HasTemperatureControl { get; set; }

        public int OwnerId { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public TransportCompany Owner { get; set; } = null!;
    }
}