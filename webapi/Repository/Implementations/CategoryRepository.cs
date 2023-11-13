using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models.Implementations;
using webapi.Repository.Generics;

namespace webapi.Repository.Implementations
{
    /// <summary>
    /// Represent repository for table Categories, entity - Category
    /// </summary>
    public class CategoryRepository : GenericRepository<OnlineSupermarket_DbContext, Category>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_dbContext"></param>
        public CategoryRepository(OnlineSupermarket_DbContext _dbContext) : base(_dbContext) { }
        /// <summary>
        /// DbSet for access to table
        /// </summary>
        protected override DbSet<Category> DbSet => _dbContext.Categories;
    }
}
