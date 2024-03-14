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
        public string PoductName { get; set; } = string.Empty;

        [MaxLength(DataValidationConstance.OfferProductDescriptionMaxLength)]
        [Comment("Product additional description")]
        public string? ProductDescription { get; set; }

        [Required]
        [Comment("Product quantity")]
        [MaxLength(DataValidationConstance.OfferProductQuantityMaxValue)]
        public int ProductQuantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        [Comment("Product price")]
        public decimal ProductPrice { get; set; }

        [Required]
        [Comment("Product picture URL")]
        public string ProductImageURL { get; set; } = string.Empty;

        [Required]
        [Comment("Product temperature requirement")]
        public bool IsTemperatureControlNeeded { get; set; }
        [Comment("Is the contract concluded")]
        public bool IsContract 
            => TransporterId != null && RecipientId != null ? true : false;

        [Comment("Is the product is delivered")]
        public bool IsDelivered { get; set; }

        [Required]
        [Comment("Publication day")]
        public DateTime PublicationDay { get; set; }

        [Required]
        [Comment("Action type identifier")]
        public int ActionTypeId { get; set; }
        [ForeignKey(nameof(ActionTypeId))]
        public ActionType ActionType { get; set; } = null!;

        [Required]
        public int SupplierId { get; set; }
        [ForeignKey(nameof(SupplierId))]
        public SupplierCompany Supplier { get; set; } = null!;

        public int? TransporterId { get; set; }
        [ForeignKey(nameof(TransporterId))]
        public TransportCompany? Transporter { get; set; } 

        public int? RecipientId { get; set; }

        [ForeignKey(nameof(RecipientId))]
        public RecipientCompany? Recipient { get; set; }

    }
}