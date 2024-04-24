using EuropeanContracts.Core.Contracts;
using EuropeanContracts.Core.ServiceViewModels.Transporter;
using EuropeanContracts.Core.ServiceViewModels.Truck;
using EuropeanContracts.Infrastructure.Comman;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Core.Services
{
    public class TruckService : ITruckService
    {
        private readonly IRepository repository;

        public TruckService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddTruckAsync(AutoTruck truckModel)
        {
            await repository.AddAsync(truckModel);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var truck = await repository.All<AutoTruck>()
                .FirstAsync(x => x.Id == id);

            await repository.DeleteAsync(truck);
            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(EditAndDeleteTruckViewModel model)
        {
            var truck = await repository.All<AutoTruck>()
                .FirstOrDefaultAsync(t => t.Id == model.Id);

            if (truck != null)
            {
                truck.Make = model.Make;
                truck.Model = model.Model;
                truck.HorsePower = model.HorsePower;
                truck.TruckImageURL = model.TruckImageURL;
                truck.HasCargoSpace = model.HasCargoSpace;
                truck.HasTemperatureControl = model.HasTemperatureControl;
                truck.RegistrationNumber = model.RegistrationNumber;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistByIdAsync(int truckId)
        {
            return await repository.AllReadOnly<AutoTruck>()
                .AnyAsync(t => t.Id == truckId);
        }


        public async Task<bool> HasTruckTemperaturControlAsync(int truckId)
        {
            return await repository.AllReadOnly<AutoTruck>()
                .Where(t => t.Id == truckId)
                .Select(t=>t.HasTemperatureControl)
                .FirstAsync();
        }

        public async Task<IEnumerable<TruckIdAndRegistrationViewModel>> GetTruckForOfferAsync(int transporterId)
        {
            return await repository.AllReadOnly<AutoTruck>()
                .Where(t=>t.TransportCompanyId == transporterId)
                .Select(t => new TruckIdAndRegistrationViewModel()
                {
                    Id = t.Id,
                    RegistrationNumber = t.RegistrationNumber,
                    HasTemperatureControl = t.HasTemperatureControl.ToString()

                })
                .ToListAsync();
        }


        public async Task<EditAndDeleteTruckViewModel> ReturnEditTruckViewModelByIdAsync(int truckId)
        {
            var truck = await repository.AllReadOnly<AutoTruck>()
                .Where(t => t.Id == truckId)
                .Select(t => new EditAndDeleteTruckViewModel()
                {
                    Id = t.Id,
                    Make = t.Make,
                    Model = t.Model,
                    HorsePower = t.HorsePower,
                    TruckImageURL = t.TruckImageURL,
                    HasCargoSpace = t.HasCargoSpace,
                    HasTemperatureControl = t.HasTemperatureControl,
                    RegistrationNumber = t.RegistrationNumber

                })
                .FirstAsync();

            return truck;
        }

        public async Task<AllTrucksViewModel> AllTrucksAsync(string isTemperatureNeeded,
                                                            string hasCargoSpace,
                                                            int currentPage,
                                                            int truckCountOnPage,
                                                            int transportCompanyId)
        {
            var trucks = await repository.AllReadOnly<AutoTruck>()
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
                    Id = t.Id,
                    Make = t.Make,
                    Model = t.Model,
                    HorsePower = t.HorsePower,
                    TruckImageURL = t.TruckImageURL,
                    HasCargoSpace = t.HasCargoSpace,
                    HasTemperatureControl = t.HasTemperatureControl,
                    TransportCompanyId = t.TransportCompanyId,
                    RegistrationNumber = t.RegistrationNumber
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


    }
}
