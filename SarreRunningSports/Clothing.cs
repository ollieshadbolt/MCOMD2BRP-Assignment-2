using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreRunningSports
{
    public sealed class Clothing : Item
    {
        // attributes
        static private readonly String[] mStyles = { "Shorts", "Capris", "Leggings", "Vests", "Tops", "Jackets" };
        private int mSize;
        private String mColour;
        private String mStyle;

        // constructor
        public Clothing(int Size, String Colour, String Style, String Name, Decimal Price, int StockLevel, int OrderStockLevel)
            : base(Name, Price, StockLevel, OrderStockLevel)
        {
            this.Size = Size;
            this.Colour = Colour;
            this.Style = Style;
        }

        // method
        public override void PrintAttributes()
        {
            Console.WriteLine("Size: ", mSize);
            Console.WriteLine("Colour: ", mColour);
            Console.WriteLine("Style: ", mStyle);
            base.PrintAttributes();
        }

        // accessors
        static public String[] Styles
        {
            get
            {
                return mStyles;
            }
        }

        public int Size
        {
            get
            {
                return mSize;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Clothing size must be positive!");
                }
                else
                {
                    mSize = value;
                }
                
            }

        }

        public String Colour
        {
            get
            {
                return mColour;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Clothing colour cannot be null or empty!");
                }
                else
                {
                    mColour = value;
                }
            }
        }

        public String Style
        {
            get
            {
                return mStyle;
            }
            set
            {
                if (!Styles.Contains(value))
                {
                    throw new ArgumentException("Invalid clothing style!");
                }
                else
                {
                    mStyle = value;
                }
            }
        }
    }
}
