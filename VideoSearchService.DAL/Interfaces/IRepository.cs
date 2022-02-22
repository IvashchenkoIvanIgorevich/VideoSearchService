using System;
using System.Collections.Generic;
using System.Text;
using VideoSearchService.Service.Interfaces;

namespace VideoSearchService.DAL.Interfaces
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        IEnumerable<ISource> Get(string parameter);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
