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
        private readonly IOfferService offerService;

        public RecipientCompanyController(IRecipientCompanyService recipientCompanyService,
                                          IOfferService offerService)
        {
            this.recipientCompanyService = recipientCompanyService;
            this.offerService = offerService;

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
            if (await recipientCompanyService.DoesRecipientExists(model.Country, model.Name))
            {
                ModelState.AddModelError("Country", ModelsErrorMessages.CompanyExistsError);
                return View(model);
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await recipientCompanyService.AddAsync(model);

            TempData["message"] = TempDataMessageConstance.CreateNewRecepientCompany;
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> MyOffers([FromQuery] AllOffersForRecipientViewModel model)
        {
            var result = await offerService.AllOffersForRecipientAsync(
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
