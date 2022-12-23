

namespace Statistics
{
    public static class Stat
    {
        
        public static double NormRasp(double x)    // статич.распределение
        {
            //if (sigm <= 0) return -1;
            return 0.39894228 * Math.Exp(-0.5 * x * x);
        }       

        public static double IntegrRasp(double x)      // интеграл от статич.распределения
        {
            const int N = 1000;
            double sum = 0;
            double eps = Math.Abs(x)/N;
            double t0 = 0;
                        
            for (int i = 0; i < N; i++)
            {                
                sum += Stat.NormRasp(t0+eps/2)*eps;
                t0 += eps;
            }

            if (x > 0) return sum + 0.5; else return 1 - sum - 0.5;
            //if (x < 0) return sum; else return 1 - sum;
        }

        
    }
}