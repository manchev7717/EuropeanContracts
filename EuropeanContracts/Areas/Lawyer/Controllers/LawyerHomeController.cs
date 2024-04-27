using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Offer;
using EuropeanContracts.TempDataMessages;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Areas.Lawyer.Controllers
{

    public class LawyerHomeController : LawyerBaseController
    {
        private readonly IOfferService offerService;
        public LawyerHomeController(IOfferService offerService)
        {
            this.offerService = offerService;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> OffersForValidation([FromQuery] LawyerAllViewModel model)
        {
            var result = await offerService.AllAsync(
                            model.CurrentPage,
                            AllOfferViewModel.OffersCountOnPage);

            model.Offers = result.OfferViewModels;
            model.TotalOffersCount = result.AllOffersCount;

            return View(model);
        }

        [HttpGet]

        public async Task<IActionResult> DetailsForOffer(int id)
        {
            if (!await offerService.DoesOfferExistById(id))
            {
                return RedirectToAction("Error", "Home", "500");
            }

            var model = await offerService.DetailsOfferAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> OfferIsValid(int offerId)
        {
            await offerService.MakeOfferInContract(offerId);

            TempData["message"] = TempDataMessageConstance.LawyerSuccessfullyValidateContract;

            return RedirectToAction("Index");
        }
    }
}
