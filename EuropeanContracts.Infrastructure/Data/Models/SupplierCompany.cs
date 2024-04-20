using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EuropeanContracts.Infrastructure.Data.Models
{
    [Comment("Supplier company of product")]
    [Index(nameof(Name),nameof(Country),IsUnique = true)]
    public class SupplierCompany
    {
        [Key]
        [Comment("Supplier company identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Supplier company identifier")]
        [MaxLength(DataValidationConstance.SupplierNameMaxLength)]
        public string Name { get; set; }= string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.SupplierCountryMaxLength)]
        [Comment("Supplier company country")]
        public string Country { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.SupplierAddressMaxLength)]
        [Comment("Supplier company address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.SupplierPhoneNumberMaxLength)]
        [Comment("Supplier company phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string OwnerId { get; set; } = string.Empty!;
        [ForeignKey(nameof(OwnerId))]
        public EuropeanContractUser Owner { get; set; } = null!;

        public IList<Offer> Offers { get; set; } = new List<Offer>();
    }
}