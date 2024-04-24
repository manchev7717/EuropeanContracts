using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.Services;
using EuropeanContracts.Core.ServiceViewModels.ActionType;
using EuropeanContracts.Data;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Tests.Tets
{
    [TestFixture]
    public class ActionTypeService
    {
        private IEnumerable<ActionType> actionTypes;
        private EuropeanContractsDbContext context;
        private IRepository repository;


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

            var optionsDb = new DbContextOptionsBuilder<EuropeanContractsDbContext>()
                .UseInMemoryDatabase("ActionTypesDb")
                .Options;
            this.context = new EuropeanContractsDbContext(optionsDb);
            this.context.AddRange(actionTypes);
            this.context.SaveChanges();

            repository = new Repository(this.context);

        }

        [Test]
        public void CreateAction_ShouldCreateActionTypeCorectly()
        {
            var actionToCreate = new CreateActionTypeViewModel()
                                 {
                                     Name = "Transportation",
                                     Description = "Тhe price is for transport the cargo to the delivery address and is in euros"
                                 };



            IActionTypeService service = new Core.Services.ActionTypeService(repository);
            service.CreateAction(actionToCreate);

            Assert.True(context.ActionsTypes.Count() == 3);
            Assert.True(context.ActionsTypes.Any(a=>a.Id == 3));
            Assert.True(context.ActionsTypes.Any(a=>a.Name == "Transportation"));
            Assert.True(context.ActionsTypes.Any(a => a.Description == "Тhe price is for transport the cargo to the delivery address and is in euros"));
        }

    }
}
