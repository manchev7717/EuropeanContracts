using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Data;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using EuropeanContracts.Tests.ClassHelpers;

namespace EuropeanContracts.Tests.Tests
{
    [TestFixture]
    public class SupplierCompanyServiceTests
    {
        private IEnumerable<SupplierCompany> suppliers;
        private IEnumerable<EuropeanContractUser> users;
        private EuropeanContractsDbContext context;
        private IRepository repository;
        private ISupplierCompanyService supplierService;
        private const string contextName = "SupplierCompanyDbInMemory";



        public EuropeanContractUser FirstUser { get; set; } = null!;
        public EuropeanContractUser SecondUser { get; set; } = null!;
        public EuropeanContractUser ThirdUser { get; set; } = null!;
        public EuropeanContractUser FourthUser { get; set; } = null!;

        [SetUp]
        public void Initializer()
        {
            suppliers = new List<SupplierCompany>
            {
                 new SupplierCompany()
                 {
                     Id = 1,
                     Name = "Smart Elinas LTD",
                     Country = "Greece",
                     Address = "Thessaloniki, str. Perdika 10",
                     PhoneNumber = "+0030695422154",
                     OwnerId = "FirstUserId74AS45D45ASD"
                 },
                 new SupplierCompany()
                 {
                     Id = 2,
                     Name = "MDY Tools",
                     Country = "Austria",
                     Address = "Vienna, str. LowelStrasse 69",
                     PhoneNumber = "+4368782664400",
                     OwnerId = "SecondUserISD45AD4SA54Dd"
                 },
                 new SupplierCompany()
                 {
                     Id = 3,
                     Name = "Stay Fly",
                     Country = "Spain",
                     Address = "Barcelona, str. Carrer Cruspinera 3",
                     PhoneNumber = "+342244501136",
                     OwnerId = "ThirdUserIdWQE8WQ7E8WQ7E"
                 }
            };



            FirstUser = new EuropeanContractUser()
            {
                Id = "FirstUserId74AS45D45ASD",
                UserName = "firstUser@mail.com",
                NormalizedUserName = "FIRSTUSER@MAIL.COM",
                Email = "firstUser@mail.com",
                NormalizedEmail = "FIRSTUSER@MAIL.COM",
                FirstName = "Stoyan",
                LastName = "Stoyanov",
                PasswordHash = "34213wewqre"
            };

            SecondUser = new EuropeanContractUser()
            {
                Id = "SecondUserISD45AD4SA54Dd",
                UserName = "secondUser@mail.com",
                NormalizedUserName = "SECONDUSER@MAIL.COM",
                Email = "secondUser@mail.com",
                NormalizedEmail = "SECONDUSER@MAIL.COM",
                FirstName = "Vasil",
                LastName = "Vasilev",
                PasswordHash = "ewpospoe"
            };

            ThirdUser = new EuropeanContractUser()
            {
                Id = "ThirdUserIdWQE8WQ7E8WQ7E",
                UserName = "thirdUser@mail.com",
                NormalizedUserName = "THIRDUSER@MAIL.COM",
                Email = "thirdUser@mail.com",
                NormalizedEmail = "THIRDUSER@MAIL.COM",
                FirstName = "Todor",
                LastName = "Todorov",
                PasswordHash = "ogkuw3254dsc1"
            };

            FourthUser = new EuropeanContractUser()
            {
                Id = "TestUser@#FDFDS",
                UserName = "testUser@mail.com",
                NormalizedUserName = "TESTUSER@MAIL.COM",
                Email = "testUser@mail.com",
                NormalizedEmail = "TESTUSER@MAIL.COM",
                FirstName = "Testomir",
                LastName = "Testovski",
                PasswordHash = "test007"
            };

            users = new List<EuropeanContractUser>()
            {
                FirstUser, SecondUser, ThirdUser, FourthUser
            };



            this.context = InMemoryDbContexCreator.Create(contextName);
            this.context.AddRange(suppliers);
            this.context.AddRange(users);
            this.context.SaveChanges();

            repository = new Repository(this.context);

            var userManager = UserManagerCreator.Create(context);

            userManager.CreateAsync(FirstUser);
            userManager.CreateAsync(SecondUser);
            userManager.CreateAsync(ThirdUser);
            userManager.CreateAsync(FourthUser);

            supplierService = new Core.Services.SupplierCompanyService(repository, userManager);
        }

        [Test]
        public void Add_ShouldAddSupplierAndCurrentClaimCorrectly()
        {
            var suplierForAdd = new SupplierCompany()
            {
                Id = 4,
                Name = "BestFood ASP",
                Country = "Bulgaria",
                Address = "Samokov, str. Sofiisko shose 69",
                PhoneNumber = "+080808080801136",
                OwnerId = "TestUser@#FDFDS"
            };

            supplierService.AddAsync(suplierForAdd);

            Assert.That(context.SuppliersCompanies.Any(a => a.OwnerId == "TestUser@#FDFDS" &&
                                                            a.Id == 4 &&
                                                            a.Name == "BestFood ASP" &&
                                                            a.Country == "Bulgaria" &&
                                                            a.PhoneNumber == "+080808080801136" &&
                                                            a.Address == "Samokov, str. Sofiisko shose 69"), Is.EqualTo(true));

            Assert.That(context.UserClaims.Any(a => a.ClaimValue == "BestFood ASP"), Is.EqualTo(true));
        }

        [Test]

        public async Task FindSupplierById_ShouldReturnDoesSupplierSearchingBy()
        {
            string firstUserId = "SecondUserISD45AD4SA54Dd";
            string secondUserId = "ThirdUserIdWQE8WQ7E8WQ7E";
            string thirdUserId = "NoValidUserIddW54s5d4adQ7E";


            bool resultOne = await supplierService.DoesSupplierExists(firstUserId);
            bool resultTwo = await supplierService.DoesSupplierExists(secondUserId);
            bool resultThree = await supplierService.DoesSupplierExists(thirdUserId);

            Assert.That(resultOne, Is.EqualTo(true));
            Assert.That(resultTwo, Is.EqualTo(true));
            Assert.That(resultThree, Is.EqualTo(false));
        }

        [Test]

        public async Task IsSupplierExists_ShouldReturnDoesSuplierExists()
        {
            string countryAustria = "Austria";
            string firstNameInAustria = "MDY Tools";
            string secondNameInAustria = "DO SomeEvil & Co";

            string countrySpain = "Spain";
            string firstNameInSpain = "WhereIs NOT Exist EnterpriseRent";
            string secondNameInSpain = "Stay Fly";

            string countryFrance = "France";
            string firstNameInFrance = "Erico Le Diodi";


            bool resultOne = await supplierService.DoesSupplierExists(countryAustria, firstNameInAustria);
            bool resultTwo = await supplierService.DoesSupplierExists(countryAustria, secondNameInAustria);

            bool resultThree = await supplierService.DoesSupplierExists(countryFrance, firstNameInFrance);

            bool resultFour = await supplierService.DoesSupplierExists(countrySpain, firstNameInSpain);
            bool resultFive = await supplierService.DoesSupplierExists(countrySpain, secondNameInSpain);

            Assert.That(resultOne, Is.EqualTo(true));
            Assert.That(resultTwo, Is.EqualTo(false));

            Assert.That(resultThree, Is.EqualTo(false));

            Assert.That(resultFour, Is.EqualTo(false));
            Assert.That(resultFive, Is.EqualTo(true));
        }


        [Test]

        public async Task ReturnSupplierId_ShouldReturnSupplierIdByUserId()
        {
            string firsUserId = "SecondUserISD45AD4SA54Dd";
            string secondUserId = "FirstUserId74AS45D45ASD";
            string thirdUserId = "noRealIdwew1fd21";

            var resultOne = await supplierService.ReturnSupplierIdByUserId(firsUserId);
            var resultTwo = await supplierService.ReturnSupplierIdByUserId(secondUserId);
            int resultThree = await supplierService.ReturnSupplierIdByUserId(thirdUserId);

            Assert.That(resultOne, Is.EqualTo(2));
            Assert.That(resultTwo, Is.EqualTo(1));
            Assert.That(resultThree, Is.EqualTo(0));
        }



        [OneTimeTearDown]
        public void TearDownDbContextInMemory()
        {
            context.Dispose();
        }

    }
}

