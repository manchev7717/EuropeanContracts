using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Infrastructure.Data.DataSeeding
{
    internal class DataSeed
    {
        private ActionType SellActionType { get; set; } = null!;
        private ActionType RentActionType { get; set; } = null!;
        private Offer Offer { get; set; } = null!;
        private Offer FirstOffer { get; set; } = null!;
        private Offer SecondOffer { get; set; } = null!;
        private Offer ThirdOffer { get; set; } = null!;
        private SupplierCompany FirstSupplierCompany{ get; set; } = null!;
        private SupplierCompany SecondSupplierCompany{ get; set; } = null!;
        private SupplierCompany ThirdSupplierCompany{ get; set; } = null!;
        private RecipientCompany FirstRecipientCompany { get; set; } = null!;
        private RecipientCompany SecondRecipientCompany { get; set; } = null!;
        private RecipientCompany ThirdRecipientCompany { get; set; } = null!;
        private Trailer FirstTrailer { get; set; } = null!;
        private Trailer SecondTrailer { get; set; } = null!;
        private Trailer ThirdTrailer { get; set; } = null!;
        private Truck FristTruck { get; set; } = null!;
        private Truck SecondTruck { get; set; } = null!;
        private Truck ThirdTruck { get; set; } = null!;
        private TransportCompany FirstTransportCompany { get; set; } = null!;
        private TransportCompany SecondTransportCompany { get; set; } = null!;


    }
}
