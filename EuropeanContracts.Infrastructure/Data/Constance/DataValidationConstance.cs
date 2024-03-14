namespace EuropeanContracts.Infrastructure.Data.Constance
{
    public static class DataValidationConstance
    {
        public const int ActionTypeNameMinLength = 4;
        public const int ActionTypeNameMaxLength = 12;
        public const int ActionTypeDescriptionMaxLength = 50;

        public const int OfferProductNameMinLength = 2;
        public const int OfferProductNameMaxLength = 20;
        public const int OfferProductDescriptionMaxLength = 20;
        public const int OfferProductQuantityMinValue = 0;
        public const int OfferProductQuantityMaxValue = int.MaxValue;
        public const decimal OfferProductPriceMinValue = 0.00m;
        public const decimal OfferProductPriceMaxValue = decimal.MaxValue;
        public const int OfferProductLoadingAddressMinValue = 2;
        public const int OfferProductLoadingAddressMaxLength = 50;
        public const int OfferProductLoadingCountryMinValue = 2;
        public const int OfferProductLoadingCountryMaxLength = 50;

        public const int SupplierNameMinLength = 1;
        public const int SupplierNameMaxLength = 50;
        public const int SupplierCountryMinLength = 1;
        public const int SupplierCountryMaxLength = 50;
        public const int SupplierAddressMinLength = 7;
        public const int SupplierAddressMaxLength = 50;
        public const int SupplierPhoneNumberMinLength = 5;
        public const int SupplierPhoneNumberMaxLength = 30;

        public const int TransporterNameMinLength = 1;
        public const int TransporterNameMaxLength = 50;
        public const int TransporterCountryMinLength = 1;
        public const int TransporterCountryMaxLength = 50;
        public const int TransporterAddressMinLength = 7;
        public const int TransporterAddressMaxLength = 50;
        public const int TransporterPhoneNumberMinLength = 5;
        public const int TransporterPhoneNumberMaxLength = 30;

        public const int TruckMakeMinLength = 1;
        public const int TruckMakeMaxLength = 20;
        public const int TruckModelMinLength = 1;
        public const int TruckModelMaxLength = 20;
        public const int TruckHorsePowerMinValue = 1;
        public const int TruckHorsePowerMaxValue = 10000;

        public const int TrailerMakeMinLength = 1;
        public const int TrailerMakeMaxLength = 20;

        public const int RecipientNameMinLength = 1;
        public const int RecipientNameMaxLength = 50;
        public const int RecipientCountryMinLength = 1;
        public const int RecipientCountryMaxLength = 50;
        public const int RecipientAddressMinLength = 7;
        public const int RecipientAddressMaxLength = 50;
        public const int RecipientPhoneNumberMinLength = 5;
        public const int RecipientPhoneNumberMaxLength = 30;

    }
}
