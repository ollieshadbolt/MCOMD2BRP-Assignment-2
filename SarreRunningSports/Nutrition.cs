using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreRunningSports
{
    public sealed class Nutrition : Accessory, IType
    {
        // attributes
        static private readonly String[] mTypes = { "Carbs", "Protein" };
        private int mQuantity;
        private String mType;

        // constructor
        public Nutrition(int Quantity, String Type, String Name, Decimal Price, int StockLevel, int OrderStockLevel) : base(Name, Price, StockLevel, OrderStockLevel)
        {
            this.Type = Type;
            this.Quantity = Quantity;
        }

        // method
        public override void PrintAttributes()
        {
            Console.WriteLine("Quantity: ", mQuantity);
            Console.WriteLine("Type: ", mType);
            base.PrintAttributes();
        }

        // accessors
        static public String[] Types
        {
            get
            {
                return mTypes;
            }
        }

        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Nutrition quantity must be positive!");
                }
                else
                {
                    mQuantity = value;
                }
            }
        }

        public String Type
        {
            get
            {
                return mType;
            }
            set
            {
                if (!Types.Contains(value))
                {
                    throw new ArgumentException("Invalid nutrition type!");
                }
                else
                {
                    mType = value;
                }
            }
        }
    }
}
