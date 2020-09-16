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
        /// <param name="LiscencePlate"> Lenght not more then 7 characters else exception</param>
        /// <param name="Date"></param>
        public Vehicule(string LiscencePlate, DateTime Date)
        {
            _date = Date;
            _liscenseplate = LiscencePlate;
            if (LiscencePlate.Length > 7)
                throw new ArgumentException("Wrong format");
        }

        
        /// <summary>
        /// public properties LiscencePlate, Date 
        /// </summary>
        public string LiscencePlate { get; set; }
       /// <summary>
       /// public property Date
       /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// public property Discount
        /// </summary>
        public int Discount { get; set; }
        /// <summary>
        /// Abstract method double Price 
        /// </summary>
        /// <returns></returns>
        public  abstract double Price();
        
        /// <summary>
        /// Abstract methos string VehiculeType
        /// </summary>
        /// <returns></returns>
        public abstract string VehiculeType();
       
    }
}
