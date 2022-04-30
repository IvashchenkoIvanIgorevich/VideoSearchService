using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VideoSearchService.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class  
    {
        Task<TEntity> Get(object id);
        Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        Task Add(TEntity entity);
        void Delete(TEntity entity);
        void Delete(object id);
        void Update(TEntity entity);
    }
}
