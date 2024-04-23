using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.ActionType;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Services
{
    public class ActionTypeService : IActionType
    {
        private readonly IRepository repository;

        public ActionTypeService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task CreateAction(CreateActionTypeViewModel model)
        {
            ActionType actionType = new ActionType()
            {
                Name = model.Name,
                Description = model.Description,
            };

            await repository.AddAsync(actionType);
            await repository.SaveChangesAsync();
        }
    }
}
