using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassLibrary
{/// <summary>
/// Public abstract class Vehicule
/// </summary>
   public abstract class  Vehicule
    {

        /// <summary>
        /// instance fields string _liscencePlate, DateTime _date, double _actualPrice, bool _broBizz, double _broBizzDiscount
        /// </summary>
        private string _liscenseplate;
        private DateTime _date;
        private double _actualPrice;
        private bool _broBizz;
        private double _broBizzDiscount;

        /// <summary>
        /// public constructor 
        /// </summary>
        /// <param name="LiscencePlate"> Throw ArgumentException when it has more than 7 Characters</param>
        /// <param name="Date"></param>
        /// <param name="BroBizz"></param>
        /// <param name="ActualPrice"></param>      
        public Vehicule(string LiscencePlate, DateTime Date, bool BroBizz, double ActualPrice)
        {
            _broBizz = BroBizz;
            _date = Date;
            _liscenseplate = LiscencePlate;
            if (LiscencePlate.Length > 7)
                throw new ArgumentException("Wrong format");
            _actualPrice = ActualPrice;
           // _broBizzDiscount = BroBizzDiscount;           
            Date.ToString("dddd,dd MMMM YYYY");

        }

        /// <summary>
        /// public string properties LiscencePlate
        /// </summary>
        public string LiscencePlate { get; set; }

       /// <summary>
       /// public DateTime property Date
       /// </summary>
        public DateTime Date { get; set; }


        /// <summary>
        /// Public bool property BroBizz
        /// </summary>
        

        public  bool BroBizz
        {
            get { return _broBizz; }
            set { _broBizz = value; }
        }


        /// <summary>
        /// public double ActualPrice: is the price without any discount
        /// </summary>      
        public double ActualPrice { get; set; }

        /// <summary>
        /// public double property BroBizzDiscount that gives 5% discount if Brobizz property is true 
        /// </summary>
        public double BroBizzDiscount
        {
            
            get { return _broBizzDiscount; }
            set
            {
                if (BroBizz == true)
                    _broBizzDiscount = ActualPrice - ActualPrice * 0.95;
                else 
                  _broBizzDiscount = 0;
                
            }
        }
        /// <summary>
        /// Virtual method double Price 
        /// </summary>
        /// <returns> ActualPrice -  BroBizzDiscount </returns>
        public virtual double Price()
        {
            double finalPrice = ActualPrice - BroBizzDiscount;
            return finalPrice;
            //if (BroBizz == true)

            //    ActualPrice = ActualPrice - ActualPrice * 0.95;

            //else { }
            //return ActualPrice;

        }  
        
       

        /// <summary>
        /// Abstract method string VehiculeType
        /// </summary>
        /// <returns></returns>
        public abstract string VehiculeType();

       
       
    }
}
