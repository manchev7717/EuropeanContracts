using EuropeanContracts.Core.ServiceViewModels.ActionType;

namespace EuropeanContracts.Core.Contracts
{
    public interface IActionTypeService
    {
        Task CreateAction(CreateActionTypeViewModel model);
    }
}
