using EuropeanContracts.Core.ServiceViewModels.ActionType;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface IActionTypeService
    {
        Task CreateAction(CreateActionTypeViewModel model);

        Task<IEnumerable<string>> AllActionTypeNamesAsync();

        Task<IEnumerable<ActionType>> AllActionTypesAsync();
    }
}
