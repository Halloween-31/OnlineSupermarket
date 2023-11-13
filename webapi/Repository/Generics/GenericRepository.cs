using Microsoft.EntityFrameworkCore;
using webapi.Models.Interfaces;
using webapi.Repository.Interfaces;

namespace webapi.Repository.Generics
{
    /// <summary>
    /// Represent generic type for repositories 
    /// </summary>
    /// <typeparam name="TDbContext"></typeparam>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class GenericRepository<TDbContext, TEntity> : IRepository<TEntity>
        where TDbContext : DbContext
        where TEntity : class, IModel
    {
        /// <summary>
        /// Generic database context
        /// </summary>
        protected readonly TDbContext _dbContext;
        /// <summary>
        /// Database set for entity
        /// </summary>
        protected abstract DbSet<TEntity> DbSet { get; }

        /// <summary>
        /// Constructor to create specific repository based on database
        /// </summary>
        /// <param name="dbContext"></param>
        /// <exception cref="ArgumentNullException"></exception>
        protected GenericRepository(TDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        /// <inheritdoc/>        
        public TEntity Add(TEntity entity)
        {
            DbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        /// <inheritdoc/>
        public TEntity Update(TEntity entity)
        {
            DbSet.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        /// <inheritdoc/>
        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
            _dbContext.SaveChanges();
        }
        /// <inheritdoc/>
        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }
        /// <inheritdoc/>
        public virtual TEntity? GetById(int id)
        {
            return DbSet.FirstOrDefault(x => x.Id == id);
        }
    }
}
