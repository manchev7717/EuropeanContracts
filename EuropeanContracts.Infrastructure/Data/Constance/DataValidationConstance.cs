namespace EuropeanContracts.Infrastructure.Data.Constance
{
    public static class DataValidationConstance
    {
        public const string DateTimeFormat = "dd MMMM yyyy HH:mm:ss";

        public const int ActionTypeNameMinLength = 4;
        public const int ActionTypeNameMaxLength = 50;
        public const int ActionTypeDescriptionMaxLength = 200;

        public const int OfferProductNameMinLength = 2;
        public const int OfferProductNameMaxLength = 50;
        public const int OfferProductDescriptionMaxLength = 200;
        public const int OfferProductQuantityMinValue = 1;
        public const int OfferProductQuantityMaxValue = int.MaxValue;
        public const decimal OfferProductPriceMinValue = 1.00m;
        public const decimal OfferProductPriceMaxValue = decimal.MaxValue;
        public const int OfferProductLoadingAddressMinValue = 2;
        public const int OfferProductLoadingAddressMaxLength = 200;
        //public const int OfferProductLoadingCountryMinValue = 2;
        public const int OfferProductLoadingCountryMaxLength = 50;
        public const int OfferProductAddressOfDestinationMinValue = 2;
        public const int OfferProductAddressOfDestinationMaxValue = 200;
       // public const int OfferProductCountryOfDestinationMinValue = 2;
        public const int OfferProductCountryOfDestinationMaxValue = 50;

        public const int SupplierNameMinLength = 3;
        public const int SupplierNameMaxLength = 50;
        //public const int SupplierCountryMinLength = 3;
        public const int SupplierCountryMaxLength = 50;
        public const int SupplierAddressMinLength = 7;
        public const int SupplierAddressMaxLength = 50;
        public const int SupplierPhoneNumberMinLength = 5;
        public const int SupplierPhoneNumberMaxLength = 50;

        public const int TransporterNameMinLength = 3;
        public const int TransporterNameMaxLength = 50;
        //public const int TransporterCountryMinLength = 3;
        public const int TransporterCountryMaxLength = 50;
        public const int TransporterAddressMinLength = 7;
        public const int TransporterAddressMaxLength = 200;
        public const int TransporterPhoneNumberMinLength = 5;
        public const int TransporterPhoneNumberMaxLength = 50;

        public const int TruckMakeMinLength = 3;
        public const int TruckMakeMaxLength = 20;
        public const int TruckModelMinLength = 3;
        public const int TruckModelMaxLength = 20;
        public const int TruckHorsePowerMinValue = 1;
        public const int TruckHorsePowerMaxValue = 10000;
        public const int TruckRegistrationMaxLength = 1;
        public const int TruckRegistrationMinLength = 30;

        public const int TrailerMakeMinLength = 3;
        public const int TrailerMakeMaxLength = 20;
        public const int TrailerRegistrationMaxLength = 1;
        public const int TrailerRegistrationMinLength = 30;

        public const int RecipientNameMinLength = 3;
        public const int RecipientNameMaxLength = 200;
        //public const int RecipientCountryMinLength = 3;
        public const int RecipientCountryMaxLength = 50;
        public const int RecipientAddressMinLength = 7;
        public const int RecipientAddressMaxLength = 200;
        public const int RecipientPhoneNumberMinLength = 5;
        public const int RecipientPhoneNumberMaxLength = 50;

    }
}
