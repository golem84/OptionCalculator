

namespace Statistics
{
    public static class Stat
    {
        public static double NormPlotn(double x, double m, double sigm)
        {
            if (sigm <= 0) return -1;
            double razn = x - m;
            return 0.39894228 * Math.Exp(-0.5 * razn * razn / sigm / sigm) / sigm;
        }

        public static double NormPlotn(double x, double sigm)
        {
            if (sigm <= 0) return -1;
            return 0.39894228 * Math.Exp(-0.5 * x * x / sigm / sigm) / sigm;
        }

        public static double NormVer(double x, double sigm, int n)
        {
            double sum = 0;
            double t = x - 1 / n / n;
            for (int i = n; i < 1; i--)
            {
                double t1 = x - 1 / n / (n - i);
                var a = NormPlotn(t,sigm);
                sum += a * (t1 - t);
                t = t1;
            }
            return sum;
        }
    }
}