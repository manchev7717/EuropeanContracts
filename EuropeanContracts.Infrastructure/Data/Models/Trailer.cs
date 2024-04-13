using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EuropeanContracts.Infrastructure.Data.Models
{
    [Comment("Trailer")]
    [Index(nameof(RegistrationNumber), IsUnique = true)]
    public class Trailer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataValidationConstance.TrailerMakeMaxLength)]
        [Comment("Trailer make")]
        public string Make { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.TrailerRegistrationMaxLength)]
        [Comment("Trailer registration number")]
        public string RegistrationNumber { get; set; } = string.Empty;

        [Comment("Trailer image URL")]
        public string? TrailerImageURL { get; set; }

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