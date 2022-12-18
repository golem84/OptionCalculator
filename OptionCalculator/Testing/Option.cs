

using Statistics;

namespace Options
{
    // перечисления
    public enum OptionType { call = (sbyte)1, put = (sbyte)-1 }
    public enum DealType { buy = 1, sell = -1 }

    // описание структуры для фьючерса 
    public struct Futures : IGreeks
    {
        //public string Name;
        public DateTime ExpireDate;

        public Futures(DateTime d)
        {
            ExpireDate = d;
        }

        public Greeks GetGreeks(Condition cond)
        {
            Greeks greeks = new Greeks();
            // TODO: добавить греки для фьючерса
            return greeks;
        }
    }

    // описание структуры для опциона
    public struct Option : IGreeks
    {
        //public string name;         // код базового актива
        public OptionType Type;   // тип контракта
        public double Strike;      // страйк опциона
        public DateTime ExpireDate; // дата экспирации        

        public Option(/*string n,*/ OptionType c, DateTime d, double s)
        {
            Type = c;
            ExpireDate = d;
            Strike = s;
        }

        public double GetDaysToExpire(DateTime d)
        {
            TimeSpan dd = this.ExpireDate-d;
            if (DateTime.IsLeapYear(d.Year)) return dd.TotalHours / 366;
            else return dd.TotalHours / 365;
        }

        public Greeks GetGreeks(Condition cond)
        {
            Greeks greeks = new Greeks();
            // TODO: дописать метод GetGreeks для контракта
            double t = GetDaysToExpire(cond.currentDate);
            double h = (Math.Log(cond.priceBA / Strike) + 0.5 * cond.volatility * cond.volatility / t)
                / (cond.volatility * Math.Sqrt(t));
            double ert = Math.Exp(-cond.ratio * t);
            double Ph = Stat.NormPlotn(h);      // статич распределение            
            double Vh = Stat.NormVer(h);        // интеграл от статич распределения
            double Sqt = Math.Sqrt(t);
            double dteta = 0.5 * cond.priceBA * cond.volatility * Ph / Sqt;
            double Vph = Stat.NormVer(h - cond.volatility * Sqt);
            double Vmh = Stat.NormVer(cond.volatility * Sqt - h);

            greeks.Gamma = ert * Ph / (cond.priceBA * cond.volatility * Sqt);
            greeks.Vega = ert * cond.priceBA * Ph * Sqt;

            switch (Type)
            {
                case OptionType.call:
                    {
                        greeks.TheorPrice = cond.priceBA * ert * Vh - Strike * ert * Vph;
                        greeks.Delta = ert * Vh;
                        greeks.Theta = ert * (cond.ratio * (-cond.priceBA * Vh + Strike * Vph) + dteta);
                        greeks.Ro = -t * greeks.TheorPrice;
                        break;
                    }
                case OptionType.put:
                    {
                        greeks.TheorPrice = -cond.priceBA * ert * (1 - Vh) + Strike * ert * Vmh;
                        greeks.Delta = -ert * (1 - Vh);
                        greeks.Theta = ert * (cond.ratio * (cond.priceBA * (1 - Vh) - Strike * Vmh) + dteta);
                        greeks.Ro = -t * greeks.TheorPrice;
                        break;
                    }
            }
            return greeks;
        }

    }

    // TODO: ввести в сделку учет фьючерсов???
    // описание структуры для сделки с контрактами
    public struct Deal //: IGreeks
    {
        public Option Option;
        public double Price;
        public DealType DealType;
        public int Number;
        public bool Acting;

        public Deal(Option c, double p, DealType d, int n, bool a)
        {
            Option = c; Price = p; DealType = d; Number = n; Acting = a;
        }
    }

    public struct Position : IGreeks
    {
        private List<Deal> Deals { get; }

        public Position()
        {
            Deals = new List<Deal>();
        }

        public Position(List<Deal> deals)
        {
            Deals = new List<Deal>(deals);
        }

        public void AddDeal(Deal d)
        {
            Deals.Add(d);
        }

        public void RemoveDeal(Deal d)
        {
            Deals.Remove(d);
        }

        public Greeks GetGreeks(Condition cond)
        {
            Greeks greeks = new Greeks();
            // дописать код для определения греков текущей позиции по всем контрактам
            return greeks;
        }
    }


}
