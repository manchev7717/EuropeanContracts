﻿using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Extentions;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Controllers
{
    public class TransportCompanyController : BaseController
    {
        private readonly ITransportCompanyService transportCompanyService;

        public TransportCompanyController(ITransportCompanyService transportCompanyService)
        {
            this.transportCompanyService = transportCompanyService;
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

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]

        public async Task<IActionResult> AllOffers()
        {

            return View();
        }

        [HttpGet]

        public async Task<IActionResult> AllTrucks([FromQuery]AllTrucksViewModel model)
        {
            var transportCompany = await transportCompanyService.FindTransporterByUserIdAsync(User.Id());
                
            var resultFromSearching = await transportCompanyService.AllTruckAsync(model.IsTemperatureControlNeeded,
                                                                            model.CurrentPage,
                                                                            AllTrucksViewModel.TruckCountOnPage,
                                                                            transportCompany.Id);

            return View(resultFromSearching);
        }

        [HttpGet]

        public async Task<IActionResult> AllTrailers()
        {
            return View();
        }
    }
}
