using webapi.Models.Implementations;

namespace Test.ModelsTest
{
    [TestClass]
    public class UnitTestModelsMethodToString
    {
        [TestMethod]
        public void TestCategory()
        {
            string expectation =
                "webapi.Models.Implementations.Category:\n\t" +
                "Id: 0\n\t" +
                "Name: Test_Category\n\t" +
                "Description: Test_Description\n\t" +
                "Products: System.Collections.Generic.List`1[webapi.Models.Implementations.Product]\n\t";

            Category category = new Category()
            {
                Id = 0,
                Name = "Test_Category",
                Description = "Test_Description",
                Products = new List<Product>()
                { 
                    new Product() 
                },
            };

            var stringCategory = category.ToString();
            Console.WriteLine(expectation);
            Console.WriteLine(stringCategory);

            Assert.AreEqual(expectation, stringCategory);
        }
        [TestMethod]
        public void TestCustomer()
        {
            string expectation =
                "webapi.Models.Implementations.Customer:\n\t" +
                "Id: 0\n\t" +
                "FirstName: fn\n\t" +
                "LastName: ln\n\t" +
                "ContactInfo: 789-789-7894\n\t" +
                "Address: address\n\t" +
                "LoyaltyPoints: \n\t" +
                "DestinationOfDelievery: \n\t" +
                "Sale: \n\t" +
                "Discounts: System.Collections.Generic.List`1[webapi.Models.Implementations.Discount]\n\t";

            Customer customer = new Customer()
            {
                Id = 0,
                FirstName = "fn",
                LastName = "ln",
                Address = "address",
                ContactInfo = "789-789-7894",
                LoyaltyPoints = null,
                DestinationOfDelievery = null,
                Discounts = {},
                Sale = {}
            };

            var stringCustomer = customer.ToString();
            Console.WriteLine(expectation);
            Console.WriteLine(stringCustomer);

            Assert.AreEqual(expectation, stringCustomer);
        }
    }
}