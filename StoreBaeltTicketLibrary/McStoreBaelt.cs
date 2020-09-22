using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBaeltTicketLibrary
{
    public class McStoreBaelt: MC
    {

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        /// <param name="BroBizz"></param>
        /// <param name="ActualPrice"></param>
        public McStoreBaelt(string LiscencePlate, DateTime Date, bool BroBizz, double ActualPrice)
            : base(LiscencePlate, Date, BroBizz, ActualPrice)
        {

        }
        ///// <summary>
        ///// new value for ActualPrice set to be 125 
        ///// </summary>
        //public new double ActualPrice = 125;
        /// <summary>
        /// public ovveride double method Price 
        /// </summary>
        /// <returns>ActualPrice- discount</returns>
        public override double Price()
        {
            return base.Price();
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
