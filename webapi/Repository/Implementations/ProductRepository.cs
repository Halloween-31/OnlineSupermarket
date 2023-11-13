using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models.Implementations;
using webapi.Repository.Generics;

namespace webapi.Repository.Implementations
{
    /// <summary>
    /// Represent repository for table Products, entity - Product
    /// </summary>
    public class ProductRepository : GenericRepository<OnlineSupermarket_DbContext, Product>
    {
        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="_dbContext"></param>
        public ProductRepository(OnlineSupermarket_DbContext _dbContext) : base(_dbContext) { }
        /// <summary>
        /// DbSet for access to table
        /// </summary>
        protected override DbSet<Product> DbSet => _dbContext.Products;
    }
}
