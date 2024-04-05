using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace EuropeanContracts.Core.Services
{
    public class TransportCompanyService : ITransportCompanyService
    {
        private readonly IRepository repository;
        public TransportCompanyService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(TransportCompany model)
        {
            await repository.AddAsync(model);
            await repository.SaveChangesAsync();
        }

        public async Task<AllTrailersViewModel> AllTrailersAsync(string isTemperatureControlNeeded,
                                                           int currentPage,
                                                           int trailersCountOnPage,
                                                           int transportCompanyId)
        {
            var trailers = await repository.AllReadOnly<Trailer>()
                .Where(t => t.TransportCompanyId == transportCompanyId)
                .ToListAsync();

            if (!string.IsNullOrEmpty(isTemperatureControlNeeded))
            {
                bool isNeeded = isTemperatureControlNeeded == "true" ? true : false;
                trailers = trailers
                    .Where(t => t.HasTemperatureControl == isNeeded)
                    .ToList();
            }

            var treilersResult = trailers
                .Skip((currentPage - 1) * trailersCountOnPage)
                .Take(trailersCountOnPage)
                .Select(t => new TrailerViewModel()
                {
                    Id = t.Id,
                    Make = t.Make,
                    TrailerImageURL = t.TrailerImageURL,
                    HasTemperatureControl = t.HasTemperatureControl,
                    TransportCompanyId = t.TransportCompanyId,
                })
                .ToList();
            var model = new AllTrailersViewModel()
            {
                Trailers = treilersResult,
                CurrentPage = currentPage,
                IsTemperatureControlNeeded = isTemperatureControlNeeded,
                TotalTrailersCount = trailers.Count()
            };
            return model;
        }

        public async Task<AllTrucksViewModel> AllTrucksAsync(string isTemperatureNeeded,
                                                            string hasCargoSpace,
                                                            int currentPage,
                                                            int truckCountOnPage,
                                                            int transportCompanyId)
        {
            var trucks = await repository.AllReadOnly<Truck>()
                .Where(t => t.TransportCompanyId == transportCompanyId)
                .ToListAsync();

            if (!string.IsNullOrEmpty(isTemperatureNeeded))
            {
                bool isNeeded = isTemperatureNeeded == "true" ? true : false;
                trucks = trucks
                    .Where(t => t.HasTemperatureControl == isNeeded)
                    .ToList();
            }
            if (!string.IsNullOrEmpty(hasCargoSpace))
            {
                bool hasSpace = hasCargoSpace == "true" ? true : false;
                trucks = trucks
                    .Where(t => t.HasCargoSpace == hasSpace)
                    .ToList();
            }

            var truckResult = trucks
                .Skip((currentPage - 1) * truckCountOnPage)
                .Take(truckCountOnPage)
                .Select(t => new TruckViewModel()
                {
                    Make = t.Make,
                    Model = t.Model,
                    HorsePower = t.HorsePower,
                    TruckImageURL = t.TruckImageURL,
                    HasCargoSpace = t.HasCargoSpace,
                    HasTemperatureControl = t.HasTemperatureControl,
                    TransportCompanyId = t.TransportCompanyId,
                })
                .ToList();
            var model = new AllTrucksViewModel()
            {
                Trucks = truckResult,
                CurrentPage = currentPage,
                IsTemperatureControlNeeded = isTemperatureNeeded,
                TotalTruckCount = trucks.Count()
            };
            return model;
        }

        public async Task<bool> IsTransporterExistFindByIdAsync(string userId)
        {
            return await repository.AllReadOnly<TransportCompany>()
                .AnyAsync(t => t.OwnerId == userId);
        }

        public async Task<TransportCompany> ReturnTransporterByUserIdAsync(string userId)
        {
            return await repository.AllReadOnly<TransportCompany>()
                .Where(t => t.OwnerId == userId)
                .FirstAsync();
        }

        public async Task<bool> IsTransporterExistsAsync(string country, string name)
        {
            return await repository.AllReadOnly<TransportCompany>()
                .AnyAsync(s => s.Country == country && s.Name == name);
        }

        public async Task<string> ReturnTransporterNameAsync(string userId)
        {
            var transporter = await repository.AllReadOnly<TransportCompany>()
                .FirstAsync(t => t.OwnerId == userId);

            return transporter.Name;
        }

        public async Task<OffersAndCountTransporterViewModel> AllOffersAsync(string isContract,
                                                                       int currentPage,
                                                                       int offersCountOnPage,
                                                                       string userId)
        {
            var currentTransporter = await repository.AllReadOnly<TransportCompany>()
                .Where(t=>t.OwnerId == userId)
                .FirstAsync();

            var offers = await repository.AllReadOnly<Offer>()
               .Include(a => a.ActionType)
               .Where(o=>o.TransporterId == currentTransporter.Id)
               .ToListAsync();

            if (!string.IsNullOrEmpty(isContract))
            {
                bool result = isContract == "true" ? true : false;

                offers = offers
                    .Where(o => o.IsContract == result)
                    .ToList();
            }

            var offerResult = offers
                .Skip((currentPage - 1) * offersCountOnPage)
                .Take(offersCountOnPage)
                .Select(o => new OfferTranspoerterViewModel()
                {
                    Id = o.Id,
                    ProductName = o.ProductName,
                    ProductImageURL = o.ProductImageURL,
                    ProductQuantity = o.ProductQuantity,
                    ProductPrice = o.ProductPrice,
                    LoadingAddress = o.LoadingAddress,
                    LoadingCountry = o.LoadingCountry,
                    IsTemperatureControlNeeded = o.IsTemperatureControlNeeded,
                    PublicationDay = o.PublicationDay,
                    ActionType = o.ActionType.Name,
                    SupplierId = o.SupplierId,
                    IsContract = o.IsContract,
                })
                .ToList();

            return new OffersAndCountTransporterViewModel()
            {
                OfferViewModels = offerResult,
                AllOffersCount = offers.Count()
            };
        }
    }
}
