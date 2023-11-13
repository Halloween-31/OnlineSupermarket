using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models.Implementations;
using webapi.Repository.Generics;
namespace webapi.Repository.Implementations
{
    /// <summary>
    /// Represent repository for table Employees, entity - Employee
    /// </summary>
    public class EmployeeRepository : GenericRepository<OnlineSupermarket_DbContext, Employee>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_dbContext"></param>
        public EmployeeRepository(OnlineSupermarket_DbContext _dbContext) : base(_dbContext) { }
        /// <summary>
        /// DbSet for access to table
        /// </summary>
        protected override DbSet<Employee> DbSet => _dbContext.Employees;
    }
}
