using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreRunningSports
{
    public abstract class Accessory : Item
    {
        // constructor
        public Accessory(String Name, Decimal Price, int StockLevel, int OrderStockLevel) : base(Name, Price, StockLevel, OrderStockLevel)
        {
            // ...
        }
    }
}
