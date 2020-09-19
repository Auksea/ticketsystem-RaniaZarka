using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{/// <summary>
/// public Class MC that inherit from Vehicule
/// </summary>
   public  class MC : Vehicule
    {
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        /// <param name="BroBizz"></param>
        /// <param name="ActualPrice"></param>
        public MC(string LiscencePlate, DateTime Date, bool BroBizz, double ActualPrice) 
            : base(LiscencePlate, Date, BroBizz, ActualPrice)
        {
           
        }
        /// <summary>
        /// new value for ActualPrice set to be 240 
        /// </summary>
        public new double ActualPrice = 125;
        /// <summary>
        /// public ovveride double method Price 
        /// </summary>
        /// <returns>ActualPrice- discount</returns>
        public override double Price()
        {

            if (BroBizz == true)

              return ActualPrice = ActualPrice - ActualPrice * 0.05;

            else { }
            return ActualPrice;

        }
        /// <summary>
        /// public override string method VehiculeType  
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehiculeType()
        {
            return "MC";
        }
    }
}
