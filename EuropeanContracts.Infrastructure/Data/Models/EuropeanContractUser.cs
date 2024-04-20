using EuropeanContracts.Infrastructure.Data.Constance;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Infrastructure.Data.Models
{
    public class EuropeanContractUser : IdentityUser
    {
        [Required]
        [MaxLength(DataValidationConstance.EuropeanContractUserFirstNameMaxLenght)]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataValidationConstance.EuropeanContractUserLastNameMaxLenght)]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;
    }
}
