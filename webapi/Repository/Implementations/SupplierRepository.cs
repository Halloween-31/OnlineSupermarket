using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models.Implementations;
using webapi.Repository.Generics;

namespace webapi.Repository.Implementations
{
    /// <summary>
    /// Represent repository for table Categories, entity - Category
    /// </summary>
    public class SupplierRepository : GenericRepository<OnlineSupermarket_DbContext, Supplier>
    {
        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="_dbContext"></param>
        public SupplierRepository(OnlineSupermarket_DbContext _dbContext) : base(_dbContext) { }
        /// <summary>
        /// DbSet for access to table
        /// </summary>
        protected override DbSet<Supplier> DbSet => _dbContext.Suppliers;
    }
}
