using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VideoSearchService.Data.Interfaces;

namespace VideoSearchService.DAL
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private ApplicationDbContext _context;
        private DbSet<TEntity> _entities;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entities = Entities;
        }

        protected virtual DbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<TEntity>();

                return _entities;
            }
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() =>
            await _entities.ToListAsync();

        public virtual async Task<TEntity> GetAsync(int id) => 
            await _entities.FindAsync(id);
        
        public virtual async Task AddAsync(TEntity entity) =>
            await _entities.AddAsync(entity);

        public virtual async void Delete(int id)
        {
            TEntity entityToDelete = await _entities.FindAsync(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _entities.Attach(entityToDelete);
            }
            _entities.Remove(entityToDelete);
        }

        public virtual void Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
                Delete(entity);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            _entities.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        //public IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
        //{
        //    return Include(includeProperties).ToList();
        //}

        //private IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
        //{
        //    IQueryable<TEntity> query = _entities.AsNoTracking();
        //    return includeProperties
        //        .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        //}
    }
}
