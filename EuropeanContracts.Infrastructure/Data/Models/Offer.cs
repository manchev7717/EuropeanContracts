using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EuropeanContracts.Infrastructure.Data.Models
{
    [Comment("Offer")]
    public class Offer
    {
        [Key]
        [Comment("Offer identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataValidationConstance.OfferProductNameMaxLength)]
        [Comment("Product name")]
        public string ProductName { get; set; } = string.Empty;

        [MaxLength(DataValidationConstance.OfferProductDescriptionMaxLength)]
        [Comment("Product additional description")]
        public string? ProductDescription { get; set; }

        [Required]
        [Comment("Product quantity in kilograms")]
        [MaxLength(DataValidationConstance.OfferProductQuantityMaxValue)]
        public int ProductQuantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Comment("Product price in EURO")]
        public decimal ProductPrice { get; set; }

        [Required]
        [Comment("Product picture URL")]
        public string ProductImageURL { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.OfferProductLoadingCountryMaxLength)]
        [Comment("Loading Country")]
        public string LoadingCountry { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.OfferProductLoadingAddressMaxLength)]
        [Comment("Loadring address")]
        public string LoadingAddress { get; set; } = string.Empty;

        [MaxLength(DataValidationConstance.OfferProductCountryOfDestinationMaxValue)]
        [Comment("Country of destination")]
        public string? CountryOfDestination { get; set; }

        [MaxLength(DataValidationConstance.OfferProductAddressOfDestinationMaxValue)]
        [Comment("Address of destination")]
        public string? AddressOfDestination { get; set;}

        [Required]
        [Comment("Product temperature requirement")]
        public bool IsTemperatureControlNeeded { get; set; }
        [Comment("Is the contract concluded")]
        public bool IsContract { get; set; }

        [Comment("Is the product is delivered")]
        public bool IsDelivered { get; set; }

        [Comment("Time of delivery")]
        public DateTime? DeliveryTime { get; set; }

        [Required]
        [Comment("Publication day")]
        public DateTime PublicationDay { get; set; }

        [Required]
        [Comment("Action type identifier")]
        public int ActionTypeId { get; set; }

        [ForeignKey(nameof(ActionTypeId))]
        public ActionType ActionType { get; set; } = null!;

        [Required]
        [Comment("Supplier identifier")]
        public int SupplierId { get; set; } 
        [ForeignKey(nameof(SupplierId))]
        public SupplierCompany Supplier { get; set; } = null!;

        [Comment("Transport company identifier")]
        public int? TransporterId { get; set; }
        [ForeignKey(nameof(TransporterId))]
        public TransportCompany? Transporter { get; set; }

        [Comment("Offer Truck")]
        public int? TruckId { get; set; }

        [ForeignKey(nameof(TruckId))]
        public AutoTruck? Truck { get; set; }

        [Comment("Offer Trailer")]

        public int? TrailerId { get; set; }

        [ForeignKey(nameof(TrailerId))]

        public Trailer? Trailer { get; set; }

        [Comment("Recipient identifier")]
        public int? RecipientId { get; set; }

        [ForeignKey(nameof(RecipientId))]
        public RecipientCompany? Recipient { get; set; }

    }
}