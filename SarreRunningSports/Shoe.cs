using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreRunningSports
{
    public sealed class Shoe : Item, IType
    {
        // attributes
        static private readonly String[] mTypes = { "Racer", "Stability", "Neutral", "Trail", "Track" };
        private decimal mSize;
        private String mType;

        // constructor
        public Shoe(decimal Size, String Type, String Name, Decimal Price, int StockLevel, int OrderStockLevel) : base(Name, Price, StockLevel, OrderStockLevel)
        {
            this.Size = Size;
            this.Type = Type;
        }

        // method
        public override void PrintAttributes()
        {
            Console.WriteLine("Size: ", mSize);
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

        public decimal Size
        {
            get
            {
                return mSize;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Shoe size must be positive!");
                }
                else if (BitConverter.GetBytes(Decimal.GetBits(value)[3])[2] > 1)
                {
                    throw new ArgumentException("Shoe size cannot have more than 1 decimal places!");
                }
                else
                {
                    mSize = value;
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
                    throw new ArgumentException("Invalid shoe type!");
                }
                else
                {
                    mType = value;
                }
            }
        }
    }
}
