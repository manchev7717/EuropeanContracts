using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Truck;
using EuropeanContracts.Extentions;
using EuropeanContracts.Infrastructure.Data.Models;
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
            if (!await transportCompanyService.IsTransporterExistFindByIdAsync(User.Id()))
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var transportCompany = await transportCompanyService.ReturnTransporterByUserIdAsync(User.Id());

            var model = new Truck()
            {
                Make = truckModel.Make,
                Model = truckModel.Model,
                HorsePower = truckModel.HorsePower,
                TruckImageURL = truckModel.TruckImageURL,
                HasCargoSpace = truckModel.HasCargoSpace,
                HasTemperatureControl = truckModel.HasTemperatureControl,
                TransportCompanyId = transportCompany.Id,
            };

             await truckService.AddTruckAsync(model);

            return RedirectToAction("AllTrucks", "TransportCompany");
        }
    }
}
