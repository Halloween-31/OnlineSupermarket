using AutoMapper;
using webapi.Models.DTOs.Implementations.CategoryDTOs.Request;
using webapi.Models.DTOs.Implementations.CategoryDTOs.Response;
using webapi.Models.DTOs.Implementations.CustomerDTOs.Request;
using webapi.Models.DTOs.Implementations.CustomerDTOs.Response;
using webapi.Models.DTOs.Implementations.DiscountDTOs.Request;
using webapi.Models.DTOs.Implementations.DiscountDTOs.Response;
using webapi.Models.DTOs.Implementations.EmployeeDTOs.Request;
using webapi.Models.DTOs.Implementations.EmployeeDTOs.Response;
using webapi.Models.DTOs.Implementations.ProductDTOs.Request;
using webapi.Models.DTOs.Implementations.ProductDTOs.Response;
using webapi.Models.DTOs.Implementations.SaleDTOs.Request;
using webapi.Models.DTOs.Implementations.SaleDTOs.Response;
using webapi.Models.DTOs.Implementations.SpendingDTOs.Request;
using webapi.Models.DTOs.Implementations.SpendingDTOs.Response;
using webapi.Models.DTOs.Implementations.StoreBranchDTOs.Request;
using webapi.Models.DTOs.Implementations.StoreBranchDTOs.Response;
using webapi.Models.DTOs.Implementations.SupplierDTOs.Request;
using webapi.Models.DTOs.Implementations.SupplierDTOs.Response;
using webapi.Models.Implementations;

namespace webapi.Tools.AutoMapper
{
    /// <summary>
    /// Represent my AutoMapper
    /// </summary>
    public class MyMapper : Profile
    {
        /// <summary>
        /// Constructor, where we create maps
        /// </summary>
        public MyMapper()
        {
            AllowNullCollections = true;

            CreateMap<Category, CreateEditCategoryRequest>().ReverseMap();
            CreateMap<Category, CategoryResponse>().ReverseMap();

            CreateMap<Customer, CreateEditCustomerRequest>().ReverseMap();
            CreateMap<Customer, CustomerResponse>().ReverseMap();

            CreateMap<Discount, CreateEditDiscountRequest>().ReverseMap();
            CreateMap<Discount, DiscountResponse>().ReverseMap();

            CreateMap<Employee, CreateEditEmployeeRequest>().ReverseMap();
            CreateMap<Employee, EmployeeResponse>().ReverseMap();

            CreateMap<Product, CreateEditProductRequest>().ReverseMap();
            CreateMap<Product, ProductResponse>().ReverseMap();

            CreateMap<Sale, CreateEditSaleRequest>().ReverseMap();
            CreateMap<Sale, SaleResponse>().ReverseMap();

            CreateMap<Spending, CreateEditSpendingRequest>().ReverseMap();
            CreateMap<Spending, SpendingResponse>().ReverseMap();

            CreateMap<StoreBranch, CreateEditStoreBranchRequest>().ReverseMap();
            CreateMap<StoreBranch, StoreBranchResponse>().ReverseMap();

            CreateMap<Supplier, CreateEditSupplierRequest>().ReverseMap();
            CreateMap<Supplier, SupplierResponse>().ReverseMap();
        }
        /// <summary>
        /// Static method, where we create an instance of mapper
        /// </summary>
        /// <returns>IMapper</returns>
        public static IMapper CreateMyMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            }).CreateMapper();
        }
    }
}
