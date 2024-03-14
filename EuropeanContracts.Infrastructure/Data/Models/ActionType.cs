using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Infrastructure.Data.Models
{
    [Comment("Тhe action we can do with the product")]
    public class ActionType
    {
        [Comment("Action identifier")]
        public int Id { get; set; }

        [Comment("Name of action")]
        [Required]
        [MaxLength(DataValidationConstance.ActionTypeNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Comment("Action type additional description")]
        [MaxLength(DataValidationConstance.ActionTypeDescriptionMaxLength)]
        public string? Description { get; set; }

        public IList<Offer> Products { get; set; } = new List<Offer>();
    }
}