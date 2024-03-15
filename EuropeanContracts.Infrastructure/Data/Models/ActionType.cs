using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Infrastructure.Data.Models
{
    [Comment("Тhe action we can do with the product")]
    public class ActionType
    {
        [Key]
        [Comment("Action identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataValidationConstance.ActionTypeNameMaxLength)]
        [Comment("Name of action")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(DataValidationConstance.ActionTypeDescriptionMaxLength)]
        [Comment("Action type additional description")]
        public string? Description { get; set; }

        public IList<Offer> Offer { get; set; } = new List<Offer>();
    }
}