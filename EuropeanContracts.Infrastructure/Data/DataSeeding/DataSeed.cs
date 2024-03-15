using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace EuropeanContracts.Infrastructure.Data.DataSeeding
{
    internal class DataSeed
    {
        public DataSeed()
        {
            SeedIdentityUsers();
            SeedActionType();
            SeedRecipientCompany();
            SeedSupplierCompany();
            SeedTransportCompany();
            SeedTrailers();
            SeedTrucks();
            SeedOffer();
        }
        public ActionType SellActionType { get; set; } = null!;
        public ActionType RentActionType { get; set; } = null!;
        public ActionType TransportationActionType { get; set; } = null!;

        public IdentityUser FirstUser { get; set; } = null!;
        public IdentityUser SecondUser { get; set; } = null!;
        public IdentityUser ThirdUser { get; set; } = null!;
        public IdentityUser FourthUser { get; set; } = null!;
        public IdentityUser FifthUser { get; set; } = null!;
        public IdentityUser SixthUser { get; set; } = null!;
        public IdentityUser SeventhUser { get; set; } = null!;
        public IdentityUser EighthUser { get; set; } = null!;

        public SupplierCompany FirstSupplierCompany { get; set; } = null!;
        public SupplierCompany SecondSupplierCompany { get; set; } = null!;
        public SupplierCompany ThirdSupplierCompany { get; set; } = null!;

        public RecipientCompany FirstRecipientCompany { get; set; } = null!;
        public RecipientCompany SecondRecipientCompany { get; set; } = null!;
        public RecipientCompany ThirdRecipientCompany { get; set; } = null!;

        public Trailer FirstTrailer { get; set; } = null!;
        public Trailer SecondTrailer { get; set; } = null!;
        public Trailer ThirdTrailer { get; set; } = null!;

        public Truck FirstTruck { get; set; } = null!;
        public Truck SecondTruck { get; set; } = null!;
        public Truck ThirdTruck { get; set; } = null!;

        public TransportCompany FirstTransportCompany { get; set; } = null!;
        public TransportCompany SecondTransportCompany { get; set; } = null!;

        public Offer TopOffer { get; set; } = null!;
        public Offer FirstOffer { get; set; } = null!;
        public Offer SecondOffer { get; set; } = null!;


        private void SeedActionType()
        {
            SellActionType = new ActionType()
            {
                Id = 1,
                Name = "Sale",
                Description = "The amount is the purchase price of the goods and is in euros"
            };

            RentActionType = new ActionType()
            {
                Id = 2,
                Name = "Rent",
                Description = "Тhe price is for one month of use and is in euros"
            };

            TransportationActionType = new ActionType()
            {
                Id = 3,
                Name = "Transportation",
                Description = "Тhe price is for transport the cargo to the delivery address and is in euros"
            };
        }
        private void SeedIdentityUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            FirstUser = new IdentityUser()
            {
                Id = "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                UserName = "firstUser@mail.com",
                NormalizedUserName = "firstuser@mail.com",
                Email = "firstUser@mail.com",
                NormalizedEmail = "firstuser@mail.com"
            };
            FirstUser.PasswordHash = hasher.HashPassword(FirstUser, "123456ABC");

            SecondUser = new IdentityUser()
            {
                Id = "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                UserName = "secondUser@mail.com",
                NormalizedUserName = "seconduser@mail.com",
                Email = "secondUser@mail.com",
                NormalizedEmail = "seconduser@mail.com"
            };
            SecondUser.PasswordHash = hasher.HashPassword(SecondUser, "123456CBA");

            ThirdUser = new IdentityUser()
            {
                Id = "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                UserName = "thirdUser@mail.com",
                NormalizedUserName = "thirduser@mail.com",
                Email = "thirdUser@mail.com",
                NormalizedEmail = "thirduser@mail.com"
            };
            ThirdUser.PasswordHash = hasher.HashPassword(ThirdUser, "654321ABC");

            FourthUser = new IdentityUser()
            {
                Id = "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                UserName = "fourthUser@mail.com",
                NormalizedUserName = "fourthuser@mail.com",
                Email = "fourthUser@mail.com",
                NormalizedEmail = "fourthuser@mail.com"
            };
            FourthUser.PasswordHash = hasher.HashPassword(FourthUser, "987654FOUR");

            FifthUser = new IdentityUser()
            {
                Id = "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                UserName = "fifthUser@mail.com",
                NormalizedUserName = "fifthuser@mail.com",
                Email = "fifthUser@mail.com",
                NormalizedEmail = "fifthuser@mail.com"
            };
            FifthUser.PasswordHash = hasher.HashPassword(FifthUser, "987654FIVE");

            SixthUser = new IdentityUser()
            {
                Id = "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                UserName = "sixthUser@mail.com",
                NormalizedUserName = "sixthuser@mail.com",
                Email = "sixthUser@mail.com",
                NormalizedEmail = "sixthuser@mail.com"
            };
            SixthUser.PasswordHash = hasher.HashPassword(SixthUser, "987654SIX");

            SeventhUser = new IdentityUser()
            {
                Id = "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                UserName = "seventhUser@mail.com",
                NormalizedUserName = "seventhuser@mail.com",
                Email = "seventhuser@mail.com",
                NormalizedEmail = "seventhUser@mail.com"
            };
            SeventhUser.PasswordHash = hasher.HashPassword(SeventhUser, "987654SEVEN");

            EighthUser = new IdentityUser()
            {
                Id = "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                UserName = "eighthUser@mail.com",
                NormalizedUserName = "eighthuser@mail.com",
                Email = "eighthUser@mail.com",
                NormalizedEmail = "eighthuser@mail.com"
            };
            EighthUser.PasswordHash = hasher.HashPassword(EighthUser, "987654EIGHT");
        }
        private void SeedRecipientCompany()
        {
            FirstRecipientCompany = new RecipientCompany()
            {
                Id = 1,
                Name = "Global workers",
                Country = "Belgium",
                Address = "Charleroi, str. Rue de Marcinelle 50",
                PhoneNumber = "+3265689899852",
                OwnerId = SixthUser.Id
            };

            SecondRecipientCompany = new RecipientCompany()
            {
                Id = 2,
                Name = "LeDecale Boutique",
                Country = "France",
                Address = "Lyon, str. Rue Domer 12",
                PhoneNumber = "+332566985556140",
                OwnerId = SeventhUser.Id
            };

            ThirdRecipientCompany = new RecipientCompany()
            {
                Id = 3,
                Name = "SmartSolutions",
                Country = "Italy",
                Address = "Florence, str. Via Madonna Della Querce 4",
                PhoneNumber = "+3900125221287",
                OwnerId = EighthUser.Id
            };
        }
        private void SeedSupplierCompany()
        {
            FirstSupplierCompany = new SupplierCompany()
            {
                Id = 1,
                Name = "SmartSolutions",
                Country = "Greece",
                Address = "Thessaloniki, str. Perdika 10",
                PhoneNumber = "+0030695422154",
                OwnerId = FirstUser.Id
            };

            SecondSupplierCompany = new SupplierCompany()
            {
                Id = 2,
                Name = "MDY Tools",
                Country = "Austria",
                Address = "Vienna, str. LowelStrasse 69",
                PhoneNumber = "+4368782664400",
                OwnerId = SecondUser.Id
            };

            ThirdSupplierCompany = new SupplierCompany()
            {
                Id = 3,
                Name = "Stay Fly",
                Country = "Spain",
                Address = "Barcelona, str. Carrer Cruspinera 3",
                PhoneNumber = "+342244501136",
                OwnerId = ThirdUser.Id
            };

        }
        private void SeedTransportCompany()
        {
            FirstTransportCompany = new TransportCompany()
            {
                Id = 1,
                Name = "NG TRANS",
                Country = "Bulgaria",
                Address = "Varna, str. Popovi livadi 99",
                PhoneNumber = "+3598897415202",
                OwnerId = FourthUser.Id
            };

            SecondTransportCompany = new TransportCompany()
            {
                Id = 2,
                Name = "VIOREL TRANS GROUP",
                Country = "Romania",
                Address = "Kostanza, Strada Spiru Haret 42",
                PhoneNumber = "+00407775987456.",
                OwnerId = FifthUser.Id
            };


        }
        private void SeedTrucks()
        {
            FirstTruck = new Truck()
            {
                Id = 1,
                Make = "DAF",
                Model = "XG+",
                HorsePower = 450,
                HasCargoSpace = false,
                TruckImageURL = "~/Images/TrackImages/DAF",
                TransportCompanyId = FirstTransportCompany.Id
            };

            SecondTruck = new Truck()
            {
                Id = 2,
                Make = "VOLVO",
                Model = "FX",
                HorsePower = 500,
                HasCargoSpace = false,
                TruckImageURL = "~/Images/TrackImages/VOLVO",
                TransportCompanyId = SecondTransportCompany.Id
            };

            ThirdTruck = new Truck()
            {
                Id = 3,
                Make = "SCANIA",
                Model = "R510",
                HorsePower = 510,
                HasCargoSpace = true,
                TruckImageURL = "~/Images/TrackImages/SCANIA",
                TransportCompanyId = SecondTransportCompany.Id
            };
        }
        private void SeedTrailers()
        {
            FirstTrailer = new Trailer()
            {
                Id = 1,
                TransportCompanyId = FirstTransportCompany.Id,
                Make = "Kodel",
                TrailerImageURL = "~/Images/TrailersImages/Kogel",
                HasTemperatureControl = true,
            };

            SecondTrailer = new Trailer()
            {
                Id = 2,
                TransportCompanyId = FirstTransportCompany.Id,
                Make = "Krone",
                TrailerImageURL = "~/Images/TrailersImages/Krone",
                HasTemperatureControl = false,
            };

            ThirdTrailer = new Trailer()
            {
                Id = 3,
                TransportCompanyId = SecondTransportCompany.Id,
                Make = "Schmitz Cargobull",
                TrailerImageURL = "~/Images/TrailersImages/SchmitzCargobull",
                HasTemperatureControl = true,
            };
        }
        private void SeedOffer()
        {
            TopOffer = new Offer()
            {
                Id = 1,
                ProductName = "Pork Meat",
                ProductQuantity = 19840,
                ProductPrice = 102504,
                ProductDescription = SellActionType.Description,
                ProductImageURL = "~/images/ProductImages/FreshPorkMeat.png",
                LoadingCountry = "Spain",
                LoadingAddress = "Badajoz, str. C.Jose.Caldito Ruiz 50",
                PublicationDay = DateTime.Now,
                ActionTypeId = SellActionType.Id,
                SupplierId = FirstSupplierCompany.Id,
                IsTemperatureControlNeeded = true
            };

            FirstOffer = new Offer()
            {
                Id = 2,
                ProductName = "Plastic waste",
                ProductQuantity = 17800,
                ProductPrice = 4200,
                ProductDescription= TransportationActionType.Description,
                ProductImageURL = "~/images/ProductImages/PlasticWaste.png",
                LoadingCountry = "Italy",
                LoadingAddress = "Foggia, str. Via Daniele Manin 14",
                CountryOfDestination = "Bulgaria",
                AddressOfDestination = "Burgas,Lozovo district, str.Ruzha 1",
                PublicationDay = DateTime.Now,
                ActionTypeId = TransportationActionType.Id,
                SupplierId = SecondSupplierCompany.Id,
                IsTemperatureControlNeeded = false
            };

            SecondOffer = new Offer()
            {
                Id = 3,
                ProductName = "Scaffolding material",
                ProductQuantity = 19900,
                ProductPrice = 3500,
                ProductDescription = RentActionType.Description,
                ProductImageURL = "~/images/ProductImages/ScaffoldingMaterials.png",
                LoadingCountry = "Austria",
                LoadingAddress = "Vienna, str. Sindelargasse 17",
                PublicationDay = DateTime.Now,
                ActionTypeId = RentActionType.Id,
                SupplierId = FirstSupplierCompany.Id,
                IsTemperatureControlNeeded = false
            };
        }


    }
}
