using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models.Implementations;
using webapi.Repository.Generics;

namespace webapi.Repository.Implementations
{
    /// <summary>
    /// Represent repository for table Spendings, entity - Spending
    /// </summary>
    public class SpendingRepository : GenericRepository<OnlineSupermarket_DbContext, Spending>
    {
        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="_dbContext"></param>
        public SpendingRepository(OnlineSupermarket_DbContext _dbContext) : base(_dbContext) { }
        /// <summary>
        /// DbSet for access to table
        /// </summary>
        protected override DbSet<Spending> DbSet => _dbContext.Spendings;
    }
}
