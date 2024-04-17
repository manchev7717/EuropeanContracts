namespace EuropeanContracts.Core.ServiceViewModels.Truck
{
    public class TruckIdAndRegistrationViewModel
    {
        public int Id { get; set; }

        public string RegistrationNumber { get; set; } = string.Empty;

        public string HasTemperatureControl {  get; set; } = string.Empty;
    }
}
