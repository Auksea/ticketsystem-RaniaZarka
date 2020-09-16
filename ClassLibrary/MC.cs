using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public  class MC
    {
        /// <summary>
        /// instance fields string _liscencePlate, DateTime _date
        /// </summary>
        private string _liscenseplate;
        private DateTime _date;

        public MC()
        {
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        public MC(string LiscencePlate, DateTime Date)
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
        /// public double method Price that returns 125
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 125;
        }
        /// <summary>
        /// public string method Vehicule that returns "MC" 
        /// </summary>
        /// <returns></returns>
        public string Vehicule()
        {
            return "MC";
        }
    }
}
