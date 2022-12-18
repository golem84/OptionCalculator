

namespace Statistics
{
    public static class Stat
    {
        
        public static double NormPlotn(double x)    // статич.распределение
        {
            //if (sigm <= 0) return -1;
            return 0.39894228 * Math.Exp(-0.5 * x * x);
        }       

        public static double NormVer(double x)      // интеграл от статич.распределения
        {
            double sum = 0;
            double eps = (6-Math.Abs(x))*0.001;
            double t0 = x;
                        
            for (int i = 0; i <= 1000; i++)
            {                
                sum += Stat.NormPlotn(t0+eps/2)*eps;
                t0 += eps;
            }
            if (x < 0) return sum; else return 1 - sum;
        }

        
    }
}