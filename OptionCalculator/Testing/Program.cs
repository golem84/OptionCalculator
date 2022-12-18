using Options;
using Statistics;

using System.Diagnostics;

namespace Testing

{
    internal class Program
    {
        //public delegate double FuncDelegate(double x, int N);


        public double CalculateOptionPrice(double F, double S, double volat)
        {
            double price = 0;

            return price;
        }

        public void PrintBoard(double F, double volat)
        {
            for (int i = 1; i<=15; i++)
            {



            }
        }

        static void Main(string[] args)
        {
            Condition cond = new Condition(1750, 0.185, DateTime.Now+TimeSpan.FromDays(15), 0.075);
            Option opt = new Option(OptionType.call, DateTime.Now + TimeSpan.FromDays(32), 1700);
            Console.WriteLine("Условия для расчета:");
            Console.WriteLine($"{cond.priceBA} {cond.currentDate.Date} {cond.volatility} {cond.ratio}");
            Console.WriteLine("Характеристики опциона:");
            Console.WriteLine($"{opt.Type} {opt.Strike} {opt.ExpireDate.Date}");
            Console.WriteLine();
            Greeks g = opt.GetGreeks(cond);
            Console.WriteLine($"Price: {g.TheorPrice}\nDelta: {g.Delta}\nGamma: {g.Gamma}\nTheta: {g.Theta}\nVega: {g.Vega}\nRo: {g.Ro}");

        }
    }
}