

namespace Options
{
    public enum ContractType { futures = -1, call = 0, put = 1 }
    public enum DealType { buy = 1, sell = -1 }

    // описание структуры для контрактов - опционов и фьючерсов
    public struct Contract
    {
        //public string name;         // код базового актива
        public ContractType Type;   // тип контракта
        public double? Strike;      // страйк опциона
        public DateTime ExpireDate; // дата экспирации

        public Contract(/*string n,*/ ContractType c, DateTime d, double? s)
        {
            if (c != ContractType.futures)
            { //name = n;
              Type = c; ExpireDate = d; Strike = s;
            }
            else
            {
                //name = n;
                Type = c; ExpireDate = d; Strike = null;
            }
        }
                
    }

    // описание структуры для сделки с контрактами
    public struct Deal: IGreeks
    {
        public Contract Contract;
        public double Price;
        public DealType DealType;
        public int Number;
        public bool Acting;

        public Deal(Contract c, double p, DealType d, int n, bool a)
        {
            Contract = c; Price = p; DealType = d; Number = n ; Acting = a; 
        }

        public Greeks GetGreeks(double volativity, double price)
        {
            Greeks greeks = new Greeks();
            // дописать код для определения греков по сделке с контрактом
            return greeks;
        }
    }

    public class Position: IGreeks
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

        public void AddContract(Deal d)
        {
            Deals.Add(d);
        }

        public void RemoveContract(Deal d)
        {
            Deals.Remove(d);
        }

        public Greeks GetGreeks(double volativity, double price)
        {
            Greeks greeks = new Greeks();
            // дописать код для определения греков текущей позиции по всем контрактам
            return greeks;
        }
    }
        
        
        
        
    
    

    
}
