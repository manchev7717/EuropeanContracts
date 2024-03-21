using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.Models
{
    public class AllOfferViewModel
    {

        public const int OffersCountOnPage = 3;

        public int CurrentPage { get; init; } = 1;

        public int TotalOffersCount { get; set; }

        [Display(Name = "For")]
        public IEnumerable<string?> Actions { get; set; } = new List<string>();

        public string? ActionType { get; set; } = null;

        [Display(Name = "From Country")]
        public IEnumerable<string> CountriesOfOrigin { get; set; } = new List<String>();

        public string? Country { get; set; } = null;

        [Display(Name = "Is temperature control required")]
        public string? IsTemperatureControlNeeded { get; set; }

        public IEnumerable<OfferViewModel> offers { get; set; } = new List<OfferViewModel>();
    }
}
