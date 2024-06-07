using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatesNamespace
{
    public class ReservationRates
    {
        private const double standardRateStudent = 350.00;
        private const double standardRateOutsider = 450.00;
        private const double studentOutsideAccom = 450.00;
        private const double lightsUse = 100.00;
        private double rateHourReturn;
        public double CalculateReserveRates(bool isStu, bool hasOuts, bool onLights)
        {
            double rateHour;
            if (isStu)
            {
                rateHour = hasOuts ? studentOutsideAccom : standardRateStudent;
            }//if Student has outsider, with outside accompaniment rate applies, else just the student rate.
            else 
            {
                rateHour = standardRateOutsider;
            }//if not student

            if (onLights)
            {
                rateHour += lightsUse;
            }//adds lights rate

            rateHourReturn = rateHour;
            return rateHourReturn;
        }
    }  
}