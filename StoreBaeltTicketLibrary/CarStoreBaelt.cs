using ClassLibrary;
using System;

namespace StoreBaeltTicketLibrary
{/// <summary>
/// public class Weekend that inherit from class Car
/// </summary>
    public class CarStoreBaelt
        : Car
    {
        /// <summary>
        /// ActualPrice set to be 240;
        /// </summary>
        public new double ActualPrice = 240;
        /// <summary>-
        /// private instance field string _dateString
        /// </summary>
       
        private string _dateString;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        /// <param name="BroBizz"></param>
        /// <param name="ActualPrice"></param>
        /// <param name="DateString"></param>

        public CarStoreBaelt(string LiscencePlate, DateTime Date, bool BroBizz, double ActualPrice, string DateString)
            : base( LiscencePlate, Date, BroBizz,ActualPrice)
        {
            _dateString = DateString;
            DateString = string.Format("{0:dddd, MMMM d yyyy}", Date);
            
        }

        /// <summary>
        /// String Property DateString
        /// </summary>
        public string DateString
        {
            get { return _dateString; }
            set { _dateString  = value; }
        }
       
        /// <summary>
        /// Override method Price double
        /// </summary>
        /// <returns>if DateString contains Sunday or Saturday discount of 20% else ActualPrice</returns>
        public override double Price()
        {
            double weekendPrice = ActualPrice - ActualPrice * 0.2;
            double weekendAndBroBizzPrice = weekendPrice - ActualPrice * 0.05;

            if (VehiculeType() == "Car" && (DateString. Contains("Sunday") || DateString.Contains("Saturday")) && BroBizz == false)

                return weekendPrice; 

            else if (VehiculeType() == "Car" && (DateString.Contains("Sunday") || DateString.Contains("Saturday")) && BroBizz == true)

                return  weekendAndBroBizzPrice;

            else 

            { return ActualPrice; }
        }

        


            
        
    }
}
