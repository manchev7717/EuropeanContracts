using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Transporter
{
    public class AllTrailersViewModel
    {
        public const int TrailersCountOnPage = 2;

        public int CurrentPage { get; init; } = 1;

        public int TotalTrailersCount { get; set; }

        [Display(Name = "having temperature control ")]
        public string IsTemperatureControlNeeded { get; set; } = string.Empty;

        public IEnumerable<TrailerViewModel> Trailers { get; set; } = new List<TrailerViewModel>();
    }
}
