using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using webapi.Models.DTOs.Implementations.CategoryDTOs.Request;
using webapi.Models.DTOs.Implementations.CustomerDTOs.Request;
using webapi.Models.DTOs.Implementations.DiscountDTOs.Request;
using webapi.Models.DTOs.Implementations.EmployeeDTOs.Request;
using webapi.Models.DTOs.Implementations.ProductDTOs.Request;
using webapi.Models.DTOs.Implementations.SaleDTOs.Request;
using webapi.Models.DTOs.Implementations.SpendingDTOs.Request;
using webapi.Models.DTOs.Implementations.StoreBranchDTOs.Request;
using webapi.Models.DTOs.Implementations.SupplierDTOs.Request;
using webapi.Models.Implementations;
using webapi.Tools.AutoMapper;

namespace Test.AutoMapperTest
{
    [TestClass]
    public class UnitTestAutoMapper
    {
        private readonly IMapper mapper = MyMapper.CreateMyMapper();

        [TestMethod]
        public void TestAutoMapperCategory()
        {
            Category expectation = new Category()
            {      
                Id = default,
                Name = "Test_Name",
                Description = "Test_Description",
            };

            CreateEditCategoryRequest request = new CreateEditCategoryRequest()
            {
                Id = null,
                Name = "Test_Name",
                Description = "Test_Description",
            };

            var category = mapper.Map<Category>(request);
            Assert.IsTrue(expectation == category);
        }
        [TestMethod]
        public void TestAutoMapperCustomer()
        {
            Customer expectation = new Customer()
            {
                Id = default,
                FirstName = "Test_Name",
                LastName = "Test_lastname",
                Address = "Test_address",
                ContactInfo = "Test_ci",
                DestinationOfDelievery = null,
                LoyaltyPoints = null
            };

            CreateEditCustomerRequest request = new CreateEditCustomerRequest()
            {
                Id = null,
                FirstName = "Test_Name",
                LastName = "Test_lastname",
                Address = "Test_address",
                ContactInfo = "Test_ci",
                DestinationOfDelievery = null,
                LoyaltyPoints = null
            };

            var customer = mapper.Map<Customer>(request);
            Assert.IsTrue(expectation == customer);
        }
        [TestMethod]
        public void TestAutoMapperDiscount()
        {
            Discount expectation = new Discount()
            {
                Id = default,
                Name = "Test_discount",
                Description = "Test_d",
                StartDate = new DateTime(2000, 1, 1, 1, 1, 1),
                EndDate = new DateTime(2023, 1, 1, 1, 1, 1),
                ProductId = 1,
            };

            CreateEditDiscountRequest request = new CreateEditDiscountRequest()
            {
                Id = null,
                Name = "Test_discount",
                Description = "Test_d",
                StartDate = new DateTime(2000, 1, 1, 1, 1, 1),
                EndDate = new DateTime(2023, 1, 1, 1, 1, 1),
                ProductId = 1,
            };

            var discount = mapper.Map<Discount>(request);
            Assert.IsTrue(expectation == discount);
        }
        [TestMethod]
        public void TestAutoMapperEmployee() 
        {
            Employee expectation = new Employee()
            {
                Id = default,
                FirstName = "Test_fn",
                LastName = "Test_ln",
                DateOfBirth = new DateTime(2000, 1, 1, 1, 1, 1),
                Phone = "789-789-7894",
                Salary = 1000,
                Position = "Worker",
                StoreId = null,
            };

            CreateEditEmployeeRequest request = new CreateEditEmployeeRequest()
            {
                Id = null,
                FirstName = "Test_fn",
                LastName = "Test_ln",
                DateOfBirth = new DateTime(2000, 1, 1, 1, 1, 1),
                Phone = "789-789-7894",
                Salary = 1000,
                Position = "Worker",
                StoreId = null,
            };

            var employee = mapper.Map<Employee>(request);
            Assert.IsTrue(expectation == employee);
        }
        [TestMethod]
        public void TestAutoMapperProducts()
        {
            Product expectation = new Product()
            {
                Id = default,
                ProductName = "test_name",
                Description = "test_d",
                Count = 1000,
                Price = 1000,
                CategoryId = 1,
                SpendingId = 1,
                SupplierId = 1,
            };

            CreateEditProductRequest request = new CreateEditProductRequest()
            {
                Id = null,
                ProductName = "test_name",
                Description = "test_d",
                Count = 1000,
                Price = 1000,
                CategoryId = 1,
                SpendingId = 1,
                SupplierId = 1,
            };

            var product = mapper.Map<Product>(request);
            Assert.IsTrue(expectation == product);
        }
        [TestMethod]
        public void TestAutoMapperSale()
        {
            Sale expectation = new Sale()
            {
                Id = default,
                SaleDate = new DateTime(2023, 1, 1, 1, 1, 1),
                TotalAmount = 1000,
                PaymentMethod = "Card",
                CustomerId = 1,
                EmployeeId = null,
            };

            CreateEditSaleRequest request = new CreateEditSaleRequest()
            {
                Id = null,
                SaleDate = new DateTime(2023, 1, 1, 1, 1, 1),
                TotalAmount = 1000,
                PaymentMethod = "Card",
                CustomerId = 1,
                EmployeeId = null,
            };

            var sale = mapper.Map<Sale>(request);
            Assert.IsTrue(expectation == sale);
        }
        [TestMethod]
        public void TestAutoMapperSpending()
        {
            Spending expectation = new Spending()
            {
                Id = default,
                Description = "Test_D",
                SpendingDate = new DateTime(2023, 1, 1, 1, 1, 1),
                Amount = 1000,
                Price = 1000,
                EmployeeId = null,
                SupplierId = null,
            };

            CreateEditSpendingRequest request = new CreateEditSpendingRequest()
            {
                Id = null,
                Description = "Test_D",
                SpendingDate = new DateTime(2023, 1, 1, 1, 1, 1),
                Amount = 1000,
                Price = 1000,
                EmployeeId = null,
                SupplierId = null,
            };

            var spending = mapper.Map<Spending>(request);
            Assert.IsTrue(expectation == spending);
        }
        [TestMethod]
        public void TestAutoMapperStore()
        {
            StoreBranch expectation = new StoreBranch()
            {
                Id = default,
                Info = "test_info",
                Location = "Test_location",
                Name = "Test_Name",
                OpeningDate = new DateTime(2023, 1, 1, 1, 1, 1),
            };

            CreateEditStoreBranchRequest request = new CreateEditStoreBranchRequest()
            {
                Id = null,
                Info = "test_info",
                Location = "Test_location",
                Name = "Test_Name",
                OpeningDate = new DateTime(2023, 1, 1, 1, 1, 1),
            };

            var store = mapper.Map<StoreBranch>(request);
            Assert.IsTrue(expectation == store);
        }
        [TestMethod]
        public void TestAutoMapperSupplier()
        {
            Supplier expectation = new Supplier()
            {
                Id = default,
                Address = "Test_address",
                SupplierName = "test_name",
                ContactInfo = "789-789-7894",
            };

            CreateEditSupplierRequest request = new CreateEditSupplierRequest()
            {
                Id = null,
                Address = "Test_address",
                SupplierName = "test_name",
                ContactInfo = "789-789-7894",
            };

            var supplier = mapper.Map<Supplier>(request);
            Assert.IsTrue(expectation == supplier);
        }
    }
}
