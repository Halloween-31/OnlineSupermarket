using webapi.Models.Implementations;
using webapi.Repository.Implementations;
using webapi.Repository.Interfaces;

namespace webapi.Tools.Extensions
{
    /// <summary>
    /// Class that implements extension for Builder.Services
    /// </summary>
    public static class ServicesExtensions
    {
        /// <summary>
        /// Method add scope for generic interface and its implementation for pattern Repository
        /// </summary>
        /// <param name="services"></param>
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Category>, CategoryRepository>();
            services.AddScoped<IRepository<Customer>, CustomerRepository>();
            services.AddScoped<IRepository<Discount>, DiscountRepository>();
            services.AddScoped<IRepository<Employee>, EmployeeRepository>();
            services.AddScoped<IRepository<Product>, ProductRepository>();
            services.AddScoped<IRepository<Sale>, SaleRepository>();
            services.AddScoped<IRepository<Spending>, SpendingRepository>();
            services.AddScoped<IRepository<StoreBranch>, StoreBranchRepository>();
            services.AddScoped<IRepository<Supplier>, SupplierRepository>();
        }
    }
}
