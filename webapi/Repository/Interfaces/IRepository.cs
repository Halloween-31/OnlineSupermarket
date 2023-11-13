using webapi.Models.Interfaces;

namespace webapi.Repository.Interfaces
{
    /// <summary>
    /// Represent intefcase for pattern 'Repository'
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : IModel
    {
        /// <summary>
        /// Add entity to database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Add(TEntity entity);
        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Update(TEntity entity);
        /// <summary>
        /// Delete entity from db
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);
        /// <summary>
        /// Get all elements of this entity from db
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();
        /// <summary>
        /// Get specific entity from db
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity? GetById(int id);
    }
}
