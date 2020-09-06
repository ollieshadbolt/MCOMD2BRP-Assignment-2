using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreRunningSports
{
    public sealed class Bag : Accessory
    {
        // attribute
        private int mCapacity;

        // constructor
        public Bag(int Capacity, String Name, Decimal Price, int StockLevel, int OrderStockLevel) : base(Name, Price, StockLevel, OrderStockLevel)
        {
            this.Capacity = Capacity;
        }

        // method
        public override void PrintAttributes()
        {
            Console.WriteLine("Capacity: ", mCapacity);
            base.PrintAttributes();
        }

        // accessor
        public int Capacity
        {
            get
            {
                return mCapacity;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Bag capacity must be positive!");
                }
                else
                {
                    mCapacity = value;
                }
            }
        }
    }
}
