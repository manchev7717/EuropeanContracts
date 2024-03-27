using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Core.ServiceViewModels.SupplierCompany;
using EuropeanContracts.Extentions;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Controllers.Supplier
{
    public class SupplierCompanyController : BaseController
    {
        private readonly ISupplierCompanyService supplierCompanyService;

        public SupplierCompanyController(ISupplierCompanyService supplierCompanyService)
        {
            this.supplierCompanyService = supplierCompanyService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddSupplierCompanyModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddSupplierCompanyModel model)
        {
            if (await supplierCompanyService.IsSupplierExists(model.Country,model.Name))
            {
                ModelState.AddModelError("", ModelsErrorMessages.SupplierExistsError);
                return View(model);
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var supplierToAdd = new SupplierCompany()
            {
                Name = model.Name,
                Country = model.Country,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                OwnerId = User.Id()
            };

            await supplierCompanyService.AddAsync(supplierToAdd);

            return View(model); 
        }
    }
}
