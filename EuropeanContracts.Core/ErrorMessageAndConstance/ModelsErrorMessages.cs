namespace EuropeanContracts.Core.ErrorMessageAndConstance
{
    public static class ModelsErrorMessages
    {
        public const string RequiredError = "The field {0} is required";
        public const string StringLengthtError = "The field {0} must be between {2} and {1} characters long";

        public const string CompanyExistsError = "In this country company with this name already exists";

        public const string RegexPhonePattern = @"\+[0-9]+";
        public const string RegexError = "Phone number must start with \"+\" and contains only digits";

        public const string RangeError = "The field {0} must be positive number between {1} and {2}";

        public const string ExistVehicleError = "A vehicle with this URL already exists";

        public const string RegexVehiclePattern = @"^[A-Z0-9]+$";
        public const string RegexVehicleNumberError = "The field must contain only digits and upper case letters";

        public const string TruckHasNoTemperatureControl =
            "The selected truck has no temperature control, select another or add trailer";

        public const string TrailerHasNoTemperatureControl =
            "The selected trailer has no temperature control, select another one";
    }
}
