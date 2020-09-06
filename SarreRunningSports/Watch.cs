using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreRunningSports
{
    public sealed class Watch : Accessory, IType
    {
        // attributes
        static private readonly String[] mTypes = { "Simple", "Heart Rate", "GPS", "GPS and Heart Rate" };
        private String mType;

        // constructor
        public Watch(String Type, String Name, Decimal Price, int StockLevel, int OrderStockLevel) : base(Name, Price, StockLevel, OrderStockLevel)
        {
            this.Type = Type;
        }

        // method
        public override void PrintAttributes()
        {
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
                    throw new ArgumentException("Invalid watch type!");
                }
                else
                {
                    mType = value;
                }
            }
        }
    }
}
