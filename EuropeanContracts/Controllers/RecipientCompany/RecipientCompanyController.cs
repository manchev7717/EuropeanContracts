using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Core.Services;
using EuropeanContracts.Core.ServiceViewModels.Recipient;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Extentions;
using EuropeanContracts.Infrastructure.Data.Models;
using EuropeanContracts.TempDataMessages;
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

            TempData["message"] = TempDataMessageConstance.CreateNewRecepientCompany;
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> MyOffers([FromQuery] AllOffersForRecipientViewModel model)
        {
            var result = await recipientCompanyService.AllOffersAsync(
                            model.IsContract,
                            model.CurrentPage,
                            AllOffersForRecipientViewModel.OffersCountOnPage,
                            User.Id());

            model.Offers = result.OfferViewModels;
            model.TotalOffersCount = result.AllOffersCount;

            return View(model);
        }
    }
}
