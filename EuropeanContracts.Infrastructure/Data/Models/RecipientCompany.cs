using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EuropeanContracts.Infrastructure.Data.Models
{
    [Comment("Recipient company")]
    [Index(nameof(Name), nameof(Country), IsUnique = true)]
    public class RecipientCompany
    {
        [Key]
        [Comment("Recipient company identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Recipient company identifier")]
        [MaxLength(DataValidationConstance.RecipientNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.RecipientCountryMaxLength)]
        [Comment("Recipient company country")]
        public string Country { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.RecipientAddressMaxLength)]
        [Comment("Recipient company address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.RecipientPhoneNumberMaxLength)]
        [Comment("Recipient company phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string OwnerId { get; set; } = string.Empty;
        [ForeignKey(nameof(OwnerId))]
        public EuropeanContractUser Owner { get; set; } = null!;

        public IList<Offer> Offers { get; set; } = new List<Offer>();
    }
}
