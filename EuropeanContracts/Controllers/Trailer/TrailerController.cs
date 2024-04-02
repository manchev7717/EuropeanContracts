using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Trailer;
using EuropeanContracts.Extentions;
using EuropeanContracts.Infrastructure.Data.Models;
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
            if (!await transportCompanyService.IsTransporterExistFindByIdAsync(User.Id()))
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

            return RedirectToAction("AllTrailers", "TransportCompany");
        }
    }
}
