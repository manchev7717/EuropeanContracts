using EuropeanContracts.Infrastructure.Data.Constance;
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
            SeedUserClaim();

        }
        public ActionType SellActionType { get; set; } = null!;
        public ActionType RentActionType { get; set; } = null!;
        public ActionType TransportationActionType { get; set; } = null!;

        public EuropeanContractUser FirstUser { get; set; } = null!;
        public EuropeanContractUser SecondUser { get; set; } = null!;
        public EuropeanContractUser ThirdUser { get; set; } = null!;
        public EuropeanContractUser FourthUser { get; set; } = null!;
        public EuropeanContractUser FifthUser { get; set; } = null!;
        public EuropeanContractUser SixthUser { get; set; } = null!;
        public EuropeanContractUser SeventhUser { get; set; } = null!;
        public EuropeanContractUser EighthUser { get; set; } = null!;

        public IdentityUserClaim<string> FirstUserClaim { get; set; } = null!;
        public IdentityUserClaim<string> SecondUserClaim { get; set; } = null!;
        public IdentityUserClaim<string> ThirdUserClaim { get; set; } = null!;
        public IdentityUserClaim<string> FourthUserClaim { get; set; } = null!;
        public IdentityUserClaim<string> FifthUserClaim { get; set; } = null!;
        public IdentityUserClaim<string> SixthUserClaim { get; set; } = null!;
        public IdentityUserClaim<string> SeventhUserClaim { get; set; } = null!;
        public IdentityUserClaim<string> EighthUserClaim { get; set; } = null!;

        public IdentityUserClaim<string> FirstSupplierClaim { get; set; } = null!;
        public IdentityUserClaim<string> SecondSupplierClaim { get; set; } = null!;
        public IdentityUserClaim<string> ThirdSupplierClaim { get; set; } = null!;

        public IdentityUserClaim<string> FirstRecipientClaim { get; set; } = null!;
        public IdentityUserClaim<string> SecondRecipientClaim { get; set; } = null!;
        public IdentityUserClaim<string> ThirdRecipientClaim { get; set; } = null!;

        public IdentityUserClaim<string> FirstTransporterClaim { get; set; } = null!;
        public IdentityUserClaim<string> SecondTransporterClaim { get; set; } = null!;



        public SupplierCompany FirstSupplierCompany { get; set; } = null!;
        public SupplierCompany SecondSupplierCompany { get; set; } = null!;
        public SupplierCompany ThirdSupplierCompany { get; set; } = null!;

        public RecipientCompany FirstRecipientCompany { get; set; } = null!;
        public RecipientCompany SecondRecipientCompany { get; set; } = null!;
        public RecipientCompany ThirdRecipientCompany { get; set; } = null!;

        public Trailer FirstTrailer { get; set; } = null!;
        public Trailer SecondTrailer { get; set; } = null!;
        public Trailer ThirdTrailer { get; set; } = null!;
        public Trailer FourthTrailer { get; set; } = null!;

        public AutoTruck FirstTruck { get; set; } = null!;
        public AutoTruck SecondTruck { get; set; } = null!;
        public AutoTruck ThirdTruck { get; set; } = null!;
        public AutoTruck FourthTruck { get; set; } = null!;

        public TransportCompany FirstTransportCompany { get; set; } = null!;
        public TransportCompany SecondTransportCompany { get; set; } = null!;

        public Offer TopOffer { get; set; } = null!;
        public Offer FirstOffer { get; set; } = null!;
        public Offer SecondOffer { get; set; } = null!;
        public Offer ChokoOffer { get; set; } = null!;


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
            var hasher = new PasswordHasher<EuropeanContractUser>();

            FirstUser = new EuropeanContractUser()
            {
                Id = "k3fcll56-l458-6871-q3r9-2ve3w9a54s87",
                UserName = "firstUser@mail.com",
                NormalizedUserName = "FIRSTUSER@MAIL.COM",
                Email = "firstUser@mail.com",
                NormalizedEmail = "FIRSTUSER@MAIL.COM",
                FirstName = "Stoyan",
                LastName = "Stoyanov"
            };
            FirstUser.PasswordHash = hasher.HashPassword(FirstUser, "123456ABC");

            SecondUser = new EuropeanContractUser()
            {
                Id = "k21se8s5-plow-4sw4-qzp0-128fpq6zr8klo",
                UserName = "secondUser@mail.com",
                NormalizedUserName = "SECONDUSER@MAIL.COM",
                Email = "secondUser@mail.com",
                NormalizedEmail = "SECONDUSER@MAIL.COM",
                FirstName = "Vasil",
                LastName = "Vasilev"
            };
            SecondUser.PasswordHash = hasher.HashPassword(SecondUser, "123456CBA");

            ThirdUser = new EuropeanContractUser()
            {
                Id = "QWE15t6s-hfgd-998q-mcs1-pekc249wlfhn",
                UserName = "thirdUser@mail.com",
                NormalizedUserName = "THIRDUSER@MAIL.COM",
                Email = "thirdUser@mail.com",
                NormalizedEmail = "THIRDUSER@MAIL.COM",
                FirstName = "Todor",
                LastName = "Todorov"
            };
            ThirdUser.PasswordHash = hasher.HashPassword(ThirdUser, "654321ABC");

            FourthUser = new EuropeanContractUser()
            {
                Id = "d33qwej9-02ap-11mnl-hflp-lpszavr2s588",
                UserName = "fourthUser@mail.com",
                NormalizedUserName = "FOURTHUSER@MAIL.COM",
                Email = "fourthUser@mail.com",
                NormalizedEmail = "FOURTHUSER@MAIL.COM",
                FirstName = "Katerina",
                LastName = "Katerinova"
            };
            FourthUser.PasswordHash = hasher.HashPassword(FourthUser, "987654FOUR");

            FifthUser = new EuropeanContractUser()
            {
                Id = "0s3a2w5e-sad5-12s5-owls-psdasfas5f5n",
                UserName = "fifthUser@mail.com",
                NormalizedUserName = "FIFTHUSER@MAIL.COM",
                Email = "fifthUser@mail.com",
                NormalizedEmail = "FIFTHUSER@MAIL.COM",
                FirstName = "Dimitаr",
                LastName = "Dimitrov"
            };
            FifthUser.PasswordHash = hasher.HashPassword(FifthUser, "987654FIVE");

            SixthUser = new EuropeanContractUser()
            {
                Id = "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                UserName = "sixthUser@mail.com",
                NormalizedUserName = "SIXTHUSER@MAIL.COM",
                Email = "sixthUser@mail.com",
                NormalizedEmail = "SIXTHUSER@MAIL.COM",
                FirstName = "Velichko",
                LastName = "Velichkov"
            };
            SixthUser.PasswordHash = hasher.HashPassword(SixthUser, "987654SIX");

            SeventhUser = new EuropeanContractUser()
            {
                Id = "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                UserName = "seventhUser@mail.com",
                NormalizedUserName = "SEVENTHUSER@MAIL.COM",
                Email = "seventhuser@mail.com",
                NormalizedEmail = "SEVENTHUSER@MAIL.COM",
                FirstName = "Miroslav",
                LastName = "Miroslavov"
            };
            SeventhUser.PasswordHash = hasher.HashPassword(SeventhUser, "987654SEVEN");

            EighthUser = new EuropeanContractUser()
            {
                Id = "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                UserName = "eighthUser@mail.com",
                NormalizedUserName = "EIGHTHUSER@MAIL.COM",
                Email = "eighthUser@mail.com",
                NormalizedEmail = "EIGHTHUSER@MAIL.COM",
                FirstName = "Daniela",
                LastName = "Danielova"
            };
            EighthUser.PasswordHash = hasher.HashPassword(EighthUser, "987654EIGHT");
        }

        private void SeedUserClaim()
        {
            FirstUserClaim = new IdentityUserClaim<string>
            {
                Id = 1,
                UserId = FirstUser.Id,
                ClaimType = CustomUserClaimType.UserFullNameCustomClaim,
                ClaimValue = $"{FirstUser.FirstName} {FirstUser.LastName}"
            };

            SecondUserClaim = new IdentityUserClaim<string>
            {
                Id = 2,
                UserId = SecondUser.Id,
                ClaimType = CustomUserClaimType.UserFullNameCustomClaim,
                ClaimValue = $"{SecondUser.FirstName} {SecondUser.LastName}",
            };

            ThirdUserClaim = new IdentityUserClaim<string>
            {
                Id = 3,
                UserId = ThirdUser.Id,
                ClaimType = CustomUserClaimType.UserFullNameCustomClaim,
                ClaimValue = $"{ThirdUser.FirstName} {ThirdUser.LastName}",
            };

            FourthUserClaim = new IdentityUserClaim<string>
            {
                Id = 4,
                UserId = FourthUser.Id,
                ClaimType = CustomUserClaimType.UserFullNameCustomClaim,
                ClaimValue = $"{FourthUser.FirstName} {FourthUser.LastName}",
            };

            FifthUserClaim = new IdentityUserClaim<string>
            {
                Id = 5,
                UserId = FifthUser.Id,
                ClaimType = CustomUserClaimType.UserFullNameCustomClaim,
                ClaimValue = $"{FifthUser.FirstName} {FifthUser.LastName}",
            };

            SixthUserClaim = new IdentityUserClaim<string>
            {
                Id = 6,
                UserId = SixthUser.Id,
                ClaimType = CustomUserClaimType.UserFullNameCustomClaim,
                ClaimValue = $"{SixthUser.FirstName} {SixthUser.LastName}",
            };

            SeventhUserClaim = new IdentityUserClaim<string>
            {
                Id = 7,
                UserId = SeventhUser.Id,
                ClaimType = CustomUserClaimType.UserFullNameCustomClaim,
                ClaimValue = $"{SeventhUser.FirstName} {SeventhUser.LastName}",
            };

            EighthUserClaim = new IdentityUserClaim<string>
            {
                Id = 8,
                UserId = EighthUser.Id,
                ClaimType = CustomUserClaimType.UserFullNameCustomClaim,
                ClaimValue = $"{EighthUser.FirstName} {EighthUser.LastName}",
            };

            FirstRecipientClaim = new IdentityUserClaim<string>
            {
                Id = 9,
                UserId = SixthUser.Id,
                ClaimType = CustomUserClaimType.UserCompanyNameCustomClaim,
                ClaimValue = FirstRecipientCompany.Name
            };

            SecondRecipientClaim = new IdentityUserClaim<string>
            {
                Id = 10,
                UserId = SeventhUser.Id,
                ClaimType = CustomUserClaimType.UserCompanyNameCustomClaim,
                ClaimValue = SecondRecipientCompany.Name
            };

            ThirdRecipientClaim = new IdentityUserClaim<string>
            {
                Id = 11,
                UserId = EighthUser.Id,
                ClaimType = CustomUserClaimType.UserCompanyNameCustomClaim,
                ClaimValue = ThirdRecipientCompany.Name
            };

            FirstSupplierClaim = new IdentityUserClaim<string>
            {
                Id = 12,
                UserId = FirstUser.Id,
                ClaimType = CustomUserClaimType.UserCompanyNameCustomClaim,
                ClaimValue = FirstSupplierCompany.Name
            };

            SecondSupplierClaim = new IdentityUserClaim<string>
            {
                Id = 13,
                UserId = SecondUser.Id,
                ClaimType = CustomUserClaimType.UserCompanyNameCustomClaim,
                ClaimValue = SecondSupplierCompany.Name
            };
            ThirdSupplierClaim = new IdentityUserClaim<string>
            {
                Id = 14,
                UserId = ThirdUser.Id,
                ClaimType = CustomUserClaimType.UserCompanyNameCustomClaim,
                ClaimValue = ThirdSupplierCompany.Name
            };

            FirstTransporterClaim = new IdentityUserClaim<string>
            {
                Id = 15,
                UserId = FourthUser.Id,
                ClaimType = CustomUserClaimType.UserCompanyNameCustomClaim,
                ClaimValue = FirstTransportCompany.Name
            };

            SecondTransporterClaim = new IdentityUserClaim<string>
            {
                Id = 16,
                UserId = FifthUser.Id,
                ClaimType = CustomUserClaimType.UserCompanyNameCustomClaim,
                ClaimValue = SecondTransportCompany.Name
            };

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
                Name = "Smart Elinas LTD",
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
            FirstTruck = new AutoTruck()
            {
                Id = 1,
                Make = "DAF",
                Model = "XG+",
                HorsePower = 450,
                HasCargoSpace = false,
                HasTemperatureControl = false,
                TruckImageURL = "/Images/TruckImages/DAF.png",
                TransportCompanyId = FirstTransportCompany.Id,
                RegistrationNumber = "CB5758CB"
            };

            SecondTruck = new AutoTruck()
            {
                Id = 2,
                Make = "VOLVO",
                Model = "FX",
                HorsePower = 500,
                HasCargoSpace = false,
                HasTemperatureControl = false,
                TruckImageURL = "/Images/TruckImages/VOLVO.png",
                TransportCompanyId = SecondTransportCompany.Id,
                RegistrationNumber = "IAE7551"
            };

            ThirdTruck = new AutoTruck()
            {
                Id = 3,
                Make = "SCANIA",
                Model = "R510",
                HorsePower = 510,
                HasTemperatureControl = false,
                HasCargoSpace = false,
                TruckImageURL = "/Images/TruckImages/SCANIA.png",
                TransportCompanyId = SecondTransportCompany.Id,
                RegistrationNumber = "B125VTG"
            };

            FourthTruck = new AutoTruck()
            {
                Id = 4,
                Make = "DAF",
                Model = "XF+",
                HorsePower = 450,
                HasCargoSpace = true,
                TruckImageURL = "/Images/TruckImages/DAF-XF-FRIGO.png",
                TransportCompanyId = SecondTransportCompany.Id,
                RegistrationNumber = "W1255BCV"
            };
        }
        private void SeedTrailers()
        {
            FirstTrailer = new Trailer()
            {
                Id = 1,
                TransportCompanyId = FirstTransportCompany.Id,
                Make = "Kodel",
                TrailerImageURL = "/Images/TrailerImages/Kogel.png",
                HasTemperatureControl = false,
                RegistrationNumber = "UT775"
            };

            SecondTrailer = new Trailer()
            {
                Id = 2,
                TransportCompanyId = FirstTransportCompany.Id,
                Make = "Krone",
                TrailerImageURL = "/Images/TrailerImages/Krone.png",
                HasTemperatureControl = false,
                RegistrationNumber = "IJ274MQG"
            };

            ThirdTrailer = new Trailer()
            {
                Id = 3,
                TransportCompanyId = SecondTransportCompany.Id,
                Make = "Schmitz Cargobull",
                TrailerImageURL = "/Images/TrailerImages/SchmitzCargobull.png",
                HasTemperatureControl = true,
                RegistrationNumber = "P79634"
            };

            FourthTrailer = new Trailer()
            {
                Id = 4,
                TransportCompanyId = FirstTransportCompany.Id,
                Make = "Gray Adams",
                TrailerImageURL = "/Images/TrailerImages/Gray_Adams_Frigo.png",
                HasTemperatureControl = true,
                RegistrationNumber = "F5011S"
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
                ProductDescription = "Тhe produce is fresh from animals raised on certified farms",
                ProductImageURL = "/Images/ProductImages/FreshPorkMeat.png",
                LoadingCountry = "Spain",
                LoadingAddress = "Badajoz, str. C.Jose.Caldito Ruiz 50",
                PublicationDay = DateTime.Now,
                ActionTypeId = SellActionType.Id,
                SupplierId = FirstSupplierCompany.Id,
                IsTemperatureControlNeeded = true,
                TransporterId = 1,
                RecipientId = 1,
                TrailerId = 4,
                TruckId = 1,
            };

            FirstOffer = new Offer()
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
                ProductDescription = "Manufactured in 2020 with a safety certificate",
                ProductImageURL = "/Images/ProductImages/ScaffoldingMaterials.png",
                LoadingCountry = "Austria",
                LoadingAddress = "Vienna, str. Sindelargasse 17",
                PublicationDay = DateTime.Now,
                ActionTypeId = RentActionType.Id,
                SupplierId = FirstSupplierCompany.Id,
                IsTemperatureControlNeeded = false
            };

            ChokoOffer = new Offer()
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
                ActionTypeId = SellActionType.Id,
                SupplierId = FirstSupplierCompany.Id,
                IsTemperatureControlNeeded = true
            };
        }


    }
}
