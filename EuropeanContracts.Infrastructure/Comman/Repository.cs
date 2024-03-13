using EuropeanContracts.Data;
using Microsoft.EntityFrameworkCore;

namespace EuropeanContracts.Infrastructure.Comman
{
    public class Repository : IRepository
    {
        private readonly DbContext dbContext;

        public Repository(EuropeanContractsDbContext _contex)
        {
            dbContext = _contex;
        }

        private DbSet<T> GetDbSet<T>() where T : class 
        {
            return dbContext.Set<T>();
        }

        public IQueryable<T> All<T>() where T : class
        {
            return GetDbSet<T>();
        }
        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return GetDbSet<T>()
                .AsNoTracking();
        }
        public async Task AddAsync<T>(T entity) where T : class
        {
            await dbContext.Set<T>()
                .AddAsync(entity);                
        }

        public async Task<int> SaveChangesAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
