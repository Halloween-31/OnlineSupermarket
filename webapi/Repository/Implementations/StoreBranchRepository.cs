using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models.Implementations;
using webapi.Repository.Generics;

namespace webapi.Repository.Implementations
{
    /// <summary>
    /// Represent repository for table StoreBranches, entity - StoreBranch
    /// </summary>
    public class StoreBranchRepository : GenericRepository<OnlineSupermarket_DbContext, StoreBranch>
    {
        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="_dbContext"></param>
        public StoreBranchRepository(OnlineSupermarket_DbContext _dbContext) : base(_dbContext) { }
        /// <summary>
        /// DbSet for access to table
        /// </summary>
        protected override DbSet<StoreBranch> DbSet => _dbContext.StoreBranches;
    }
}
