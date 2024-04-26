using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.ActionType;
using EuropeanContracts.Data;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using EuropeanContracts.Tests.ClassHelpers;

namespace EuropeanContracts.Tests.Tets
{
    [TestFixture]
    public class ActionTypeServiceTests
    {
        private IEnumerable<ActionType> actionTypes;
        private EuropeanContractsDbContext context;
        private IRepository repository;
        private IActionTypeService actionTypeService;
        private const string contextName = "ActionTypesDbInMemory";


        [SetUp]
        public void Initializer()
        {
            actionTypes = new List<ActionType>
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
                 }
            };
            this.context = InMemoryDbContexCreator.Create(contextName);
            this.context.AddRange(actionTypes);
            this.context.SaveChanges();

            repository = new Repository(this.context);
            actionTypeService = new Core.Services.ActionTypeService(repository);

        }

        [Test]
        public void CreateAction_ShouldCreateActionTypeCorrectly()
        {
            var actionToCreate = new CreateActionTypeViewModel()
            {
                Name = "Transportation",
                Description = "Тhe price is for transport the cargo to the delivery address and is in euros"
            };

            actionTypeService.CreateAction(actionToCreate);

            Assert.True(context.ActionsTypes.Count() == 3);
            Assert.True(context.ActionsTypes.Any(a => a.Id == 3));
            Assert.True(context.ActionsTypes.Any(a => a.Name == "Transportation"));
            Assert.True(context.ActionsTypes.Any(a => a.Description == "Тhe price is for transport the cargo to the delivery address and is in euros"));
        }

        [Test]
        public async Task AllActionTypeNames_ShouldReturnAllActionTypeNames()
        {
            var result = await actionTypeService.AllActionTypeNamesAsync();

            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result.Contains("Rent"), Is.EqualTo(true));
            Assert.That(result.Contains("Sale"), Is.EqualTo(true));
            Assert.That(result.Contains("Transportation"), Is.EqualTo(false));
        }

        [Test]
        public async Task AllActionType_ShouldReturnListOfAllActionType()
        {
            var result = await actionTypeService.AllActionTypesAsync();

            Assert.That(result.Any(a => a.Name == "Rent" &&
                                        a.Id == 2), Is.EqualTo(true));

            Assert.That(result.Any(a => a.Name == "Sale" &&
                                        a.Id == 1), Is.EqualTo(true));

            Assert.That(result.Any(a => a.Description == "The amount is the purchase price of the goods and is in euros"), Is.EqualTo(true));

            Assert.That(result.Any(a => a.Description == "Тhe price is for one month of use and is in euros"), Is.EqualTo(true));
        }

        [OneTimeTearDown]
        public void TearDownDbContextInMemory()
        {
            context.Dispose();
        }

    }
}
