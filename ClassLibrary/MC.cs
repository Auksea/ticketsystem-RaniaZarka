using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public  class MC : Vehicule
    {
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        public MC(string LiscencePlate, DateTime Date): base(LiscencePlate, Date)
        {
           
        }
        


        /// <summary>
        /// public double method Price that returns 125
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 125;
        }
        /// <summary>
        /// public string method Vehicule that returns "MC" 
        /// </summary>
        /// <returns></returns>
        public override string VehiculeType()
        {
            return "MC";
        }
    }
}
