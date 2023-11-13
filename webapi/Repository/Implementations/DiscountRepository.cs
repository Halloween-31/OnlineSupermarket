using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models.Implementations;
using webapi.Repository.Generics;

namespace webapi.Repository.Implementations
{
    /// <summary>
    /// Represent repository for table Discounts, entity - Discount
    /// </summary>
    public class DiscountRepository : GenericRepository<OnlineSupermarket_DbContext, Discount>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_dbContext"></param>
        public DiscountRepository(OnlineSupermarket_DbContext _dbContext) : base(_dbContext) { }
        /// <summary>
        /// DbSet for access to table
        /// </summary>
        protected override DbSet<Discount> DbSet => _dbContext.Discounts;
    }
}
