using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Extentions;
using EuropeanContracts.Infrastructure.Data.Models;
using EuropeanContracts.TempDataMessages;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Controllers
{
    public class TransportCompanyController : BaseController
    {
        private readonly ITransportCompanyService transportCompanyService;
        private readonly IOfferService offerService;
        private readonly ITrailerService trailerService;
        private readonly ITruckService truckService;

        public TransportCompanyController(ITransportCompanyService transportCompanyService,
                                            IOfferService offerService,
                                            ITrailerService trailerService,
                                            ITruckService truckService)
        {
            this.transportCompanyService = transportCompanyService;
            this.offerService = offerService;
            this.trailerService = trailerService;
            this.truckService = truckService;
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddTransportCompanyModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddTransportCompanyModel model)
        {
            if (await transportCompanyService.IsTransporterExistsAsync(model.Country, model.Name))
            {
                ModelState.AddModelError("Country", ModelsErrorMessages.CompanyExistsError);
                return View(model);
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var transporterToAdd = new TransportCompany()
            {
                Name = model.Name,
                Country = model.Country,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                OwnerId = User.Id()
            };

            await transportCompanyService.AddAsync(transporterToAdd);

            TempData["message"] = TempDataMessageConstance.CreateNewTransportCompany;
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> MyOffers([FromQuery]AllOffersForTransporterViewModel model)
        {
            var result = await offerService.AllOffersForTransporterAsync(
                            model.IsContract,
                            model.CurrentPage,
                            AllOffersForTransporterViewModel.OffersCountOnPage,
                            User.Id());

            model.Offers = result.OfferViewModels;
            model.TotalOffersCount = result.AllOffersCount;

           return View(model);
        }

        [HttpGet]

        public async Task<IActionResult> AllTrucks([FromQuery]AllTrucksViewModel model)
        {
            var transportCompany = await transportCompanyService.ReturnTransporterByUserIdAsync(User.Id());
                
            var resultFromSearching = await truckService.AllTrucksAsync(model.IsTemperatureControlNeeded,
                                                                            model.HasCargoSpace,
                                                                            model.CurrentPage,
                                                                            AllTrucksViewModel.TruckCountOnPage,
                                                                            transportCompany.Id);

            return View(resultFromSearching);
        }

        [HttpGet]

        public async Task<IActionResult> AllTrailers([FromQuery]AllTrailersViewModel model)
        {
            var transportCompany = await transportCompanyService.ReturnTransporterByUserIdAsync(User.Id());

            var resultFromSearching = await trailerService.AllTrailersAsync(model.IsTemperatureControlNeeded,
                                                                            model.CurrentPage,
                                                                            AllTrailersViewModel.TrailersCountOnPage,
                                                                            transportCompany.Id);

            return View(resultFromSearching);
        }
    }
}
