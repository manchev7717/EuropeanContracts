using EuropeanContracts.Core.ServiceViewModels.ActionType;

namespace EuropeanContracts.Core.Contracts
{
    public interface IActionType
    {
        Task CreateAction(CreateActionTypeViewModel model);
    }
}
