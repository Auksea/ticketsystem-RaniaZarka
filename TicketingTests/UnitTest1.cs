using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketingTests
{
    [TestClass]
    public class UnitTest1
    {

        car c = new car();

        [TestMethod]
        public void TestPriceMethod()
        {
            double thePrice = c.Price();
            Assert.AreEqual(240, thePrice);
        }

        [TestMethod]
        public void TestVehiculeTypeMethod()
        {
            string theType = c.VehiculeType();
            Assert.AreEqual("Car", theType);
        }
    }
}
