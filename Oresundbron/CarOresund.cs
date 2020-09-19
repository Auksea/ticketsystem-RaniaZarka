using ClassLibrary;

using System;

namespace Oresundbron
{
    public class CarOresund : Vehicule
    {
        public new double ActualPrice = 410;
        public CarOresund (string LiscencePlate, DateTime Date, bool BroBizz, double ActualPrice) 
            : base(LiscencePlate, Date, BroBizz, ActualPrice)
        {

        }
       

       public override double Price()
        {
            if (BroBizz == true)
                return 161;
            else
                return ActualPrice;

        }

        public override string VehiculeType()
        {
            return "Oresund Car";
        }


    }
}
