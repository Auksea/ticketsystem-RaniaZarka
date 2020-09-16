using System;

namespace ClassLibrary
{
    public class car
    { /// <summary>
    /// instance fields string _liscencePlate, DateTime _date
    /// </summary>
        private string _liscenseplate;
        private DateTime _date;

        public car()
        {
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        public car(string LiscencePlate, DateTime Date)
        {
            _liscenseplate = LiscencePlate;
            _date = Date;

        }
        /// <summary>
        /// public properties LiscencePlate, Date 
        /// </summary>
        public string LiscencePlate { get; set; }
        public string Date { get; set; }

        /// <summary>
        /// public double method Price that returns 240
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// public string method VehiculeType that returns "Car" 
        /// </summary>
        /// <returns></returns>
        public string VehiculeType()
        {
            return "Car";
        }
    }
}
