using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Offer;
using EuropeanContracts.Core.ServiceViewModels.Recipient;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Data;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using EuropeanContracts.Tests.ClassHelpers;

namespace EuropeanContracts.Tests.Tests
{
    [TestFixture]
    public class OfferServiceTests
    {
        private IEnumerable<Offer> offers;
        private IEnumerable<ActionType> actionTypes;
        private IEnumerable<SupplierCompany> suppliers;
        private IEnumerable<TransportCompany> transports;
        private IEnumerable<AutoTruck> trucks;
        private IEnumerable<Trailer> trailers;
        private IEnumerable<RecipientCompany> recipients;
        private EuropeanContractsDbContext context;
        private IRepository repository;
        private IOfferService offerService;
        private const string contextName = "OfferDbInMemory";

        [SetUp]
        public void Initializer()
        {
            offers = OfferDataSeedingForTests.SeedOffers();

            actionTypes = OfferDataSeedingForTests.SeedActionTupes();

            suppliers = OfferDataSeedingForTests.SeedSuppliers();

            transports = OfferDataSeedingForTests.SeedTransporters();

            trucks = OfferDataSeedingForTests.SeedTrucks();

            trailers = OfferDataSeedingForTests.SeedTrailers();

            recipients = OfferDataSeedingForTests.SeedRecipient();


            this.context = InMemoryDbContexCreator.Create(contextName);
            this.context.AddRange(actionTypes);
            this.context.AddRange(transports);
            this.context.AddRange(trucks);
            this.context.AddRange(trailers);
            this.context.AddRange(suppliers);
            this.context.AddRange(recipients);
            this.context.AddRange(offers);
            this.context.SaveChanges();

            repository = new Repository(this.context);

            offerService = new Core.Services.OfferService(repository);
        }

        [Test]
        public async Task CreateOffer_SholudAddNewOfferCorrectly()
        {
            CreateOfferViewModel offer = new CreateOfferViewModel()
            {
                ProductName = "Bananas",
                ProductQuantity = 19840,
                ProductPrice = 47777.77m,
                ProductDescription = "The production with a high quality certificate and guaranteed origin",
                ProductImageURL = "/Images/ProductImages/BananasWithPallets.png",
                LoadingCountry = "Greece",
                LoadingAddress = "Thessaloniki, Cargo port, dock 22, ramp 7",
                PublicationDay = DateTime.Now,
                ActionTypeId = 1,
                SupplierId = 1,
                IsTemperatureControlNeeded = true
            };

            await offerService.CreateOfferAsync(offer);

            Assert.That(context.Offers.Any(o => o.Id == 5 &&
                                              o.ProductName == "Bananas" &&
                                              o.ProductQuantity == 19840 &&
                                              o.ProductPrice == 47777.77m &&
                                              o.ProductDescription == "The production with a high quality certificate and guaranteed origin" &&
                                              o.ProductImageURL == "/Images/ProductImages/BananasWithPallets.png" &&
                                              o.LoadingCountry == "Greece" &&
                                              o.LoadingAddress == "Thessaloniki, Cargo port, dock 22, ramp 7" &&
                                              o.ActionTypeId == 1 &&
                                              o.SupplierId == 1 &&
                                              o.IsTemperatureControlNeeded == true), Is.EqualTo(true));
        }

        [Test]

        public async Task DoesOfferExist_ShouldReturnDoesIsOfferExistSearchingById()
        {
            int firstOfferId = 1;
            int secondOfferId = 3;
            int thirdOfferId = 10;

            bool resultOne = await offerService.DoesOfferExistById(firstOfferId);
            bool resultTwo = await offerService.DoesOfferExistById(secondOfferId);
            bool resultThree = await offerService.DoesOfferExistById(thirdOfferId);


            Assert.That(resultOne, Is.EqualTo(true));
            Assert.That(resultTwo, Is.EqualTo(true));
            Assert.That(resultThree, Is.EqualTo(false));
        }

        [Test]

        public async Task AllLoadingCountryNames_ShouldReturnAllLoadingCountryNames()
        {
            var result = await offerService.AllLoadingCountryNamesAsync();

            Assert.That(result.Count(), Is.EqualTo(4));
            Assert.That(result.Contains("Spain"), Is.EqualTo(true));
            Assert.That(result.Contains("Italy"), Is.EqualTo(true));
            Assert.That(result.Contains("Hungary"), Is.EqualTo(true));
            Assert.That(result.Contains("Austria"), Is.EqualTo(true));
        }

        [Test]
        public async Task All_ShouldReturnAllOffersByGivenCriteria()
        {
            int currentPage = 1;
            int offerCountOnPage = 1;
            string actionType = "Sale";
            string country = "Hungary";
            string isTemperatureControlNeeded = "true";

            int offerCountOnPageTwo = 4;
            string? actionTypeNull = null;
            string? countryNull = null;
            string? isTemperatureControlNeededNull = null;

            var resultOne = await offerService.AllAsync(actionType,
                                                        country,
                                                        isTemperatureControlNeeded,
                                                        currentPage,
                                                        offerCountOnPage);




            Assert.That(resultOne.AllOffersCount, Is.EqualTo(1));
            Assert.That(resultOne.OfferViewModels.Any(o => o.Id == 4 &&
                                                           o.LoadingAddress == "Debrecen, str. Biczokert 52" &&
                                                           o.ProductImageURL == "/Images/ProductImages/chocolateProducts.png" &&
                                                           o.ProductName == "Chocolate Products" &&
                                                           o.ProductPrice == 36745.55m), Is.EqualTo(true));


            var resultTwo = await offerService.AllAsync(actionTypeNull,
                                                        countryNull,
                                                        isTemperatureControlNeededNull,
                                                        currentPage,
                                                        offerCountOnPageTwo);

            Assert.That(resultTwo.AllOffersCount, Is.EqualTo(4));
            Assert.That(resultTwo.OfferViewModels.Any(o => o.Id == 4 &&
                                                           o.LoadingCountry == "Hungary" &&
                                                           o.ProductImageURL == "/Images/ProductImages/chocolateProducts.png"),
                                                           Is.EqualTo(true));

            Assert.That(resultTwo.OfferViewModels.Any(o => o.Id == 3 &&
                                                           o.LoadingCountry == "Austria" &&
                                                           o.ProductImageURL == "/Images/ProductImages/ScaffoldingMaterials.png"),
                                                           Is.EqualTo(true));


            Assert.That(resultTwo.OfferViewModels.Any(o => o.Id == 2 &&
                                                           o.LoadingCountry == "Italy" &&
                                                           o.ProductImageURL == "/Images/ProductImages/PlasticWaste.png"),
                                                           Is.EqualTo(true));

            Assert.That(resultTwo.OfferViewModels.Any(o => o.Id == 1 &&
                                                            o.LoadingCountry == "Spain" &&
                                                            o.ProductImageURL == "/Images/ProductImages/FreshPorkMeat.png"),
                                                            Is.EqualTo(true));

        }

        [Test]
        public async Task AllOffersForTransporter_ShouldReturnAllOffersForTransporterCompany()
        {
            string isContact = "false";
            string isContractTrue = "true";
            int currentPage = 1;
            int offersCountOnPage = 1;
            string userId = "d33qwej9-02ap-11mnl-hflp-lpszavr2s588";

            var result = await offerService.AllOffersForTransporterAsync(isContact, 
                                                                         currentPage, 
                                                                         offersCountOnPage, 
                                                                         userId);

            var resultTwo = await offerService.AllOffersForTransporterAsync(isContractTrue,
                                                                         currentPage,
                                                                         offersCountOnPage,
                                                                         userId);

            Assert.That(result.AllOffersCount, Is.EqualTo(1));
            Assert.That(result.OfferViewModels.Any(a => a.Id == 1 &&
                                                      a.ProductName == "Pork Meat" &&
                                                      a.ProductQuantity == 19840 &&
                                                      a.ProductPrice == 102504 && 
                                                      a.ProductImageURL == "/Images/ProductImages/FreshPorkMeat.png" &&
                                                      a.LoadingCountry == "Spain" &&
                                                      a.LoadingAddress == "Badajoz, str. C.Jose.Caldito Ruiz 50" && 
                                                      a.ActionType == "Sale" &&
                                                      a.IsTemperatureControlNeeded == true && 
                                                      a.SupplierId == 1), Is.EqualTo(true));

            Assert.That(resultTwo.AllOffersCount, Is.EqualTo(0));
        }

        [Test]

        public async Task AllOffersForSupplier_ShouldReturnAllOffersForSupplierCompany()
        {
            string isContract = "False";
            int currentPage = 1;
            int offersCountOnPage = 1;
            int offersCountOnPageThree = 3;
            int supplierId = 1;

            var result = await offerService.AllOffersForSupplierAsync(currentPage,
                                                                      offersCountOnPage,
                                                                      isContract,
                                                                      supplierId);

            var resultTwo = await offerService.AllOffersForSupplierAsync(currentPage,
                                                                    offersCountOnPageThree,
                                                                    isContract,
                                                                    supplierId);

            Assert.That(result.AllOffersCount, Is.EqualTo(3));
            Assert.That(result.OfferViewModels.Count(), Is.EqualTo(1));
            Assert.That(result.OfferViewModels.Any(a => a.Id == 1 &&
                                                        a.ProductName == "Pork Meat" &&
                                                        a.ProductQuantity == 19840 &&
                                                        a.ProductPrice == 102504 &&
                                                        a.ProductImageURL == "/Images/ProductImages/FreshPorkMeat.png" &&
                                                        a.LoadingCountry == "Spain" &&
                                                        a.LoadingAddress == "Badajoz, str. C.Jose.Caldito Ruiz 50" &&
                                                        a.ActionType == "Sale" &&
                                                        a.IsTemperatureControlNeeded == true &&
                                                        a.SupplierId == 1), Is.EqualTo(true));

            Assert.That(resultTwo.AllOffersCount, Is.EqualTo(3));
            Assert.That(resultTwo.OfferViewModels.Count(), Is.EqualTo(3));
            Assert.That(resultTwo.OfferViewModels.Any(a => a.Id == 1 &&
                                                           a.ProductName == "Pork Meat" &&
                                                           a.ProductQuantity == 19840 &&
                                                           a.ProductPrice == 102504 &&
                                                           a.ProductImageURL == "/Images/ProductImages/FreshPorkMeat.png" &&
                                                           a.LoadingCountry == "Spain" &&
                                                           a.LoadingAddress == "Badajoz, str. C.Jose.Caldito Ruiz 50" &&
                                                           a.ActionType == "Sale" &&
                                                           a.IsTemperatureControlNeeded == true &&
                                                           a.SupplierId == 1), Is.EqualTo(true));

            Assert.That(resultTwo.OfferViewModels.Any(a => a.Id == 3 &&
                                                           a.ProductName == "Scaffolding material" &&
                                                           a.ProductQuantity == 19900 &&
                                                           a.ProductPrice == 3500 &&
                                                           a.ProductImageURL == "/Images/ProductImages/ScaffoldingMaterials.png" &&
                                                           a.LoadingCountry == "Austria" &&
                                                           a.LoadingAddress == "Vienna, str. Sindelargasse 17" &&
                                                           a.ActionType == "Rent" &&
                                                           a.IsTemperatureControlNeeded == false),
                                                           Is.EqualTo(true));

            Assert.That(resultTwo.OfferViewModels.Any(a => a.Id == 4 &&
                                                           a.ProductName == "Chocolate Products" &&
                                                           a.ProductQuantity == 17450 &&
                                                           a.ProductPrice == 36745.55m &&
                                                           a.ProductImageURL == "/Images/ProductImages/chocolateProducts.png" &&
                                                           a.LoadingCountry == "Hungary" &&
                                                           a.LoadingAddress == "Debrecen, str. Biczokert 52" &&
                                                           a.ActionType == "Sale" &&
                                                           a.IsTemperatureControlNeeded == true),
                                                           Is.EqualTo(true));
        }

        [Test] 
        public async Task AllOffersForRecipient_ShouldReturnAllOffersForRecipientCompany()
        {
            string isContract = "false";
            int currentPage = 1;
            int offersCountOnPage = 1;
            string userId = "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo";

            var result = await offerService.AllOffersForRecipientAsync(isContract,
                                                                       currentPage,
                                                                       offersCountOnPage,
                                                                       userId);

            Assert.That(result.AllOffersCount, Is.EqualTo(1));
            Assert.That(result.OfferViewModels.Any(a => a.Id == 1 &&
                                                        a.ProductName == "Pork Meat" &&
                                                        a.ProductQuantity == 19840 &&
                                                        a.ProductPrice == 102504 &&
                                                        a.ProductImageURL == "/Images/ProductImages/FreshPorkMeat.png" &&
                                                        a.LoadingCountry == "Spain" &&
                                                        a.LoadingAddress == "Badajoz, str. C.Jose.Caldito Ruiz 50" &&
                                                        a.ActionType == "Sale" &&
                                                        a.IsTemperatureControlNeeded == true &&
                                                        a.SupplierId == 1),
                                                        Is.EqualTo(true));

        }

        [Test]

        public async Task AddTransporterInOffer_ShouldCorrectlyAddTransporterInOffer()
        {
            var transporterForAddViewModel = new AddTransportCompanyInOfferViewModel()
            {
                OfferId = 2,
                TransporterId = 2,
                TruckId = 3,
                TrailerId = 3,
                IsTemperatureRequired = false,
            };

            await offerService.AddTransporterInOfferAsync(transporterForAddViewModel);

            Assert.That(context.Offers.Where(o => o.TransporterId != null).Count(), Is.EqualTo(2));
            Assert.That(context.Offers.Any(o => o.Id == 2 &&
                                                o.TransporterId == 2 &&
                                                o.TruckId == 3 &&
                                                o.TrailerId == 3 &&
                                                o.LoadingCountry == "Italy" &&
                                                o.LoadingAddress == "Foggia, str. Via Daniele Manin 14"),
                                                Is.EqualTo(true));
        }

        [Test]

        public async Task AddRecipientInOffer_SouldCorrectlyAddRecipientInOffer()
        {
            var recipientToAddViewModel = new AddRecipientCompanyInOfferViewModel()
            {
                OfferId = 4,
                RecipientId = 2,
                AddressOfDestination = "Caslav, str. Svatopluka Cecha 159",
                CountryOfDestination = "Czech Republic"
            };

            await offerService .AddRecipientInOfferAsync(recipientToAddViewModel);

            Assert.That(context.Offers.Where(o => o.RecipientId != null).Count(), Is.EqualTo(2));
            Assert.That((context.Offers.Where(o => o.RecipientId != null).Count()) == 3, Is.EqualTo(false));
            Assert.That(context.Offers.Any(o => o.Id == 4 &&
                                                o.LoadingCountry == "Hungary" &&
                                                o.LoadingAddress == "Debrecen, str. Biczokert 52" &&
                                                o.RecipientId == 2 && 
                                                o.AddressOfDestination == "Caslav, str. Svatopluka Cecha 159" &&
                                                o.CountryOfDestination == "Czech Republic"),
                                                Is.EqualTo(true));
        }


        [Test] 
        public async Task DetailsOffer_ShouldReturnDetailForCurrentOfferById()
        {
            int offerIdOne = 1;
            int offerIdTwo = 4;

            var result = await offerService.DetailsOfferAsync(offerIdOne);
            var resultTwo = await offerService.DetailsOfferAsync(offerIdTwo);

            Assert.That(result.OfferViewModel.Id, Is.EqualTo(1));
            Assert.That(result.OfferViewModel.ProductName, Is.EqualTo("Pork Meat"));
            Assert.That(result.OfferViewModel.ProductQuantity, Is.EqualTo(19840));
            Assert.That(result.ProductDescription, Is.EqualTo("Тhe produce is fresh from animals raised on certified farms"));
            Assert.That(result.OfferViewModel.ProductImageURL, Is.EqualTo("/Images/ProductImages/FreshPorkMeat.png"));
            Assert.That(result.OfferViewModel.LoadingCountry, Is.EqualTo("Spain"));
            Assert.That(result.OfferViewModel.LoadingAddress, Is.EqualTo("Badajoz, str. C.Jose.Caldito Ruiz 50"));
            Assert.That(result.OfferViewModel.IsTemperatureControlNeeded, Is.EqualTo(true));
            Assert.That(result.OfferViewModel.ActionType, Is.EqualTo("Sale"));
            Assert.That(result.RecipientDetail.RecipientCountry, Is.EqualTo("Belgium"));
            Assert.That(result.RecipientDetail.RecipientId, Is.EqualTo(1));
            Assert.That(result.RecipientDetail.RecipientName, Is.EqualTo("Global workers"));
            Assert.That(result.RecipientDetail.RecipientPhoneNumber, Is.EqualTo("+3265689899852"));
            Assert.That(result.TransporterDetail.TransporterId, Is.EqualTo(1));
            Assert.That(result.TransporterDetail.TransporterName, Is.EqualTo("NG TRANS"));
            Assert.That(result.TransporterDetail.TransporterCountry, Is.EqualTo("Bulgaria"));
            Assert.That(result.TransporterDetail.TransporterPhoneNumber, Is.EqualTo("+3598897415202"));
            Assert.That(result.TransporterDetail.TruckMake, Is.EqualTo("DAF"));
            Assert.That(result.TransporterDetail.TruckRegistration, Is.EqualTo("CB5758CB"));
            Assert.That(result.TransporterDetail.TrailerMake, Is.EqualTo("Gray Adams"));
            Assert.That(result.TransporterDetail.TrailerRegistration, Is.EqualTo("F5011S"));

            Assert.That(resultTwo.OfferViewModel.ProductName,Is.EqualTo("Chocolate Products"));
            Assert.That(resultTwo.OfferViewModel.ProductQuantity,Is.EqualTo(17450));
            Assert.That(resultTwo.OfferViewModel.ProductPrice ,Is.EqualTo(36745.55m));
            Assert.That(resultTwo.OfferViewModel.ActionDescription ,Is.EqualTo("The amount is the purchase price of the goods and is in euros"));
            Assert.That(resultTwo.OfferViewModel.LoadingCountry ,Is.EqualTo("Hungary"));
            Assert.That(resultTwo.OfferViewModel.LoadingAddress ,Is.EqualTo("Debrecen, str. Biczokert 52"));
            Assert.That(resultTwo.OfferViewModel.IsTemperatureControlNeeded,Is.EqualTo(true));
            Assert.That(resultTwo.OfferViewModel.ActionType,Is.EqualTo("Sale"));

        }

        [OneTimeTearDown]
        public void TearDownDbContextInMemory()
        {
            context.Dispose();
        }
    }
}
