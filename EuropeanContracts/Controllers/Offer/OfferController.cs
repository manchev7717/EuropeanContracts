﻿using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Core.Extensions;
using EuropeanContracts.Core.ServiceViewModels.Offer;
using EuropeanContracts.Core.ServiceViewModels.Recipient;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Extentions;
using EuropeanContracts.TempDataMessages;
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
        private readonly IActionTypeService actionTypeService;

        public OfferController(IOfferService offerService,
            ISupplierCompanyService supplierCompanyService,
            ITruckService truckService,
            ITrailerService trailerService,
            ITransportCompanyService transporterService,
            IRecipientCompanyService recipientService,
            IActionTypeService actionTypeService)
        {
            this.offerService = offerService;
            this.supplierCompanyService = supplierCompanyService;
            this.truckService = truckService;
            this.trailerService = trailerService;
            this.transporterService = transporterService;
            this.recipientService = recipientService;
            this.actionTypeService = actionTypeService;

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
            model.CountriesOfOrigin = await offerService.AllLoadingCountryNamesAsync();
            model.Actions = await actionTypeService.AllActionTypeNamesAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new CreateOfferViewModel();

            model.ActionTypes = await actionTypeService.AllActionTypesAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateOfferViewModel model)
        {
            var userId = User.Id();

            if (await supplierCompanyService.DoesSupplierExists(userId) == false)
            {
                return Unauthorized();
            }

            if (ModelState.IsValid == false)
            {
                model.ActionTypes = await actionTypeService.AllActionTypesAsync();
                return View(model);
            }


            var supplierId = await supplierCompanyService.ReturnSupplierIdByUserId(userId);
            model.SupplierId = supplierId;
            await offerService.CreateOfferAsync(model);

            TempData["message"] = TempDataMessageConstance.CreateNewOffer;
            return RedirectToAction("MyOffers", "SupplierCompany");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id, string searchingInfo)
        {
            if (!await offerService.DoesOfferExistById(id))
            {
                return RedirectToAction("Error", "Home", "500");
            }

            var model = await offerService.DetailsOfferAsync(id);

            if (model.OfferViewModel.GetSearchingInfo() != searchingInfo)
            {
                return BadRequest();
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddTransporter(bool isTemperatureRequired, int offerId)
        {
            var transporter = await transporterService.ReturnTransporterByUserIdAsync(User.Id());

            if (transporter == null)
            {
                return BadRequest();
            }

            var model = new AddTransportCompanyInOfferViewModel();

            model.OfferId = offerId;
            model.IsTemperatureRequired = isTemperatureRequired;
            model.TransporterId = transporter.Id;
            model.Trucks = await truckService.GetTruckForOfferAsync(model.TransporterId);
            model.Trailers = await trailerService.GetTrailerForOfferAsync(isTemperatureRequired, model.TransporterId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddTransporter(AddTransportCompanyInOfferViewModel model)
        {
            var transporter = await transporterService.ReturnTransporterByUserIdAsync(User.Id());
            if (transporter == null)
            {
                return BadRequest();
            }
            var hasTruckTemperaturControl = await truckService.HasTruckTemperaturControlAsync(model.TruckId);
            model.TransporterId = transporter.Id;

            if (model.IsTemperatureRequired && model.TrailerId == null && hasTruckTemperaturControl == false)
            {
                ModelState.AddModelError(nameof(model.TruckId), ModelsErrorMessages.TruckHasNoTemperatureControl);
                model.Trucks = await truckService.GetTruckForOfferAsync(model.TransporterId);
                model.Trailers = await trailerService.GetTrailerForOfferAsync(model.IsTemperatureRequired, model.TransporterId);
                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                return View(AddTransporter(model.IsTemperatureRequired, model.OfferId));
            }


            await offerService.AddTransporterInOfferAsync(model);

            TempData["message"] = TempDataMessageConstance.AddTransporterInOffer;
            return RedirectToAction("MyOffers", "TransportCompany");
        }

        [HttpGet]
        public async Task<IActionResult> AddRecipient(int offerId)
        {
            var recipient = await recipientService.ReturnRecipientByUserIdAsync(User.Id());

            var model = new AddRecipientCompanyInOfferViewModel();
            model.RecipientId = recipient.Id;
            model.OfferId = offerId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddRecipient(AddRecipientCompanyInOfferViewModel model)
        {
            var recipient = await recipientService.ReturnRecipientByUserIdAsync(User.Id());
            model.RecipientId = recipient.Id;


            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await offerService.AddRecipientInOfferAsync(model);

            TempData["message"] = TempDataMessageConstance.AddRecepientInOffer;
            return RedirectToAction("MyOffers", "RecipientCompany");


        }
    }
}
