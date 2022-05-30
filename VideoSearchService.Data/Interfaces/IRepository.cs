using System.Collections.Generic;
using System.Threading.Tasks;

namespace VideoSearchService.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class  
    {
        Task<TEntity> GetAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);
        void Delete(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
    }
}
