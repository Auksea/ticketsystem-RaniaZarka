using System;

namespace ClassLibrary
{
    public class Car : Vehicule
    {
      
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        public Car(string LiscencePlate, DateTime Date): base(LiscencePlate, Date)
        {
           
        }
       

        /// <summary>
        /// public double  override method Price that returns 240
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 240;
        }
        /// <summary>
        /// public string  override method VehiculeType that returns "Car" 
        /// </summary>
        /// <returns></returns>
        public override string VehiculeType()
        {
            return "Car";
        }
    }
}
