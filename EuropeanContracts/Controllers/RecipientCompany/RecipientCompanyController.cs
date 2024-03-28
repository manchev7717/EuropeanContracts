using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Core.ServiceViewModels.Recipient;
using EuropeanContracts.Extentions;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Controllers
{
    public class RecipientCompanyController : BaseController
    {
        private readonly IRecipientCompanyService recipientCompanyService;

        public RecipientCompanyController(IRecipientCompanyService recipientCompanyService)
        {
            this.recipientCompanyService = recipientCompanyService;
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddRecipientCompanyModel();

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddRecipientCompanyModel model)
        {
            if (await recipientCompanyService.IsRecipientExists(model.Country, model.Name))
            {
                ModelState.AddModelError("Country", ModelsErrorMessages.CompanyExistsError);
                return View(model);
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var recipientToAdd = new RecipientCompany()
            {
                Name = model.Name,
                Country = model.Country,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                OwnerId = User.Id()
            };

            await recipientCompanyService.AddAsync(recipientToAdd);

            return RedirectToAction("Index", "Home");
        }
    }
}
