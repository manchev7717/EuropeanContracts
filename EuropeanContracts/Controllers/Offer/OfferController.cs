using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Core.ServiceViewModels.Offer;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Extentions;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Controllers.Offer
{
    public class OfferController : BaseController
    {
        private readonly IOfferService offerService;
        private readonly ISupplierCompanyService supplierCompanyService;
        private readonly ITruckService truckService;
        private readonly ITrailerService trailerService;
        private readonly ITransportCompanyService transporterService;
        private readonly IRecipientCompanyService recipientService;

        public OfferController(IOfferService offerService,
            ISupplierCompanyService supplierCompanyService,
            ITruckService truckService,
            ITrailerService trailerService,
            ITransportCompanyService transporterService,
            IRecipientCompanyService recipientService)
        {
            this.offerService = offerService;
            this.supplierCompanyService = supplierCompanyService;
            this.truckService = truckService;
            this.trailerService = trailerService;
            this.transporterService = transporterService;
            this.recipientService = recipientService;

        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllOfferViewModel model)
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

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {

            var model = await offerService.DetailsOfferAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddTransporter(bool isTemperatureRequired, int offerId)
        {
            var transporter = await transporterService.ReturnTransporterByUserIdAsync(User.Id());

            var model = new AddTransportCompanyInOfferViewModel();

            model.OfferId = offerId;
            model.IsTemperatureRequired = isTemperatureRequired;
            model.TransporterId = transporter.Id;
            model.Trucks = await truckService.GetTruckForOffer(model.TransporterId);
            model.Trailers = await trailerService.GetTrailerForOffer(isTemperatureRequired, model.TransporterId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddTransporter(AddTransportCompanyInOfferViewModel model)
        {
            var transporter = await transporterService.ReturnTransporterByUserIdAsync(User.Id());
            var hasTruckTemperaturControl = await truckService.HasTruckTemperaturControl(model.TruckId);
            model.TransporterId = transporter.Id;

            if (model.IsTemperatureRequired && model.TrailerId == null && hasTruckTemperaturControl == false)
            {
                ModelState.AddModelError(nameof(model.TruckId), ModelsErrorMessages.TruckHasNoTemperatureControl);
                model.Trucks = await truckService.GetTruckForOffer(model.TransporterId);
                model.Trailers = await trailerService.GetTrailerForOffer(model.IsTemperatureRequired, model.TransporterId);
                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                return View(AddTransporter(model.IsTemperatureRequired, model.OfferId));
            }


            await offerService.AddTransporterInOfferAsync(model);


            return RedirectToAction("MyOffers", "TransportCompany");
        }

        [HttpGet]
        public async Task<IActionResult> AddRecipient(bool isTemperatureRequired, int offerId)
        {
            var transporter = await recipientService.ReturnRecipientByUserIdAsync(User.Id());

            var model = new AddRecipientCompanyInOfferViewModel();

            model.OfferId = offerId;
            model.IsTemperatureRequired = isTemperatureRequired;
            model.TransporterId = transporter.Id;
            model.Trucks = await truckService.GetTruckForOffer(model.TransporterId);
            model.Trailers = await trailerService.GetTrailerForOffer(isTemperatureRequired, model.TransporterId);

            return View(model);
        }
    }
}
