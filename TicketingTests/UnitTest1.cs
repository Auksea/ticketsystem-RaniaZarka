using ClassLibrary;
using Oresundbron;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StoreBaeltTicketLibrary;

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
            bool BroBizz = false;
            double ActualPrice = 240;

            Car c = new Car(LiscencePlate, Date, BroBizz, ActualPrice);
            double thePrice = c.Price();
            Assert.AreEqual(240, thePrice);
        }

        [TestMethod]
        public void TestVehiculeTypeCarMethod()
        {

            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            bool BroBizz = false;
            double ActualPrice = 240;

            Car c = new Car(LiscencePlate, Date, BroBizz, ActualPrice);
            string theType = c.VehiculeType();
            Assert.AreEqual("Car", theType);
        }

        [TestMethod]
        public void TestPriceMCMethod()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            bool BroBizz = false;
            double ActualPrice = 125;


            MC mc = new MC(LiscencePlate, Date, BroBizz, ActualPrice);

            double thePrice = mc.Price();
            Assert.AreEqual(125, thePrice);
        }

        [TestMethod]
        public void TestVehiculeTypeMCMethod()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            bool BroBizz = false;
            double ActualPrice = 125;


            MC mc = new MC(LiscencePlate, Date, BroBizz, ActualPrice);

            string theType = mc.VehiculeType();
            Assert.AreEqual("MC", theType);

        }

        [TestMethod]
        public void LiscenePlateLenghtTest()
        {
            string LiscencePlate = "ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            bool BroBizz = false;
            double ActualPrice = 125;

            try
            {
                MC mc = new MC(LiscencePlate, Date, BroBizz, ActualPrice);
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void BroBizzPriceTest()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            double ActualPrice = 125;


            MC mc = new MC(LiscencePlate, Date, BroBizz: true, ActualPrice);

            double Price = mc.Price();

            Assert.AreEqual(118.75, Price);
        }

        [TestMethod]
        public void BroBizzCarPriceTest()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
           
            Car c = new Car(LiscencePlate, Date, BroBizz: true, ActualPrice: 240);

            double Price = c.Price();

            Assert.AreEqual(228, Price);
        }
        [TestMethod]
        public void McOresundBroBizzPrice()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            double ActualPrice = 210;

            McOresund mc = new McOresund(LiscencePlate, Date, BroBizz: true, ActualPrice);

            double Price = mc.Price();

            Assert.AreEqual(73, Price);
        }

        [TestMethod]
        public void McOresundCarBroBizzPrice()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);          
            double ActualPrice = 410;

            CarOresund c = new CarOresund(LiscencePlate, Date, BroBizz: true, ActualPrice);

            double Price = c.Price();

            Assert.AreEqual(161, Price);
        }
        [TestMethod]
        public void TestVehiculeCarOresundTypeMethod()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            bool BroBizz = false;
            double ActualPrice = 410;

            CarOresund c = new CarOresund(LiscencePlate, Date, BroBizz, ActualPrice);
            string theType = c.VehiculeType();
            Assert.AreEqual("Oresund Car", theType);
        }

        [TestMethod]
        public void TestVehiculeMCOresundTypeMethod()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 14);
            bool BroBizz = false;
            double ActualPrice = 210;

            McOresund mc = new McOresund(LiscencePlate, Date, BroBizz, ActualPrice);
            string theType = mc.VehiculeType();
            Assert.AreEqual("Oresund Mc", theType);
        }
        [TestMethod]
        public void WeekendPrice()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 9, 19);
            double ActualPrice = 240;
            
            Weekend w = new Weekend(LiscencePlate, Date, BroBizz: false, ActualPrice, DateString:"Saturday, 19, September, 2020");

            double Price = w.Price();

            Assert.AreEqual(192, Price);
        }

        [TestMethod]
        public void WeekendPriceAndBroBizz()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 9, 19);
            double ActualPrice = 240;

            Weekend w = new Weekend(LiscencePlate, Date, BroBizz:true, ActualPrice, DateString: "Saturday, 19, September, 2020");

            double Price = w.Price();

            Assert.AreEqual(180, Price);
        }
    }
}
