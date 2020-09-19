using System;

namespace ClassLibrary
{
    /// <summary>
    /// public class Car that inherit from base class Vehicule 
    /// </summary>
    public class Car : Vehicule
    {
        /// <summary>
        /// public new int Actual price  of the car is set for 240 
        /// </summary>
        /// <summary>
        public new double ActualPrice = 240;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        /// <param name="BroBizz"></param>
        /// <param name="ActualPrice"></param>

        public Car(string LiscencePlate, DateTime Date, bool BroBizz, double ActualPrice) 
            : base(LiscencePlate, Date, BroBizz, ActualPrice)
        {
            
        }
       

        /// public double  override method Price
        /// </summary>
        /// <returns>price- BroBizzDiscount</returns>
        public  override double Price()
        {
            if (BroBizz == true)

              return  ActualPrice = ActualPrice - ActualPrice * 0.05;

            else { }
            return ActualPrice;
        }
        /// <summary>
        /// public override method  method VehiculeType 
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehiculeType()
        {
            return "Car";
        }
    }
}
