using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Data;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using EuropeanContracts.Tests.ClassHelpers;

namespace EuropeanContracts.Tests.Tests
{
    [TestFixture]
    public class TransportCompanyServiceTests
    {
        private IEnumerable<TransportCompany> transporters;
        private IEnumerable<EuropeanContractUser> users;
        private EuropeanContractsDbContext context;
        private IRepository repository;
        private ITransportCompanyService transporterService;
        private const string contextName = "TransportCompanyDbInMemory";


        public EuropeanContractUser FirstUser { get; set; } = null!;
        public EuropeanContractUser SecondUser { get; set; } = null!;

        public EuropeanContractUser ThirdUser { get; set; } = null!;

        [SetUp]
        public void Initializer()
        {
            transporters = new List<TransportCompany>
            {
                 new TransportCompany()
                 {
                      Id = 1,
                      Name = "NG TRANS",
                      Country = "Bulgaria",
                      Address = "Varna, str. Popovi livadi 99",
                      PhoneNumber = "+3598897415202",
                      OwnerId = "d336g56fd5gfd65gvr2s588"
                 },
                 new TransportCompany()
                 {
                     Id = 2,
                     Name = "VIOREL TRANS GROUP",
                     Country = "Romania",
                     Address = "Kostanza, Strada Spiru Haret 42",
                     PhoneNumber = "+00407775987456.",
                     OwnerId = "Sfaf6d56f5wwsdasfas5f5n"
                 }
            };

            FirstUser = new EuropeanContractUser()
            {
                Id = "d336g56fd5gfd65gvr2s588",
                UserName = "fourthUser@mail.com",
                NormalizedUserName = "FOURTHUSER@MAIL.COM",
                Email = "fourthUser@mail.com",
                NormalizedEmail = "FOURTHUSER@MAIL.COM",
                FirstName = "Katerina",
                LastName = "Katerinova",
                PasswordHash = "FourthUserSAfdgfsdg12"
            };

            SecondUser = new EuropeanContractUser()
            {
                Id = "Sfaf6d56f5wwsdasfas5f5n",
                UserName = "fifthUser@mail.com",
                NormalizedUserName = "FIFTHUSER@MAIL.COM",
                Email = "fifthUser@mail.com",
                NormalizedEmail = "FIFTHUSER@MAIL.COM",
                FirstName = "Dimitаr",
                LastName = "Dimitrov",
                PasswordHash = "FifthUserSFSD5q621c"
            };

            ThirdUser = new EuropeanContractUser()
            {
                Id = "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532",
                UserName = "eighthUser@mail.com",
                NormalizedUserName = "EIGHTHUSER@MAIL.COM",
                Email = "eighthUser@mail.com",
                NormalizedEmail = "EIGHTHUSER@MAIL.COM",
                FirstName = "Daniela",
                LastName = "Danielova",
                PasswordHash = "saf2a4f522"
            };

            users = new List<EuropeanContractUser>()
            {
                FirstUser, SecondUser, ThirdUser
            };



            this.context = InMemoryDbContexCreator.Create(contextName);
            this.context.AddRange(transporters);
            this.context.AddRange(users);
            this.context.SaveChanges();

            repository = new Repository(this.context);

            var userManager = UserManagerCreator.Create(context);

            userManager.CreateAsync(FirstUser);
            userManager.CreateAsync(SecondUser);
            userManager.CreateAsync(ThirdUser);

            transporterService = new Core.Services.TransportCompanyService(repository, userManager);
        }

        [Test]
        public void Add_ShouldAddTransporterAndCurrentClaimCorrectly()
        {
            var transporterForAdd = new TransportCompany()
            {
                Id = 3,
                Name = "Garthnerosy",
                Country = "Hungary",
                Address = "Kecskemet, Mindszent krt. 17",
                PhoneNumber = "+33674545451",
                OwnerId = "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532"
            };

            transporterService.AddAsync(transporterForAdd);

            Assert.That(context.TransportsCompanies.Any(a => a.OwnerId == "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532" &&
                                                             a.Id == 3 &&
                                                             a.Name == "Garthnerosy" &&
                                                             a.Country == "Hungary" &&
                                                             a.PhoneNumber == "+33674545451" &&
                                                             a.Address == "Kecskemet, Mindszent krt. 17"), Is.EqualTo(true));

            Assert.That(context.UserClaims.Any(a => a.ClaimValue == "Garthnerosy" &&
                                                    a.UserId == "d69wrpfj-asdr-uijj-j5ff-5s8q7w4e4532"), Is.EqualTo(true));
        }

        [Test]
        public async Task DoesTransporterExists_ShouldReturnDoesTransporterExistsByUserId()
        {
            string firstUserId = "d336g56fd5gfd65gvr2s588";
            string secondUserId = "Sfaf6d56f5wwsdasfas5f5n";
            string thirdUserId = "NoExistingUserf5wwsdasfas5f5n";

            bool resultOne = await transporterService.DoesTransporterExistsAsync(firstUserId);
            bool resultTwo = await transporterService.DoesTransporterExistsAsync(secondUserId);
            bool resultThree = await transporterService.DoesTransporterExistsAsync(thirdUserId);


            Assert.That(resultOne, Is.EqualTo(true));
            Assert.That(resultTwo, Is.EqualTo(true));
            Assert.That(resultThree, Is.EqualTo(false));
        }

        [Test]
        public async Task DoesTransporterExists_ShouldReturnDoesTransporterExistsByNameAndCountry()
        {
            string firstCountry = "Bulgaria";
            string firstName = "NG TRANS";

            string secondCountry = "Romania";
            string secondName = "VIOREL TRANS GROUP";

            string thirdCountry = "Romania";
            string thirdName = "NG TRANS";

            bool resultOne = await transporterService.DoesTransporterExistsAsync(firstCountry,firstName);
            bool resultTwo = await transporterService.DoesTransporterExistsAsync(secondCountry,secondName);
            bool resultThree = await transporterService.DoesTransporterExistsAsync(thirdCountry,thirdName);


            Assert.That(resultOne, Is.EqualTo(true));
            Assert.That(resultTwo, Is.EqualTo(true));
            Assert.That(resultThree, Is.EqualTo(false));
        }

        [Test]
        public async Task ReturnTransporter_ShouldReturnTransporterByUserId()
        {
            string firstUser = "Sfaf6d56f5wwsdasfas5f5n";
            string secondUser = "d336g56fd5gfd65gvr2s588";
            string thirdUser = "InvalidIdas6d5sa54d56";

            var resultOne = await transporterService.ReturnTransporterByUserIdAsync(firstUser);
            var resultTwo = await transporterService.ReturnTransporterByUserIdAsync(secondUser);
            var resultThree = await transporterService.ReturnTransporterByUserIdAsync(thirdUser);

            Assert.That(resultOne.Id, Is.EqualTo(2));
            Assert.That(resultOne.Name, Is.EqualTo("VIOREL TRANS GROUP"));
            Assert.That(resultOne.OwnerId, Is.EqualTo("Sfaf6d56f5wwsdasfas5f5n"));

            Assert.That(resultTwo.Id, Is.EqualTo(1));
            Assert.That(resultTwo.Name, Is.EqualTo("NG TRANS"));
            Assert.That(resultTwo.OwnerId, Is.EqualTo("d336g56fd5gfd65gvr2s588"));

            Assert.That(resultThree, Is.EqualTo(null));
        }

        [OneTimeTearDown]
        public void TearDownDbContextInMemory()
        {
            context.Dispose();
        }
    }
}
