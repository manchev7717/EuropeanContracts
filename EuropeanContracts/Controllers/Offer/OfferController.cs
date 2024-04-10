using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Offer;
using EuropeanContracts.Extentions;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Controllers.Offer
{
    public class OfferController : BaseController
    {
        private readonly IOfferService offerService;
        private readonly ISupplierCompanyService supplierCompanyService;

        public OfferController(IOfferService offerService, ISupplierCompanyService supplierCompanyService)
        {
            this.offerService = offerService;
            this.supplierCompanyService = supplierCompanyService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery]AllOfferViewModel model)
        {
            var result = await offerService.AllAsync(
                            model.ActionType,
                            model.Country,
                            model.IsTemperatureControlNeeded,
                            model.CurrentPage,
                            AllOfferViewModel.OffersCountOnPage);

            model.Offers = result.OfferViewModels;
            model.TotalOffersCount = result.AllOffersCount;
            model.CountriesOfOrigin = await offerService.AllCountryNamesAsync();
            model.Actions = await offerService.AllActionTypesAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new CreateOfferViewModel();

            model.ActionTypes = await offerService.ActionTypesAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateOfferViewModel model)
        {
            var userId = User.Id();

            if (await supplierCompanyService.FindSupplierByIdAsync(userId) == false)
            {
                return Unauthorized();
            }

            if (ModelState.IsValid == false)
            {
                model.ActionTypes = await offerService.ActionTypesAsync();
                return View(model);
            }


            var supplierId = await supplierCompanyService.ReturnSupplierIdByUserId(userId); 
            model.SupplierId = supplierId;
            await offerService.CreateOfferAsync(model);

            return RedirectToAction("MyOffers", "SupplierCompany");
        }
    }
}
