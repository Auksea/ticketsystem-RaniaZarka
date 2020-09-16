using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public abstract class  Vehicule
    {

        /// <summary>
        /// instance fields string _liscencePlate, DateTime _date
        /// </summary>
        private string _liscenseplate;
        private DateTime _date;
        /// <summary>
        /// public constructor 
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        public Vehicule(string LiscencePlate, DateTime Date)
        {
            _liscenseplate = LiscencePlate;
            _date = Date;
        }

        
        /// <summary>
        /// public properties LiscencePlate, Date 
        /// </summary>
        public string LiscencePlate { get; set; }
        public string Date { get; set; }

        public abstract double Price();

        public abstract string VehiculeType();
       
    }
}
