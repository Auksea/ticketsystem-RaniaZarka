using ClassLibrary;
using System;

namespace StoreBaeltTicketLibrary
{/// <summary>
/// public class Weekend that inherit from class Car
/// </summary>
    public class Weekend : Car
    {
        /// <summary>
        /// private instance field _weekendDiscount
        /// </summary>
        private double _weekendDiscount;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        /// <param name="BroBizz"></param>
        /// <param name="ActualPrice"></param>

        public Weekend(string LiscencePlate, DateTime Date, bool BroBizz, double ActualPrice )
            : base( LiscencePlate, Date, BroBizz,ActualPrice)
        {
        }

        /// <summary>
        /// Public double property WeekendDiscount that gives 20% discount if Date contains Sunday or Saturday 
        /// </summary>
        public double WeekendDiscount
        {
            get { return _weekendDiscount; }
            set
            {
                if (Date.Contains("Sunday") || Date.Contains("Saturday"))
                    _weekendDiscount = ActualPrice - ActualPrice * 0.8;
                else _weekendDiscount = 0;
            }
        }
        /// <summary>
        /// Override method Price double
        /// </summary>
        /// <returns>Base.Price() - weekendDiscount</returns>
        public override double Price()
        {
            return base.Price() - WeekendDiscount;
        }
         public override string VehiculeType()
        {
            return "Car";
        }
        


            
        
    }
}
