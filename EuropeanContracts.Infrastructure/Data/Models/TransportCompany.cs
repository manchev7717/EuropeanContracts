using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EuropeanContracts.Infrastructure.Data.Models
{
    [Comment("Transport company of goods")]
    [Index(nameof(Name), nameof(Country), IsUnique = true)]
    public class TransportCompany
    {
        [Key]
        [Comment("Transport company identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataValidationConstance.TransporterNameMaxLength)]
        [Comment("Transport company name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.TransporterCountryMaxLength)]
        [Comment("Transport company country")]
        public string Country { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.TransporterAddressMaxLength)]
        [Comment("Transport company address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.TransporterPhoneNumberMaxLength)]
        [Comment("Transport company phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("Owner identifier")]
        public string OwnerId { get; set; } = string.Empty;
        [ForeignKey(nameof(OwnerId))]
        public EuropeanContractUser Owner { get; set; } = null!;

        public IList<Offer> Offers { get; set; } = new List<Offer>();
        public IList<AutoTruck> Trucks { get; set; } = new List<AutoTruck>();
        public IList<Trailer> Trailers { get; set; } = new List<Trailer>();

    }
}
