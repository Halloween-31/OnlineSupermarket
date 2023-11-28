using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapi.Models.DTOs.Implementations.CategoryDTOs.Response;
using webapi.Models.DTOs.Implementations.CustomerDTOs.Response;
using webapi.Models.DTOs.Implementations.ProductDTOs.Response;
using webapi.Models.Implementations;
using webapi.Tools.AutoMapper;

namespace Test.AutoMapperTest
{
    [TestClass]
    public class UnitTestAutoMapperResponse
    {
        private readonly IMapper mapper = MyMapper.CreateMyMapper();

        [TestMethod]
        public void TestAutoMapperCategory()
        {
            CategoryResponse expectation = new CategoryResponse()
            {
                Id = 0,
                Description = "description",
                Name = "name",
            };

            Category category = new Category()
            {
                Id = 0,
                Description = "description",
                Name = "name",
            };

            var response = mapper.Map<CategoryResponse>(category);

            bool result = true;
            if(expectation.Id != response.Id) result = false;
            if(expectation.Name != response.Name) result = false;
            if(expectation.Description != response.Description) result = false;

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestAutoMapperCustomer() 
        {
            CustomerResponse expetation = new CustomerResponse()
            {
                Id = 0,
                FirstName = "fn",
                LastName = "ln",
                ContactInfo = "789-789-7894",
                Address = "address",
                DestinationOfDelievery = null,
                LoyaltyPoints = null,
            };

            Customer customer = new Customer()
            {
                Id = 0,
                FirstName = "fn",
                LastName = "ln",
                ContactInfo = "789-789-7894",
                Address = "address",
                DestinationOfDelievery = null,
                LoyaltyPoints = null,
            };

            var response = mapper.Map<CustomerResponse>(customer);

            bool result = true;
            if(response.Id != expetation.Id) result = false;
            if(response.FirstName != expetation.FirstName) result = false;
            if(response.LastName != expetation.LastName) result = false;
            if(response.ContactInfo != expetation.ContactInfo) result = false;
            if(response.Address != expetation.Address) result = false;
            if(response.LoyaltyPoints != expetation.LoyaltyPoints) result = false;
            if(response.DestinationOfDelievery != expetation.DestinationOfDelievery) result = false;

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestAutoMapperProducts()
        {
            ProductResponse expectation = new ProductResponse()
            {
                Id = 0,
                ProductName = "Test",
                Description = "desc",
                Count = 1000,
                Price = 1000,
                CategoryId = 0,
                SpendingId = 0,
                SupplierId = 0,
            };

            Product product = new Product()
            {
                Id = 0,
                ProductName = "Test",
                Description = "desc",
                Count = 1000,
                Price = 1000,
                CategoryId = 0,
                SpendingId = 0,
                SupplierId = 0,
            };

            var response = mapper.Map<ProductResponse>(product);

            bool result = true;
            if(expectation.Id != response.Id) result = false;
            if(expectation.ProductName != response.ProductName) result = false;
            if(expectation.Description != response.Description) result = false;
            if(expectation.Count != response.Count) result = false;
            if(expectation.Price != response.Price) result = false;
            if(expectation.CategoryId != response.CategoryId) result = false;
            if(expectation.SpendingId != response.SpendingId) result = false;
            if(expectation.SupplierId != response.SupplierId) result = false;

            Assert.IsTrue(result);
        }
    }
}
