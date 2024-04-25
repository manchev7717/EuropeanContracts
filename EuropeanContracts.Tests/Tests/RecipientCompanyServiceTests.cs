using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Data;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using EuropeanContracts.Tests.ClassHelpers;

namespace EuropeanContracts.Tests.Tests
{
    [TestFixture]
    public class RecipientCompanyServiceTests
    {
        private IEnumerable<RecipientCompany> recipients;
        private IEnumerable<EuropeanContractUser> users;
        private EuropeanContractsDbContext context;
        private IRepository repository;
        private IRecipientCompanyService recipientService;
        private const string contextName = "RecipientCompanyDbInMemory";



        public EuropeanContractUser FirstUser { get; set; } = null!;
        public EuropeanContractUser SecondUser { get; set; } = null!;
        public EuropeanContractUser ThirdUser { get; set; } = null!;
        public EuropeanContractUser FourthUser { get; set; } = null!;

        [SetUp]
        public void Initializer()
        {
            recipients = new List<RecipientCompany>
            {
                 new RecipientCompany()
                 {
                      Id = 1,
                      Name = "Global workers",
                      Country = "Belgium",
                      Address = "Charleroi, str. Rue de Marcinelle 50",
                      PhoneNumber = "+3265689899852",
                      OwnerId = "SixthUserSADSAFSA222"
                 },
                 new RecipientCompany()
                 {
                     Id = 2,
                     Name = "LeDecale Boutique",
                     Country = "France",
                     Address = "Lyon, str. Rue Domer 12",
                     PhoneNumber = "+332566985556140",
                     OwnerId = "SeventhUserUser2121sd21sad2"
                 },
                 new RecipientCompany()
                 {
                     Id = 3,
                     Name = "SmartSolutions",
                     Country = "Italy",
                     Address = "Florence, str. Via Madonna Della Querce 4",
                     PhoneNumber = "+3900125221287",
                     OwnerId ="EighthUseR545s4fSASA"
                 }
            };

            FirstUser = new EuropeanContractUser()
            {
                Id = "5lk6e95e-lyj5-w25e-8w5q-9q7w8c6u3spo",
                UserName = "sixthUser@mail.com",
                NormalizedUserName = "SIXTHUSER@MAIL.COM",
                Email = "sixthUser@mail.com",
                NormalizedEmail = "SIXTHUSER@MAIL.COM",
                FirstName = "Velichko",
                LastName = "Velichkov",
                PasswordHash = "W!EEvce552veM"
            };

            SecondUser = new EuropeanContractUser()
            {
                Id = "dd2d2a66-rer7-y9y9-qlpq-w56a9w8s5a32",
                UserName = "seventhUser@mail.com",
                NormalizedUserName = "SEVENTHUSER@MAIL.COM",
                Email = "seventhuser@mail.com",
                NormalizedEmail = "SEVENTHUSER@MAIL.COM",
                FirstName = "Miroslav",
                LastName = "Miroslavov",
                PasswordHash = "55ioreew4c1npshru"
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
                PasswordHash = "QWE!@#RF22d22"
            };

            FourthUser = new EuropeanContractUser()
            {
                Id = "TestUser54s5d45sa4",
                UserName = "testUser@mail.com",
                NormalizedUserName = "TESTUSER@MAIL.COM",
                Email = "testUser@mail.com",
                NormalizedEmail = "TESTUSER@MAIL.COM",
                FirstName = "Testomir",
                LastName = "Testovski",
                PasswordHash = "test00-7"
            };

            users = new List<EuropeanContractUser>()
            {
                FirstUser, SecondUser, ThirdUser, FourthUser
            };



            this.context = InMemoryDbContexCreator.Create(contextName);
            this.context.AddRange(recipients);
            this.context.AddRange(users);
            this.context.SaveChanges();

            repository = new Repository(this.context);

            var userManager = UserManagerCreator.Create(context);

            userManager.CreateAsync(FirstUser);
            userManager.CreateAsync(SecondUser);
            userManager.CreateAsync(ThirdUser);
            userManager.CreateAsync(FourthUser);

            recipientService = new Core.Services.RecipientCompanyService(repository, userManager);
        }

        [Test]
        public void Add_ShouldAddRecipientAndCurrentClaimCorrectly()
        {
            var recipientForAdd = new RecipientCompany()
            {
                Id = 4,
                Name = "C# DeliverY Commerce",
                Country = "Portugal",
                Address = "Coimbra, str. Vasgo da Dama 77",
                PhoneNumber = "+45885546651476",
                OwnerId = "TestUser54s5d45sa4"
            };

            recipientService.AddAsync(recipientForAdd);

            Assert.That(context.RecipientsCompanies.Any(a => a.OwnerId == "TestUser54s5d45sa4" &&
                                                             a.Id == 4 &&
                                                             a.Name == "C# DeliverY Commerce" &&
                                                             a.Country == "Portugal" &&
                                                             a.PhoneNumber == "+45885546651476" &&
                                                             a.Address == "Coimbra, str. Vasgo da Dama 77"), Is.EqualTo(true));

            Assert.That(context.UserClaims.Any(a => a.ClaimValue == "C# DeliverY Commerce"), Is.EqualTo(true));
        }

        [Test]
        public async Task FindRecipient_ShouldReturnDoesRecipientExistSearchingByUserId()
        {
            string firstUserId = "EighthUseR545s4fSASA";
            string secondUserId = "SeventhUserUser2121sd21sad2";
            string thirdUserId = "NoValidUserIdsds";


            bool resultOne = await recipientService.DoesRecipientExists(firstUserId);
            bool resultTwo = await recipientService.DoesRecipientExists(secondUserId);
            bool resultThree = await recipientService.DoesRecipientExists(thirdUserId);

            Assert.That(resultOne, Is.EqualTo(true));
            Assert.That(resultTwo, Is.EqualTo(true));
            Assert.That(resultThree, Is.EqualTo(false));
        }

        [Test]
        public async Task FindRecipient_ShouldReturnDoesSuplierExistsByCountryAndName()
        {
            string countryItaly = "Italy";
            string firstNameInItaly = "MDY Tools";
            string secondNameInItaly = "SmartSolutions";

            string countryBelgium = "Belgium";
            string firstNameInBelgium = "Global workers";

            string countryFrance = "France";
            string firstNameInFrance = "WhereIs NOT Exist EnterpriseRent";
            string secondNameInFrance = "LeDecale Boutique";



            bool resultOne = await recipientService.DoesRecipientExists(countryItaly, firstNameInItaly);
            bool resultTwo = await recipientService.DoesRecipientExists(countryItaly, secondNameInItaly);

            bool resultThree = await recipientService.DoesRecipientExists(countryBelgium, firstNameInBelgium);

            bool resultFour = await recipientService.DoesRecipientExists(countryFrance, firstNameInFrance);
            bool resultFive = await recipientService.DoesRecipientExists(countryFrance, secondNameInFrance);

            Assert.That(resultOne, Is.EqualTo(false));
            Assert.That(resultTwo, Is.EqualTo(true));

            Assert.That(resultThree, Is.EqualTo(true));

            Assert.That(resultFour, Is.EqualTo(false));
            Assert.That(resultFive, Is.EqualTo(true));
        }


        [Test]

        public async Task ReturnRecipientId_ShouldReturnRecipientIdByUserId()
        {
            string firsUserId = "SixthUserSADSAFSA222";
            string secondUserId = "EighthUseR545s4fSASA";
            string thirdUserId = "SeventhUserUser2121sd21sad2";

            var resultOne = await recipientService.ReturnRecipientByUserIdAsync(firsUserId);
            var resultTwo = await recipientService.ReturnRecipientByUserIdAsync(secondUserId);
            var resultThree = await recipientService.ReturnRecipientByUserIdAsync(thirdUserId);

            Assert.That(resultOne.Id, Is.EqualTo(1));
            Assert.That(resultOne.Name, Is.EqualTo("Global workers"));

            Assert.That(resultTwo.Id, Is.EqualTo(3));
            Assert.That(resultTwo.Name, Is.EqualTo("SmartSolutions"));

            Assert.That(resultThree.Id, Is.EqualTo(2));
            Assert.That(resultThree.Name, Is.EqualTo("LeDecale Boutique"));
        }



        [OneTimeTearDown]
        public void TearDownDbContextInMemory()
        {
            context.Dispose();
        }

    }
}
