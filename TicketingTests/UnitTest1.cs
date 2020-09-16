using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketingTests
{
    [TestClass]
    public class UnitTest1
    {

        Car c = new Car();
        MC mc = new MC();

        [TestMethod]
        public void TestPriceCarMethod()
        {
            double thePrice = c.Price();
            Assert.AreEqual(240, thePrice);
        }

        [TestMethod]
        public void TestVehiculeTypeCarMethod()
        {
            string theType = c.VehiculeType();
            Assert.AreEqual("Car", theType);
        }

        [TestMethod]
        public void TestPriceMCMethod()
        {
            double thePrice = mc.Price();
            Assert.AreEqual(125, thePrice);
        }

        [TestMethod]
        public void TestVehiculeTypeMCMethod()
        {
            string theType = mc.Vehicule();
            Assert.AreEqual("MC", theType);
        }



    }
}
