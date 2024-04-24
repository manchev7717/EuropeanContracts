using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Truck;
using EuropeanContracts.Data;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Tests.Tests
{
    public class TruckServiceTests
    {
        private IEnumerable<AutoTruck> trucks;
        private EuropeanContractsDbContext context;
        private IRepository repository;
        private ITruckService truckService;


        [SetUp]
        public void Initializer()
        {
            trucks = new List<AutoTruck>
            {
                new AutoTruck()
                {
                    Id = 1,
                    Make = "DAF",
                    Model = "XG+",
                    HorsePower = 450,
                    HasCargoSpace = false,
                    HasTemperatureControl = true,
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
                    HasTemperatureControl = true,
                    HasCargoSpace = true,
                    TruckImageURL = "/Images/TruckImages/SCANIA.png",
                    TransportCompanyId = 2,
                    RegistrationNumber = "B125VTG"
                },

            };

            var optionsDb = new DbContextOptionsBuilder<EuropeanContractsDbContext>()
                .UseInMemoryDatabase("AutoTruckDbInMemory" + DateTime.Now.Ticks.ToString())
                .Options;
            this.context = new EuropeanContractsDbContext(optionsDb);
            this.context.AddRange(trucks);
            this.context.SaveChanges();

            repository = new Repository(this.context);
            truckService = new Core.Services.TruckService(repository);
        }

        [Test]
        public void AddTruck_ShouldAddTruckCorrectly()
        {
           var currentTruck = new AutoTruck()
           {
                Id = 4,
                Make = "DAF",
                Model = "XF+",
                HorsePower = 450,
                HasCargoSpace = true,
                TruckImageURL = "/Images/TruckImages/DAF-XF-FRIGO.png",
                TransportCompanyId = 3,
                RegistrationNumber = "W1255BCV"
           };


            truckService.AddTruckAsync(currentTruck);

            Assert.True(context.AutoTrucks.Count() == 4);
            Assert.True(context.AutoTrucks.Any(a => a.Id == 4 
            && a.TruckImageURL == "/Images/TruckImages/DAF-XF-FRIGO.png" && a.RegistrationNumber == "W1255BCV"));
        }

        [Test]
        public void Delete_ShouldDeleteTruckByIdCorrectly()
        {
            int id = 3;

            truckService.DeleteAsync(id);

            Assert.That(context.AutoTrucks.Any(a => a.Id == 3) == false);
            Assert.That(context.AutoTrucks.Any(a => a.Id == 3
            && a.TruckImageURL == "/Images/TruckImages/SCANIA.png" && a.RegistrationNumber == "B125VTG") == false);


        }

        [Test]

        public void Edit_ShouldEditTruckCorrectly()
        {
            var truckForEditing = new EditAndDeleteTruckViewModel()
            {
                Id = 1,
                Make = "Lada",
                Model = "Samara",
                HorsePower = 585,
                HasCargoSpace = true,
                HasTemperatureControl = true,
                TruckImageURL = "/Images/TruckImages/DAF-XF-FRIGO.png",
                RegistrationNumber = "E7777ME"
            };

            truckService.EditAsync(truckForEditing);

            Assert.That(context.AutoTrucks.Any(a => a.Id == 1 && 
                                                    a.Make == "Lada" &&
                                                    a.Model == "Samara" &&
                                                    a.HorsePower == 585 &&
                                                    a.HasCargoSpace == true &&
                                                    a.HasTemperatureControl == true &&
                                                    a.TruckImageURL == "/Images/TruckImages/DAF-XF-FRIGO.png" &&
                                                    a.RegistrationNumber == "E7777ME"));
        }

        [Test]
        public async Task ExistById_ShouldReturnIsTruckExistCorrectly()
        {
            int firstId = 1;
            int secondId = 5;

            bool firstResult = await truckService.ExistByIdAsync(firstId);
            var secondResult = await truckService.ExistByIdAsync(secondId);

            Assert.That(firstResult == true);
            Assert.That(secondResult == false);

        }

        [Test]

        public async Task HasTruckTemperaturControl_ShouldReturnIsTruckHasTemperatureControl()
        {

            int firstId = 1;
            int secondId = 2;

            bool firstResult = await truckService.HasTruckTemperaturControlAsync(firstId);
            var secondResult = await truckService.HasTruckTemperaturControlAsync(secondId);

            Assert.That(firstResult == true);
            Assert.That(secondResult == false);
        }


        [Test]
        public async Task GetTruckForOffer_ShouldIAllTrucksOnCurrentTransporterForOfferView()
        {
            int transporterId = 2;

            var result = await truckService.GetTruckForOfferAsync(transporterId);

            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.Any(a => a.RegistrationNumber == "IAE7551"));
            Assert.That(result.Any(a => a.RegistrationNumber == "B125VTG"));
            Assert.That(result.Any(a => a.RegistrationNumber != "CB5758CB"));
            Assert.That(result.Any(a=>a.Id == 2));
            Assert.That(result.Any(a=>a.Id == 3));
        }

        [Test]
        public  async Task ReturnEditTruckViewModel_ShouldReturnTruckViewModelForEditing()
        {
            int truckIdOne = 2;
            int truckIdTwo = 1;

            var result1 = await truckService.ReturnEditTruckViewModelByIdAsync(truckIdOne);
            var result2 = await truckService.ReturnEditTruckViewModelByIdAsync(truckIdTwo);

            Assert.That(result1.TruckImageURL, Is.EqualTo("/Images/TruckImages/VOLVO.png"));
            Assert.That(result1.RegistrationNumber, Is.EqualTo("IAE7551"));

            Assert.That(result2.TruckImageURL, Is.EqualTo("/Images/TruckImages/DAF.png"));
            Assert.That(result2.RegistrationNumber, Is.EqualTo("CB5758CB"));
        }

        [Test]

        public async Task AllTrucks_ShouldReturnAllTruckByTransporterId()
        {
            string isTemperatureNeeded = "true";
            string hasCargoSpace = "true";
            int currentPage = 1;
            int truckCountOnPage = 2;
            int transportCompanyId = 2;

            var result = await truckService.AllTrucksAsync(isTemperatureNeeded,
                                                           hasCargoSpace,
                                                           currentPage,
                                                           truckCountOnPage,
                                                           transportCompanyId);

            string isTemperatureNeeded1 = "false";
            string hasCargoSpace1 = "false";
            int currentPage1 = 1;
            int truckCountOnPage1 = 2;
            int transportCompanyId1 = 2;

            var result2 = await truckService.AllTrucksAsync(isTemperatureNeeded1,
                                                          hasCargoSpace1,
                                                          currentPage1,
                                                          truckCountOnPage1,
                                                          transportCompanyId1);

            Assert.That(result.TotalTruckCount, Is.EqualTo(1));
            Assert.That(result.Trucks.Any(a=>a.RegistrationNumber == "B125VTG"), Is.EqualTo(true));
            Assert.That(result.Trucks.Any(a=>a.TruckImageURL == "/Images/TruckImages/SCANIA.png"), Is.EqualTo(true));
            Assert.That(result.Trucks.Any(a=>a.Id == 3), Is.EqualTo(true));



            Assert.That(result2.TotalTruckCount, Is.EqualTo(1));
            Assert.That(result2.Trucks.Any(a => a.RegistrationNumber == "IAE7551"), Is.EqualTo(true));
            Assert.That(result2.Trucks.Any(a => a.TruckImageURL == "/Images/TruckImages/VOLVO.png"), Is.EqualTo(true));
            Assert.That(result2.Trucks.Any(a => a.Id == 2), Is.EqualTo(true));
        }

        [OneTimeTearDown]
        public void TearDownDbContextInMemory()
        {
            context.Dispose();
        }
    }
}
