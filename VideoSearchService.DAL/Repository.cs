using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideoSearchService.Data.Interfaces;

namespace VideoSearchService.DAL
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Data context for access to DB
        /// </summary>
        private ApplicationDbContext _context;

        /// <summary>
        /// Constructor which initializes DB context by using the DI
        /// </summary>
        /// <param name="context">DB context</param>
        public Repository(ApplicationDbContext context)
        {
            _context = context;            
        }

        /// <summary>
        /// Get all data for entity
        /// </summary>
        /// <returns>Enumeration of data</returns>
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => 
            await _context.Set<TEntity>().ToListAsync();

        /// <summary>
        /// Get specific object by id
        /// </summary>
        /// <param name="id">Specific object id</param>
        /// <returns>Object by specific id</returns>
        public virtual async Task<TEntity> GetAsync(object id) => 
            await _context.Set<TEntity>().FindAsync(id);
        
        /// <summary>
        /// Add new object for entity
        /// </summary>
        /// <param name="entity">Specific entity</param>
        /// <returns></returns>
        public virtual async Task AddAsync(TEntity entity) =>
            await _context.Set<TEntity>().AddAsync(entity);

        /// <summary>
        /// Delete specific object by id
        /// </summary>
        /// <param name="id">Specific object id</param>
        public virtual void Delete(object id)
        {
            TEntity entityToDelete = _context.Set<TEntity>().Find(id);
            Delete(entityToDelete);
        }

        /// <summary>
        /// Delete specific object by entity
        /// </summary>
        /// <param name="entityToDelete">Specific object by entity</param>
        public virtual void Delete(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _context.Set<TEntity>().Attach(entityToDelete);
            }
            _context.Set<TEntity>().Remove(entityToDelete);
        }

        /// <summary>
        /// Update specific object by entity
        /// </summary>
        /// <param name="entityToUpdate">Specific object by entity</param>
        public virtual void Update(TEntity entityToUpdate)
        {
            _context.Set<TEntity>().Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
