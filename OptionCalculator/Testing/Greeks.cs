using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    
    // структура для описания греков контракта
    public struct Greeks
    {
        public double Delta;
        public double Vega;
        public double Gamma;
        public double Theta;
        //public double? ro;
    }

    // метод для расчета греков контракта
    public interface IGreeks
    {
        public Greeks GetGreeks(double volativity, double price);
    }
}
