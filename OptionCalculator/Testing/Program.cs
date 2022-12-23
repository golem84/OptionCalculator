using Options;
using Statistics;
using System.Diagnostics;
using System.Windows.Forms;


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

        public void PrintBoard(double F, double dF, double volat)
        {
            for (int i = 1; i<=15; i++)
            {



            }
        }


        [STAThread]
        static void Main(string[] args)
        {
            MainForm form = new MainForm();
            Application.Run(form);
            return;        
            
            

        }
    }
}