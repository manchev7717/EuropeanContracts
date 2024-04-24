using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Trailer;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Core.Services
{
    public class TrailerService : ITrailerService
    {
        private readonly IRepository repository;
        public TrailerService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddTruckAsync(Trailer trailerModel)
        {
            await repository.AddAsync(trailerModel);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var trailer = await repository.All<Trailer>()
                .FirstAsync(x => x.Id == id);

            await repository.DeleteAsync(trailer);
            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(EditAndDeleteTrailerViewModel model)
        {
            var trailer = await repository.All<Trailer>()
                .FirstOrDefaultAsync(t => t.Id == model.Id);

            if (trailer != null)
            {
                trailer.Make = model.Make;
                trailer.TrailerImageURL = model.TrailerImageURL;
                trailer.HasTemperatureControl = model.HasTemperatureControl;
                trailer.RegistrationNumber = model.RegistrationNumber;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistByIdAsync(int trailerId)
        {
            return await repository.AllReadOnly<Trailer>()
                 .AnyAsync(t => t.Id == trailerId);
        }

        public async Task<bool> HasTrailerTemperaturControlAsync(int? trailerId)
        {
            return await repository.AllReadOnly<Trailer>()
                .Where(t => t.Id == trailerId)
                .Where(t => t.HasTemperatureControl == true)
                .AnyAsync();
        }

        public async Task<IEnumerable<TrailerIdAndRegistrationViewModel>> GetTrailerForOfferAsync(bool isTemperatureRequired,
                                                                                                  int transporterId)
        {
            var returnModel = await repository.AllReadOnly<Trailer>()
                .Where(t => t.TransportCompanyId == transporterId)
                .Select(t => new TrailerIdAndRegistrationViewModel()
                {
                    Id = t.Id,
                    RegistrationNumber = t.RegistrationNumber,
                    HasTemperatureControl = t.HasTemperatureControl.ToString()
                })
                .ToListAsync();

            if (isTemperatureRequired == false)
            {
                return returnModel;
            }
            else
            {
                string criteria = "True";
                returnModel = returnModel
                    .Where(t => t.HasTemperatureControl == criteria)
                    .ToList();
                return returnModel;
            }
        }


        public async Task<EditAndDeleteTrailerViewModel> ReturnEditTrailerViewModelByIdAsync(int trailerId)
        {
            var trailer = await repository.AllReadOnly<Trailer>()
                .Where(t => t.Id == trailerId)
                .Select(t => new EditAndDeleteTrailerViewModel()
                {
                    Id = t.Id,
                    Make = t.Make,
                    TrailerImageURL = t.TrailerImageURL,
                    HasTemperatureControl = t.HasTemperatureControl,
                    TransportCompanyId = t.TransportCompanyId,
                    RegistrationNumber = t.RegistrationNumber
                })
                .FirstAsync();

            return trailer;
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
                    RegistrationNumber = t.RegistrationNumber,
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

    }

}

