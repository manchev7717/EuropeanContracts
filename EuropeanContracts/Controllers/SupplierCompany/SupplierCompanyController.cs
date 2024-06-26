﻿using EuropeanContracts.Controllers.Base;
using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ErrorMessageAndConstance;
using EuropeanContracts.Core.ServiceViewModels.Supplier;
using EuropeanContracts.Extentions;
using EuropeanContracts.Infrastructure.Data.Models;
using EuropeanContracts.TempDataMessages;
using Microsoft.AspNetCore.Mvc;

namespace EuropeanContracts.Controllers
{
    public class SupplierCompanyController : BaseController
    {
        private readonly ISupplierCompanyService supplierCompanyService;
        private readonly IOfferService offerService;

        public SupplierCompanyController(ISupplierCompanyService supplierCompanyService,
                                         IOfferService offerService)
        {
            this.supplierCompanyService = supplierCompanyService;
            this.offerService = offerService;
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
            if (await supplierCompanyService.DoesSupplierExists(model.Country,model.Name))
            {
                ModelState.AddModelError("Country", ModelsErrorMessages.CompanyExistsError);
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

            TempData["message"] = TempDataMessageConstance.CreateNewSupplierCompany;
            return RedirectToAction("Index","Home"); 
        }

        [HttpGet]
        public async Task<IActionResult> MyOffers([FromQuery] SupplierAllOffersViewModel model)
        {
            var supplierId =await supplierCompanyService.ReturnSupplierIdByUserId(User.Id());
            var result = await offerService.AllOffersForSupplierAsync(model.CurrentPage,
                                                                     SupplierAllOffersViewModel.OffersCountOnPage,
                                                                     model.IsContract,
                                                                     supplierId);
            model.Offers = result.OfferViewModels;
            model.TotalOffersCount = result.AllOffersCount;

            return View(model);
        }
    }
}
