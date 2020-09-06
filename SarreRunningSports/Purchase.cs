using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreRunningSports
{
    public sealed class Purchase
    {
        // attributes
        private DateTime mSaleDate;
        private Decimal mPrice;

        // constructors
        public Purchase(Item item)
        {
            SaleDate = DateTime.Now;
            Price = item.Price;

            item.Sell();
        }

        public Purchase(DateTime SaleDate, Item item)
        {
            this.SaleDate = SaleDate;
            Price = item.Price;

            item.Sell();
        }

        // accessors
        public DateTime SaleDate
        {
            get
            {
                return mSaleDate;
            }
            set
            {
                if (value.Date > DateTime.Now.Date)
                {
                    throw new ArgumentException("Purchase sale date cannot be in the future!");
                }
                else
                {
                    mSaleDate = value.Date;
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
                    throw new ArgumentException("Purchase price must be positive!");
                }
                else if (BitConverter.GetBytes(Decimal.GetBits(value)[3])[2] > 2)
                {
                    throw new ArgumentException("Purchase price cannot have more than 2 decimal places!");
                }
                else
                {
                    mPrice = value;
                }
            }
        }
    }
}
