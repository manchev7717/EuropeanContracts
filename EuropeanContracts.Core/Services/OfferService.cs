using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Offer;
using EuropeanContracts.Core.ServiceViewModels.Recipient;
using EuropeanContracts.Core.ServiceViewModels.Supplier;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Core.Services
{
    public class OfferService : IOfferService
    {
        private readonly IRepository repository;
        public OfferService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task CreateOfferAsync(CreateOfferViewModel model)
        {
            Offer newOffer = new Offer()
            {
                ProductName = model.ProductName,
                ProductDescription = model.ProductDescription,
                ProductQuantity = model.ProductQuantity,
                ProductPrice = model.ProductPrice,
                ProductImageURL = model.ProductImageURL,
                LoadingCountry = model.LoadingCountry,
                LoadingAddress = model.LoadingAddress,
                CountryOfDestination = model.CountryOfDestination,
                IsTemperatureControlNeeded = model.IsTemperatureControlNeeded,
                PublicationDay = model.PublicationDay,
                SupplierId = model.SupplierId,
                ActionTypeId = model.ActionTypeId,

            };
            await repository.AddAsync(newOffer);
            await repository.SaveChangesAsync();
        }


        public async Task<bool> DoesOfferExistById(int offerId)
        {
            return await repository.AllReadOnly<Offer>()
                .AnyAsync(o => o.Id == offerId);
        }

        public async Task<IEnumerable<string>> AllLoadingCountryNamesAsync()
        {
            return await repository.AllReadOnly<Offer>()
                .Select(a => a.LoadingCountry)
                .ToListAsync();
        }

        public async Task<OffersAndCountViewModel> AllAsync(string? actionType,
                                                            string? country,
                                                            string? isTemperatureControlNeeded,
                                                            int currentPage,
                                                            int offersCountOnPage)
        {


            var offers = await repository.AllReadOnly<Offer>()
                .Where(o => o.IsContract == false)
                .Include(a => a.ActionType)
                .Include(a => a.Supplier)
                .ToListAsync();

            if (actionType != null)
            {
                offers = offers
                    .Where(o => o.ActionType.Name == actionType)
                    .ToList();
            }
            if (country != null)
            {
                offers = offers
                    .Where(o => o.LoadingCountry == country)
                    .ToList();
            }
            if (isTemperatureControlNeeded != null)
            {
                bool result = isTemperatureControlNeeded == "true" ? true : false;

                offers = offers
                    .Where(o => o.IsTemperatureControlNeeded == result)
                    .ToList();
            }

            var offerResult = offers
                .Skip((currentPage - 1) * offersCountOnPage)
                .Take(offersCountOnPage)
                .Select(o => new OfferDetailViewModel()
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
                    CreatorName = o.Supplier.Name + "/" + o.Supplier.Country,
                    CreatorPhoneNumber = o.Supplier.PhoneNumber,
                    ActionDescription = o.ActionType.Description

                })
                .ToList();

            return new OffersAndCountViewModel()
            {
                OfferViewModels = offerResult,
                AllOffersCount = offers.Count()
            };
        }
        public async Task<OffersAndCountTransporterViewModel> AllOffersForTransporterAsync(string isContract,
                                                                                           int currentPage,
                                                                                           int offersCountOnPage,
                                                                                           string userId)
        {
            var currentTransporter = await repository.AllReadOnly<TransportCompany>()
                .Where(t => t.OwnerId == userId)
                .FirstAsync();

            var offers = await repository.AllReadOnly<Offer>()
               .Include(a => a.ActionType)
               .Where(o => o.TransporterId == currentTransporter.Id)
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

        public async Task<SupplierOffersAndCountViewModel> AllOffersForSupplierAsync(int currentPage,
                                                                                     int offersCountOnPage,
                                                                                     string isContract,
                                                                                     int supplierId)
        {
            var offers = await repository.AllReadOnly<Offer>()
                .Where(o => o.SupplierId == supplierId)
                .Include(a => a.ActionType)
                .Include(a => a.Supplier)
                .ToListAsync();

            if (isContract != null)
            {
                bool result = isContract == "true" ? true : false;

                offers = offers
                    .Where(o => o.IsContract == result)
                    .ToList();
            }

            var offerResult = offers
                .Skip((currentPage - 1) * offersCountOnPage)
                .Take(offersCountOnPage)
                .Select(o => new OfferDetailViewModel()
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
                    CreatorPhoneNumber = o.Supplier.PhoneNumber,
                    CreatorName = o.Supplier.Name,
                    ActionDescription = o.ActionType.Description
                })
                .ToList();

            return new SupplierOffersAndCountViewModel()
            {
                OfferViewModels = offerResult,
                AllOffersCount = offers.Count()
            };
        }

        public async Task<OffersAndCountRecipientViewModel> AllOffersForRecipientAsync(string isContract,
                                                                                       int currentPage,
                                                                                       int offersCountOnPage,
                                                                                       string userId)
        {
            var currentRecipient = await repository.AllReadOnly<RecipientCompany>()
                .Where(t => t.OwnerId == userId)
                .FirstAsync();

            var offers = await repository.AllReadOnly<Offer>()
               .Include(a => a.ActionType)
               .Where(o => o.RecipientId == currentRecipient.Id)
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
                .Select(o => new OfferRecipientViewModel()
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

            return new OffersAndCountRecipientViewModel()
            {
                OfferViewModels = offerResult,
                AllOffersCount = offers.Count()
            };
        }



        public async Task AddTransporterInOfferAsync(AddTransportCompanyInOfferViewModel model)
        {
            var offer = await repository.All<Offer>()
                .Where(o => o.Id == model.OfferId)
                .FirstAsync();

            if (offer != null)
            {
                offer.TransporterId = model.TransporterId;
                offer.TruckId = model.TruckId;
                offer.TrailerId = model.TrailerId;

                await repository.SaveChangesAsync();
            }
        }

        public async Task AddRecipientInOfferAsync(AddRecipientCompanyInOfferViewModel model)
        {
            var offer = await repository.All<Offer>()
                .Where(o => o.Id == model.OfferId)
                .FirstAsync();

            if (offer != null)
            {
                offer.RecipientId = model.RecipientId;
                offer.CountryOfDestination = model.CountryOfDestination;
                offer.AddressOfDestination = model.AddressOfDestination;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<DetailOfferViewModel> DetailsOfferAsync(int offerId)
        {
            var model = await repository.AllReadOnly<Offer>()
                .Include(o => o.Supplier)
                .Include(o => o.Transporter)
                .Include(o => o.Recipient)
                .Include(o => o.Truck)
                .Include(o => o.Trailer)
                .Where(o => o.Id == offerId)
                .Select(o => new DetailOfferViewModel()
                {
                    ProductDescription = o.ProductDescription,

                    OfferViewModel = new OfferDetailViewModel()
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
                        ActionDescription = o.ActionType.Description,
                        CreatorName = o.Supplier.Name + "/" + o.Supplier.Country,
                        CreatorPhoneNumber = o.Supplier.PhoneNumber

                    },

                    RecipientDetail = new RecipientDetailViewModel()
                    {
                        CountryOfDestination = o.CountryOfDestination,
                        AddressOfDestination = o.AddressOfDestination,
                        RecipientId = o.RecipientId,
                        RecipientPhoneNumber = o.Recipient != null ? o.Recipient.PhoneNumber : string.Empty,
                        RecipientCountry = o.Recipient != null ? o.Recipient.Country : string.Empty,
                        RecipientName = o.Recipient != null ? o.Recipient.Name : string.Empty,

                    },

                    TransporterDetail = new TransporterDetailViewModel()
                    {
                        TransporterId = o.TransporterId,
                        TransporterName = o.Transporter != null ? o.Transporter.Name : string.Empty,
                        TransporterCountry = o.Transporter != null ? o.Transporter.Country : string.Empty,
                        TransporterPhoneNumber = o.Transporter != null ? o.Transporter.PhoneNumber : string.Empty,
                        TruckMake = o.Truck != null ? o.Truck.Make : string.Empty,
                        TruckModel = o.Truck != null ? o.Truck.Model : string.Empty,
                        TruckRegistration = o.Truck != null ? o.Truck.RegistrationNumber : string.Empty,
                        TruckUrl = o.Truck != null ? o.Truck.TruckImageURL : null,
                        TrailerMake = o.Trailer != null ? o.Trailer.Make : string.Empty,
                        TrailerRegistration = o.Trailer != null ? o.Trailer.RegistrationNumber : string.Empty,
                        TrailerUrl = o.Trailer != null ? o.Trailer.TrailerImageURL : null,

                    }
                })
                .FirstAsync();

            return model;
        }

    }
}
