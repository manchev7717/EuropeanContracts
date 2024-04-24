using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.Services;
using EuropeanContracts.Core.ServiceViewModels.Trailer;
using EuropeanContracts.Core.ServiceViewModels.Truck;
using EuropeanContracts.Extentions;
using EuropeanContracts.Infrastructure.Data.Models;
using EuropeanContracts.TempDataMessages;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Controllers
{
    public class TrailerController : BaseController
    {
        private readonly ITrailerService trailerService;
        private readonly ITransportCompanyService transportCompanyService;

        public TrailerController(ITrailerService trailerService,
            ITransportCompanyService transportCompanyService)
        {
            this.trailerService = trailerService;
            this.transportCompanyService = transportCompanyService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddTrailerViewModel();
            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddTrailerViewModel trailerModel)
        {
            if (!await transportCompanyService.IsTransporterExistFindByUserIdAsync(User.Id()))
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var transportCompany = await transportCompanyService.ReturnTransporterByUserIdAsync(User.Id());

            var model = new Trailer()
            {
                Make = trailerModel.Make,
                TrailerImageURL = trailerModel.TrailerImageURL,
                HasTemperatureControl = trailerModel.HasTemperatureControl,
                TransportCompanyId = transportCompany.Id,
            };

            await trailerService.AddTruckAsync(model);

            TempData["message"] = TempDataMessageConstance.CreateNewTrailer;
            return RedirectToAction("AllTrailers", "TransportCompany");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (await trailerService.ExistByIdAsync(id) == false)
            {
                return BadRequest();
            }

            if (await transportCompanyService.UserIsTransportCompanyOwnerByIdAsync(User.Id()) == false)
            {
                return Unauthorized();
            }

            var trailerModel = await trailerService.ReturnEditTrailerViewModelByIdAsync(id);

            return View(trailerModel);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(EditAndDeleteTrailerViewModel trailerModel)
        {
            if (await trailerService.ExistByIdAsync(trailerModel.Id) == false)
            {
                return BadRequest();
            }

            if (await transportCompanyService.UserIsTransportCompanyOwnerByIdAsync(User.Id()) == false)
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                return View(trailerModel);
            }

            await trailerService.EditAsync(trailerModel);

            // it is good to redirect to Details of the current truck, not in page with all trucks!!!!!!!!!!

            //return RedirectToAction(nameof(Details), new { truckModel.Id });

            TempData["message"] = TempDataMessageConstance.EditTrailer;
            return RedirectToAction("AllTrailers", "TransportCompany");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (await trailerService.ExistByIdAsync(id) == false)
            {
                return BadRequest();
            }

            if (await transportCompanyService.UserIsTransportCompanyOwnerByIdAsync(User.Id()) == false)
            {
                return Unauthorized();
            }

            var truckModel = await trailerService.ReturnEditTrailerViewModelByIdAsync(id);

            return View(truckModel);
        }
        [HttpPost]

        public async Task<IActionResult> Delete(EditAndDeleteTrailerViewModel trailerModel)
        {
            if (await trailerService.ExistByIdAsync(trailerModel.Id) == false)
            {
                return BadRequest();
            }

            if (await transportCompanyService.UserIsTransportCompanyOwnerByIdAsync(User.Id()) == false)
            {
                return Unauthorized();
            }

            await trailerService.DeleteAsync(trailerModel.Id);

            TempData["message"] = TempDataMessageConstance.DeleteTrailer;
            return RedirectToAction("AllTrailers", "TransportCompany");
        }
    }
}
