﻿using EuropeanContracts.Core.ServiceViewModels.Supplier;
using EuropeanContracts.Infrastructure.Data.Models;

namespace EuropeanContracts.Core.Contracts
{
    public interface ISupplierCompanyService
    {
        Task<bool> IsSupplierExists(string country,string name);

        Task AddAsync(SupplierCompany model);

        Task<bool> FindSupplierByIdAsync(string userId);

        Task<string> ReturnSupplierName(string name);
        Task<int> ReturnSupplierIdByUserId(string userId);

        Task<SupplierOffersAndCountViewModel> AllOffersAsync(int currentPage,
                            int offersCountOnPage,
                            string isContract,
                            int supplierId);
    }
}
