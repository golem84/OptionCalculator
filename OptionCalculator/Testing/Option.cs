

using Statistics;

namespace Options
{
    // перечисления
    public enum OptionType { call, put }
    public enum DealType { buy = 1, sell = -1 }

    // описание структуры для фьючерса 
    public struct Futures : IGreeks
    {
        //public string Name;
        public DateTime ExpireDate;

        public Futures(DateTime d)
        {

            if (d < DateTime.Today) ExpireDate = DateTime.Today;
            else ExpireDate = d;
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
            TimeSpan dd = this.ExpireDate - d;
            double mm;
            if (DateTime.IsLeapYear(d.Year)) mm = dd.TotalDays / 366;
            else mm = dd.TotalDays/365;
            return mm;
            
        }

        public Greeks GetGreeks(Condition cond)
        {
            Greeks greeks = new Greeks();
            // TODO: дописать метод GetGreeks для контракта

            double t = GetDaysToExpire(cond.currentDate);
            double Sqt = Math.Sqrt(t);
            double h = (Math.Log(cond.priceBA / Strike) + 0.5 * cond.volatility * cond.volatility * t) 
                / (cond.volatility * Sqt);
            double ert = Math.Exp(-cond.ratio * t);
            double Nh = Stat.IntegrRasp(h);      // интеграл распределение            
            double Nnh = Stat.NormRasp(h);        // норм статич распределение
            
            double dteta = 0.5 * cond.priceBA * cond.volatility * Nnh / Sqt;
            double Nhv = Stat.IntegrRasp(h - cond.volatility * Sqt);
            double Nvh = 1-Nhv;

            greeks.Gamma = ert * Nnh / (cond.priceBA * cond.volatility * Sqt);
            greeks.Vega = ert * cond.priceBA * Nnh * Sqt/100;

            switch (Type)
            {
                case OptionType.call:
                    {
                        greeks.TheorPrice = (cond.priceBA * Nh - Strike * Nhv)*ert;
                        greeks.Delta = ert * Nh;
                        greeks.Theta = ert * (cond.ratio * (-cond.priceBA * Nh + Strike * Nvh) + dteta)/365;
                        greeks.Ro = -t * greeks.TheorPrice/100;
                        break;
                    }
                case OptionType.put:
                    {
                        greeks.TheorPrice = -cond.priceBA * ert * (1 - Nh) + Strike * ert * Nvh;
                        greeks.Delta = -ert * (1 - Nh);
                        greeks.Theta = ert * (cond.ratio * (cond.priceBA * (1 - Nh) - Strike * Nvh) + dteta)/365;
                        greeks.Ro = -t * greeks.TheorPrice/100;
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
