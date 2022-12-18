using System;

namespace Options
{
    public struct Condition
    {
        public double priceBA;                               // расчетная цена БА
        public double volatility;                            // расчетная волатильность в %     
        public DateTime currentDate;                         // расчетная дата
        public double ratio;                                 // безрисковая процентная ставка в %
        
        public Condition ()
        {
            priceBA = 0;
            volatility = 0;
            currentDate = DateTime.Now;
            ratio= 0;
        }

        public Condition (double p, double v, DateTime d, double r)
        {
            priceBA = p;
            if (v < 0) volatility = 0; else volatility = v;
            if (d.Date<DateTime.Today) currentDate = DateTime.Now; else currentDate = d;
            if (r < 0) ratio = 0; else ratio = r;
        }

    }
}
