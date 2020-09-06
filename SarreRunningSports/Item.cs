using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreRunningSports
{
    public abstract class Item : IName
    {
        // attributes
        private String mName;
        private Decimal mPrice;
        private int mStockLevel;
        private int mOrderStockLevel;

        // constructors
        public Item(String Name, Decimal Price, int OrderStockLevel)
        {
            this.Name = Name;
            this.Price = Price;
            this.OrderStockLevel = OrderStockLevel;
        }

        public Item(String Name, Decimal Price, int StockLevel, int OrderStockLevel)
        {
            this.Name = Name;
            this.Price = Price;
            this.StockLevel = StockLevel;
            this.OrderStockLevel = OrderStockLevel;
        }

        // methods
        public void Sell()
        {
            /*
             * The customer argument for this method has been removed, as the item
             * class is not responsible for adding a purchase object into the customer
             * object. New customers also require a purchase with construction, meaning
             * this needs to be done first before the customer object has even been
             * constructed.
             */

            if (mStockLevel == 0)
            {
                throw new ArgumentException("No stock!");
            }
            else
            {
                mStockLevel--;
            }
        }

        public bool NeedsRestock()
        {
            return mStockLevel <= mOrderStockLevel;
        }

        public virtual void PrintAttributes()
        {
            Console.WriteLine("Name: ", mName);
            Console.WriteLine("Price: ", mPrice);
            Console.WriteLine("Stock Level: ", mStockLevel);
            Console.WriteLine("Order Stock Level: ", mOrderStockLevel);
        }
        
        // accessors
        public String Name
        {
            get
            {
                return mName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Item name cannot be null or empty!");
                }
                else
                {
                    mName = value;
                }
            }
        }

        public Decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Item price must be positive!");
                }
                else if (BitConverter.GetBytes(Decimal.GetBits(value)[3])[2] > 2)
                {
                    throw new ArgumentException("Item price cannot have more than 2 decimal places!");
                }
                else
                {
                    mPrice = value;
                }
            }
        }

        public int StockLevel
        {
            get
            {
                return mStockLevel;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Item stock level cannot be negative!");
                }
                else
                {
                    mStockLevel = value;
                }
            }
        }

        public int OrderStockLevel
        {
            get
            {
                return mOrderStockLevel;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Item order stock level must be positive!");
                }
                else
                {
                    mOrderStockLevel = value;
                }
            }
        }
    }
}
