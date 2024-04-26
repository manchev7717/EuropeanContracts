using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Tests.ClassHelpers
{
    public static class OfferDataSeedingForTests
    {
        public static IEnumerable<Offer> SeedOffers()
        {
            return new List<Offer>
            {
                 new Offer()
                 {
                      Id = 1,
                      ProductName = "Pork Meat",
                      ProductQuantity = 19840,
                      ProductPrice = 102504,
                      ProductDescription = "Тhe produce is fresh from animals raised on certified farms",
                      ProductImageURL = "/Images/ProductImages/FreshPorkMeat.png",
                      LoadingCountry = "Spain",
                      LoadingAddress = "Badajoz, str. C.Jose.Caldito Ruiz 50",
                      PublicationDay = DateTime.Now,
                      ActionTypeId = 1,
                      SupplierId = 1,
                      IsTemperatureControlNeeded = true,
                      TransporterId = 1,
                      RecipientId = 1,
                      TrailerId = 4,
                      TruckId = 1,
                 },
                 new Offer()
                 {
                     Id = 2,
                     ProductName = "Plastic waste",
                     ProductQuantity = 17800,
                     ProductPrice = 4200,
                     ProductDescription = "Baled and suitable for recycling",
                     ProductImageURL = "/Images/ProductImages/PlasticWaste.png",
                     LoadingCountry = "Italy",
                     LoadingAddress = "Foggia, str. Via Daniele Manin 14",
                     CountryOfDestination = "Bulgaria",
                     AddressOfDestination = "Burgas,Lozovo district, str.Ruzha 1",
                     PublicationDay = DateTime.Now,
                     ActionTypeId = 3,
                     SupplierId = 2,
                     IsTemperatureControlNeeded = false
                 },
                 new Offer()
                 {
                     Id = 3,
                     ProductName = "Scaffolding material",
                     ProductQuantity = 19900,
                     ProductPrice = 3500,
                     ProductDescription = "Manufactured in 2020 with a safety certificate",
                     ProductImageURL = "/Images/ProductImages/ScaffoldingMaterials.png",
                     LoadingCountry = "Austria",
                     LoadingAddress = "Vienna, str. Sindelargasse 17",
                     PublicationDay = DateTime.Now,
                     ActionTypeId = 2,
                     SupplierId = 1,
                     IsTemperatureControlNeeded = false
                 },
                 new Offer()
                 {
                     Id = 4,
                     ProductName = "Chocolate Products",
                     ProductQuantity = 17450,
                     ProductPrice = 36745.55m,
                     ProductDescription = "Оwn production with a high quality certificate",
                     ProductImageURL = "/Images/ProductImages/chocolateProducts.png",
                     LoadingCountry = "Hungary",
                     LoadingAddress = "Debrecen, str. Biczokert 52",
                     PublicationDay = DateTime.Now,
                     ActionTypeId = 1,
                     SupplierId = 1,
                     IsTemperatureControlNeeded = true
                 }
            };
        }
        public static IEnumerable<ActionType> SeedActionTupes()
        {
            return new List<ActionType>()
            {
                new ActionType()
                {
                    Id = 1,
                    Name = "Sale",
                    Description = "The amount is the purchase price of the goods and is in euros"
                },
                new ActionType()
                {
                    Id = 2,
                    Name = "Rent",
                    Description = "Тhe price is for one month of use and is in euros"
                },
                new ActionType()
                {
                    Id = 3,
                    Name = "Transportation",
                    Description = "Тhe price is for transport the cargo to the delivery address and is in euros"
                },
            };
        }
        public static IEnumerable<SupplierCompany> SeedSuppliers()
        {
            return new List<SupplierCompany>()
            {
                new SupplierCompany()
                {
                    Id = 1,
                    Name = "Smart Elinas LTD",
                    Country = "Greece",
                    Address = "Thessaloniki, str. Perdika 10",
                    PhoneNumber = "+0030695422154",
                    OwnerId = "k3fcll56-l458-6871-q3r9-2ve3w9a54s87"
                },
                new SupplierCompany()
                {
                    Id = 2,
                    Name = "MDY Tools",
                    Country = "Austria",
                    Address = "Vienna, str. LowelStrasse 69",
                    PhoneNumber = "+4368782664400",
                    OwnerId = "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo"
                },
                new SupplierCompany()
                {
                    Id = 3,
                    Name = "Stay Fly",
                    Country = "Spain",
                    Address = "Barcelona, str. Carrer Cruspinera 3",
                    PhoneNumber = "+342244501136",
                    OwnerId = "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn"
                }
            };

        }
        public static IEnumerable<TransportCompany> SeedTransporters()
        {
            return new List<TransportCompany>()
            {
                new TransportCompany()
                {
                    Id = 1,
                    Name = "NG TRANS",
                    Country = "Bulgaria",
                    Address = "Varna, str. Popovi livadi 99",
                    PhoneNumber = "+3598897415202",
                    OwnerId = "d33qwej9-02ap-11mnl-hflp-lpszavr2s588"
                },

                new TransportCompany()
                {
                    Id = 2,
                    Name = "VIOREL TRANS GROUP",
                    Country = "Romania",
                    Address = "Kostanza, Strada Spiru Haret 42",
                    PhoneNumber = "+00407775987456.",
                    OwnerId = "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n"
                }
            };
        }
        public static IEnumerable<RecipientCompany> SeedRecipient()
        {
            return new List<RecipientCompany>()
            {
                new RecipientCompany()
                {
                    Id = 1,
                    Name = "Global workers",
                    Country = "Belgium",
                    Address = "Charleroi, str. Rue de Marcinelle 50",
                    PhoneNumber = "+3265689899852",
                    OwnerId = "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo"
                },

                 new RecipientCompany()
                 {
                     Id = 2,
                     Name = "LeDecale Boutique",
                     Country = "France",
                     Address = "Lyon, str. Rue Domer 12",
                     PhoneNumber = "+332566985556140",
                     OwnerId = "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32"
                 },

                 new RecipientCompany()
                 {
                     Id = 3,
                     Name = "SmartSolutions",
                     Country = "Italy",
                     Address = "Florence, str. Via Madonna Della Querce 4",
                     PhoneNumber = "+3900125221287",
                     OwnerId = "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532"
                 }
            };
        }
        public static IEnumerable<AutoTruck> SeedTrucks()
        {
            return new List<AutoTruck>()
            {
               new AutoTruck()
                {
                    Id = 1,
                    Make = "DAF",
                    Model = "XG+",
                    HorsePower = 450,
                    HasCargoSpace = false,
                    HasTemperatureControl = false,
                    TruckImageURL = "/Images/TruckImages/DAF.png",
                    TransportCompanyId = 1,
                    RegistrationNumber = "CB5758CB"
                },

                new AutoTruck()
                {
                    Id = 2,
                    Make = "VOLVO",
                    Model = "FX",
                    HorsePower = 500,
                    HasCargoSpace = false,
                    HasTemperatureControl = false,
                    TruckImageURL = "/Images/TruckImages/VOLVO.png",
                    TransportCompanyId = 2,
                    RegistrationNumber = "IAE7551"
                },

                new AutoTruck()
                {
                    Id = 3,
                    Make = "SCANIA",
                    Model = "R510",
                    HorsePower = 510,
                    HasTemperatureControl = false,
                    HasCargoSpace = true,
                    TruckImageURL = "/Images/TruckImages/SCANIA.png",
                    TransportCompanyId = 2,
                    RegistrationNumber = "B125VTG"
                },

                new AutoTruck()
                {
                    Id = 4,
                    Make = "DAF",
                    Model = "XF+",
                    HorsePower = 450,
                    HasCargoSpace = true,
                    TruckImageURL = "/Images/TruckImages/DAF-XF-FRIGO.png",
                    TransportCompanyId = 2,
                    RegistrationNumber = "W1255BCV"
                }
            };
        }
        public static IEnumerable<Trailer> SeedTrailers()
        {
            return new List<Trailer>()
            {
                new Trailer()
                {
                    Id = 1,
                    TransportCompanyId = 1,
                    Make = "Kodel",
                    TrailerImageURL = "/Images/TrailerImages/Kogel.png",
                    HasTemperatureControl = false,
                    RegistrationNumber = "UT775"
                },

                 new Trailer()
                {
                    Id = 2,
                    TransportCompanyId = 1,
                    Make = "Krone",
                    TrailerImageURL = "/Images/TrailerImages/Krone.png",
                    HasTemperatureControl = false,
                    RegistrationNumber = "IJ274MQG"
                },

                new Trailer()
                {
                    Id = 3,
                    TransportCompanyId = 2,
                    Make = "Schmitz Cargobull",
                    TrailerImageURL = "/Images/TrailerImages/SchmitzCargobull.png",
                    HasTemperatureControl = true,
                    RegistrationNumber = "P79634"
                },

                new Trailer()
                {
                    Id = 4,
                    TransportCompanyId = 1,
                    Make = "Gray Adams",
                    TrailerImageURL = "/Images/TrailerImages/Gray_Adams_Frigo.png",
                    HasTemperatureControl = true,
                    RegistrationNumber = "F5011S"
                }
            };
        }
    }
}
