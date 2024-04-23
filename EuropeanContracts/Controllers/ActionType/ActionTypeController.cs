using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.ActionType;
using EuropeanContracts.Extentions;
using EuropeanContracts.TempDataMessages;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Controllers.ActionType
{
    public class ActionTypeController : BaseController
    {
        private readonly IActionType actionType;
        private readonly ISupplierCompanyService supplierCompanyService;
        public ActionTypeController(IActionType actionType,
                                    ISupplierCompanyService supplierCompanyService)
        {
            this.actionType = actionType;
            this.supplierCompanyService = supplierCompanyService;

        }
        [HttpGet]
        public IActionResult Add()
        {
            var model = new CreateActionTypeViewModel();

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Add(CreateActionTypeViewModel model)
        {
            if (await supplierCompanyService.FindSupplierByIdAsync(User.Id()) == false)
            {
                return Unauthorized();
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await actionType.CreateAction(model);
            TempData["message"] = TempDataMessageConstance.CreateNewActionType;
            return RedirectToAction("MyOffers", "SupplierCompany");
        }
    }
}
