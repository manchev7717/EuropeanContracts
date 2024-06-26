﻿using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Truck;
using EuropeanContracts.Extentions;
using EuropeanContracts.Infrastructure.Data.Models;
using EuropeanContracts.TempDataMessages;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Controllers
{
    public class TruckController : BaseController
    {
        private readonly ITruckService truckService;
        private readonly ITransportCompanyService transportCompanyService;
        public TruckController(ITruckService truckService,
                               ITransportCompanyService transportCompanyService)
        {
            this.truckService = truckService;
            this.transportCompanyService = transportCompanyService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddTruckViewModel();

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddTruckViewModel truckModel)
        {
            if (!await transportCompanyService.DoesTransporterExistsAsync(User.Id()))
            {
                return BadRequest();
            }
           
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var transportCompany = await transportCompanyService.ReturnTransporterByUserIdAsync(User.Id());

            var model = new AutoTruck()
            {
                Make = truckModel.Make,
                Model = truckModel.Model,
                HorsePower = truckModel.HorsePower,
                TruckImageURL = truckModel.TruckImageURL,
                HasCargoSpace = truckModel.HasCargoSpace,
                HasTemperatureControl = truckModel.HasTemperatureControl,
                TransportCompanyId = transportCompany.Id,
                RegistrationNumber = truckModel.RegistrationNumber
            };

            await truckService.AddTruckAsync(model);

            TempData["message"] = TempDataMessageConstance.CreateNewTruck;
            return RedirectToAction("AllTrucks", "TransportCompany");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (await truckService.ExistByIdAsync(id) == false)
            {
                return BadRequest();
            }
           
            if (await transportCompanyService.DoesTransporterExistsAsync(User.Id()) == false)
            {
                return Unauthorized();
            }

            var truckModel = await truckService.ReturnEditTruckViewModelByIdAsync(id);

            return View(truckModel);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(EditAndDeleteTruckViewModel truckModel)
        {
            if (await truckService.ExistByIdAsync(truckModel.Id) == false)
            {
                return BadRequest();
            }

            if (await transportCompanyService.DoesTransporterExistsAsync(User.Id()) == false)
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                return View(truckModel);
            }

            await truckService.EditAsync(truckModel);

            TempData["message"] = TempDataMessageConstance.EditTruck;
            return RedirectToAction("AllTrucks", "TransportCompany");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (await truckService.ExistByIdAsync(id) == false)
            {
                return BadRequest();
            }

            if (await transportCompanyService.DoesTransporterExistsAsync(User.Id()) == false)
            {
                return Unauthorized();
            }

            var truckModel = await truckService.ReturnEditTruckViewModelByIdAsync(id);

            return View(truckModel);
        }
        [HttpPost]

        public async Task<IActionResult> Delete(EditAndDeleteTruckViewModel truckModel)
        {
            if (await truckService.ExistByIdAsync(truckModel.Id) == false)
            {
                return BadRequest();
            }

            if (await transportCompanyService.DoesTransporterExistsAsync(User.Id()) == false)
            {
                return Unauthorized();
            }

            await truckService.DeleteAsync(truckModel.Id);

            TempData["message"] = TempDataMessageConstance.DeleteTruck;
            return RedirectToAction("AllTrucks", "TransportCompany");
        }

    }
}
