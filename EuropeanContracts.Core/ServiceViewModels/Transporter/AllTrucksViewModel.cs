using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Transporter
{
    public class AllTrucksViewModel
    {
        public const int TruckCountOnPage = 2;

        public int CurrentPage { get; init; } = 1;

        public int TotalTruckCount { get; set; }

        [Display(Name = "having temperature control ")]
        public string IsTemperatureControlNeeded { get; set; } = string.Empty;

        [Display(Name = "having cargo space ")]
        public string HasCargoSpace { get; set; } = string.Empty;

        public IEnumerable<TruckViewModel> Trucks { get; set; } = new List<TruckViewModel>();

    }
}
