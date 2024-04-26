using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.ActionType;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Core.Services
{
    public class ActionTypeService : IActionTypeService
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

        public async Task<IEnumerable<string>> AllActionTypeNamesAsync()
        {
            return await repository.AllReadOnly<ActionType>()
                .Select(a => a.Name)
                .ToListAsync();
        }

        public async Task<IEnumerable<ActionType>> AllActionTypesAsync()
        {
            var result = await repository.AllReadOnly<ActionType>()
                .ToListAsync();

            return result;
        }
    }
}
