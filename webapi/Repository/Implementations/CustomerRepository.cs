using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models.Implementations;
using webapi.Repository.Generics;

namespace webapi.Repository.Implementations
{
    /// <summary>
    /// Represent repository for table Customers, entity - Customer
    /// </summary>
    public class CustomerRepository : GenericRepository<OnlineSupermarket_DbContext, Customer>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_dbContext"></param>
        public CustomerRepository(OnlineSupermarket_DbContext _dbContext) : base(_dbContext) { }
        /// <summary>
        /// DbSet for access to table
        /// </summary>
        protected override DbSet<Customer> DbSet => _dbContext.Customers;
    }
}
