using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TempTest
{
    [TestClass]
    public class TemporaryTests
    {
        [TestMethod]
        public void Test()
        {
            DateTime expectation = new DateTime(2023, 5, 9, 6, 7, 6);
            DateTime dateTime = new DateTime(2023, 5, 9, 6, 7, 6); ;
            Assert.IsTrue(expectation == dateTime);
        }
    }
}
