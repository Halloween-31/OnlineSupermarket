using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models.Implementations;
using webapi.Repository.Generics;

namespace webapi.Repository.Implementations
{
    /// <summary>
    /// Represent repository for table Sales, entity - Sale
    /// </summary>
    public class SaleRepository : GenericRepository<OnlineSupermarket_DbContext, Sale>
    {
        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="_dbContext"></param>
        public SaleRepository(OnlineSupermarket_DbContext _dbContext) : base(_dbContext) { }
        /// <summary>
        /// DbSet for access to table
        /// </summary>
        protected override DbSet<Sale> DbSet => _dbContext.Sales;
    }
}
