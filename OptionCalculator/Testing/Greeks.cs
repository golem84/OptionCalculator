

namespace Options
{
    
    // структура для описания греков контракта
    public struct Greeks
    {
        public double TheorPrice;
        public double Delta;
        public double Vega;
        public double Gamma;
        public double Theta;
        public double Ro;
    }

    // метод для расчета греков контракта
    public interface IGreeks
    {
        public Greeks GetGreeks(Condition cond);
    }
}
