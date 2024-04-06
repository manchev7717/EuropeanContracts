using EuropeanContracts.Core.Contracts;
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

        public async Task AddTruckAsync(Truck truckModel)
        {
            await repository.AddAsync(truckModel);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var truck = await repository.All<Truck>()
                .FirstAsync(x => x.Id == id);

            await repository.DeleteAsync(truck);
            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(EditTruckViewModel model)
        {
            var truck = await repository.All<Truck>()
                .FirstOrDefaultAsync(t => t.Id == model.Id);

            if (truck != null)
            {
                truck.Make = model.Make;
                truck.Model = model.Model;
                truck.HorsePower = model.HorsePower;
                truck.TruckImageURL = model.TruckImageURL;
                truck.HasCargoSpace = model.HasCargoSpace;
                truck.HasTemperatureControl = model.HasTemperatureControl;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistByIdAsync(int truckId)
        {
            return await repository.AllReadOnly<Truck>()
                .AnyAsync(t => t.Id == truckId);
        }

        public async Task<EditTruckViewModel> ReturnEditTruckViewModelById(int truckId)
        {
            var truck = await repository.AllReadOnly<Truck>()
                .Where(t => t.Id == truckId)
                .Select(t => new EditTruckViewModel()
                {
                    Id = t.Id,
                    Make = t.Make,
                    Model = t.Model,
                    HorsePower = t.HorsePower,
                    TruckImageURL = t.TruckImageURL,
                    HasCargoSpace = t.HasCargoSpace,
                    HasTemperatureControl = t.HasTemperatureControl,

                })
                .FirstAsync();

            return truck;
        }

        public async Task<bool> UserIsTransportCompanyOwnerByIdAsync(string userId)
        {
            return await repository.AllReadOnly<TransportCompany>()
                .AnyAsync(t => t.OwnerId == userId);
        }
    }
}
