using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TicketingTests
{
    [TestClass]
    public class UnitTest1
    {




        [TestMethod]
        public void TestPriceCarMethod()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            Car c = new Car(LiscencePlate, Date);
            double thePrice = c.Price();
            Assert.AreEqual(240, thePrice);
        }

        [TestMethod]
        public void TestVehiculeTypeCarMethod()
        {

            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            Car c = new Car(LiscencePlate, Date);
            string theType = c.VehiculeType();
            Assert.AreEqual("Car", theType);
        }

        [TestMethod]
        public void TestPriceMCMethod()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            MC mc = new MC(LiscencePlate, Date);
            double thePrice = mc.Price();
            Assert.AreEqual(125, thePrice);
        }

        [TestMethod]
        public void TestVehiculeTypeMCMethod()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            MC mc = new MC(LiscencePlate, Date);
            string theType = mc.VehiculeType();
            Assert.AreEqual("MC", theType);
            
        }

        [TestMethod]
        public void LiscenePlateLenghtTest()
        {
            string liscencePlate = "ac14369";
            DateTime date = new DateTime(2020, 8, 14);
            try
            {
                MC mc = new MC(liscencePlate, date);
            }
            catch(ArgumentException)
            {
                Assert.Fail();
            }
        }
        
         
        
            
    }
}
