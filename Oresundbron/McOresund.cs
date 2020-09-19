using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Oresundbron
{
    public class McOresund : Vehicule
    {
        public new double ActualPrice = 210;
        public McOresund(string LiscencePlate, DateTime Date, bool BroBizz, double ActualPrice)
            : base(LiscencePlate, Date, BroBizz, ActualPrice)
        {

        }
        
        public override double Price()
        {
            if (BroBizz == true)
             return 73; 
            else
              return ActualPrice;          
        }

        public override string VehiculeType()
        {
            return "Oresund Mc";
        }
    }
}
