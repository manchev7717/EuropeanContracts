using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Trailer;
using EuropeanContracts.Data;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using EuropeanContracts.Tests.ClassHelpers;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Tests.Tests
{
    public class TrailerServiceTests
    {
        private IEnumerable<Trailer> trailers;
        private EuropeanContractsDbContext context;
        private IRepository repository;
        private ITrailerService trailerService;
        private const string contextName = "TrailersDbInMemory";


        [SetUp]
        public void Initializer()
        {
            trailers = new List<Trailer>
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
                }
            };
            this.context = InMemoryDbContexCreator.Create(contextName);
            this.context.AddRange(trailers);
            this.context.SaveChanges();

            repository = new Repository(this.context);
            trailerService = new Core.Services.TrailerService(repository);
        }

        [Test]
        public void AddTrailer_ShouldAddTrailerCorrectly()
        {
            var currentTrailer = new Trailer()
            {
                Id = 4,
                TransportCompanyId = 1,
                Make = "Gray Adams",
                TrailerImageURL = "/Images/TrailerImages/Gray_Adams_Frigo.png",
                HasTemperatureControl = true,
                RegistrationNumber = "F5011S"
            };


            trailerService.AddTruckAsync(currentTrailer);

            Assert.True(context.Trailers.Count() == 4);
            Assert.True(context.Trailers.Any(a => a.Id == 4 && 
                                                  a.TrailerImageURL == "/Images/TrailerImages/Gray_Adams_Frigo.png" &&
                                                  a.RegistrationNumber == "F5011S" &&
                                                  a.HasTemperatureControl == true));
        }

        [Test]
        public void Delete_ShouldDeleteTrailerByIdCorrectly()
        {
            int id = 3;

            trailerService.DeleteAsync(id);

            Assert.That(context.Trailers.Any(a => a.Id == 3) == false);
            Assert.That(context.Trailers.Any(a => a.Id == 3 && 
                                             a.TrailerImageURL == "/Images/TrailerImages/SchmitzCargobull.png" && 
                                             a.RegistrationNumber == "P79634" &&
                                             a.HasTemperatureControl == true) == false);


        }

        [Test]

        public void Edit_ShouldEditTrailerCorrectly()
        {
            var trailerForEditing = new EditAndDeleteTrailerViewModel()
            {
                Id = 1,
                TransportCompanyId = 1,
                Make = "schmitz cargobull",
                TrailerImageURL = "/Images/TrailerImages/Kogel.png",
                HasTemperatureControl = true,
                RegistrationNumber = "CB8855CB"
            };

            trailerService.EditAsync(trailerForEditing);

            Assert.That(context.Trailers.Any(a => a.Id == 1 &&
                                                  a.Make == "schmitz cargobull" &&
                                                  a.TransportCompanyId == 1 &&
                                                  a.TrailerImageURL == "/Images/TrailerImages/Kogel.png" &&
                                                  a.HasTemperatureControl == true && 
                                                  a.RegistrationNumber == "CB8855CB"));
        }

        [Test]
        public async Task ExistById_ShouldReturnDoesTrailerExistCorrectly()
        {
            int firstId = 2;
            int secondId = 5;

            bool firstResult = await trailerService.ExistByIdAsync(firstId);
            var secondResult = await trailerService.ExistByIdAsync(secondId);

            Assert.That(firstResult == true);
            Assert.That(secondResult == false);

        }

        [Test]

        public async Task HasTrailerTemperaturControl_ShouldReturnDoesTrailerHasTemperatureControl()
        {

            int firstId = 3;
            int secondId = 2;

            bool firstResult = await trailerService.HasTrailerTemperaturControlAsync(firstId);
            bool secondResult = await trailerService.HasTrailerTemperaturControlAsync(secondId);

            Assert.That(firstResult,Is.EqualTo(true));
            Assert.That(secondResult,Is.EqualTo(false));
        }


        [Test]
        public async Task GetTraileForOffer_ShouldIAllTrailersOnCurrentTransporterForOfferView()
        {
            int firstTransporterId = 2;
            bool isTemperatureRequired1 = false;

            int secondTransporterId = 1;
            bool isTemperatureRequired2 = true;


            var firstResult = await trailerService.GetTrailerForOfferAsync(isTemperatureRequired1,firstTransporterId);
            var secondResult = await trailerService.GetTrailerForOfferAsync(isTemperatureRequired2,secondTransporterId);
            var thirdResult = await trailerService.GetTrailerForOfferAsync(isTemperatureRequired1,secondTransporterId);

            Assert.That(firstResult.Count(), Is.EqualTo(1));
            Assert.That(firstResult.Any(a => a.RegistrationNumber == "P79634" && a.Id == 3));

            Assert.That(secondResult.Count(),Is.EqualTo(0));

            Assert.That(thirdResult.Count(),Is.EqualTo(2));
            Assert.That(thirdResult.Any(a => a.Id == 1 && a.RegistrationNumber == "UT775"));
            Assert.That(thirdResult.Any(a => a.Id == 2 && a.RegistrationNumber == "IJ274MQG"));
        }

        [Test]
        public async Task ReturnEditTrailerViewModel_ShouldReturnTrailerViewModelForEditing()
        {
            int trailerIdOne = 2;
            int trailerIdTwo = 1;

            var result1 = await trailerService.ReturnEditTrailerViewModelByIdAsync(trailerIdOne);
            var result2 = await trailerService.ReturnEditTrailerViewModelByIdAsync(trailerIdTwo);

            Assert.That(result1.TrailerImageURL, Is.EqualTo("/Images/TrailerImages/Krone.png"));
            Assert.That(result1.RegistrationNumber, Is.EqualTo("IJ274MQG"));
            Assert.That(result1.Make, Is.EqualTo("Krone"));

            Assert.That(result2.TrailerImageURL, Is.EqualTo("/Images/TrailerImages/Kogel.png"));
            Assert.That(result2.RegistrationNumber, Is.EqualTo("UT775"));
            Assert.That(result2.Make, Is.EqualTo("Kodel"));
        }

        [Test]

        public async Task AllTrailers_ShouldReturnAllTrailersByTransporterId()
        {
            string isTemperatureNeeded = "true";
            int currentPage = 1;
            int trailerCountOnPage = 1;
            int transportCompanyId = 1;

            var result = await trailerService.AllTrailersAsync(isTemperatureNeeded,
                                                           currentPage,
                                                           trailerCountOnPage,
                                                           transportCompanyId);

            string isTemperatureNeeded1 = "false";
            int currentPage1 = 1;
            int trailerCountOnPage1 = 2;
            int transportCompanyId1 = 2;

            var result2 = await trailerService.AllTrailersAsync(isTemperatureNeeded1,
                                                          currentPage1,
                                                          trailerCountOnPage1,
                                                          transportCompanyId1);

            var result3 = await trailerService.AllTrailersAsync(isTemperatureNeeded,
                                                          currentPage1,
                                                          trailerCountOnPage1,
                                                          transportCompanyId1);
            Assert.That(result.TotalTrailersCount, Is.EqualTo(0));

            Assert.That(result2.TotalTrailersCount, Is.EqualTo(0));

            Assert.That(result3.Trailers.Any(a => a.RegistrationNumber == "P79634"), Is.EqualTo(true));
            Assert.That(result3.Trailers.Any(a => a.TrailerImageURL == "/Images/TrailerImages/SchmitzCargobull.png"), Is.EqualTo(true));
            Assert.That(result3.Trailers.Any(a => a.Id == 3), Is.EqualTo(true));
        }

        [OneTimeTearDown]
        public void TearDownDbContextInMemory()
        {
            context.Dispose();
        }

    }
}
