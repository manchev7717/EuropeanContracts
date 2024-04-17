using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Transporter
{
    public class TrailerViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Trailer name")]
        public string Make { get; set; } = string.Empty;

        [Display(Name = "Trailer image URL")]
        public string? TrailerImageURL { get; set; }

        [Display(Name ="Having temperature control")]
        public bool HasTemperatureControl { get; set; }
        [Display(Name = "Registration Number")]
        public string RegistrationNumber { get; set; } = null!;

        [Required]
        [Comment("Owner identifier")]
        public int TransportCompanyId { get; set; }
    }
}