namespace EuropeanContracts.Core.ServiceViewModels.Trailer
{
    public class TrailerIdAndRegistrationViewModel
    {
        public int Id { get; set; }

        public string RegistrationNumber { get; set; } = string.Empty;

        public string HasTemperatureControl { get; set; } = string.Empty;
    }
}
