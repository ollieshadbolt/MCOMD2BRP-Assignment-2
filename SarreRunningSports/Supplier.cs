using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreRunningSports
{
    public sealed class Supplier : IName
    {
        // attributes
        private String mName;
        private List<Item> mItems = new List<Item>();

        // constructor
        public Supplier(String Name, Item Item)
        {
            this.Name = Name;
            AddItem(Item);
        }

        // methods
        public List<Item> GetOrderList()
        {
            List<Item> list = new List<Item>();

            foreach (Item item in mItems)
            {
                if (item.NeedsRestock())
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public void AddItem(Item Item)
        {
            mItems.Add(Item);
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
                    throw new ArgumentException("Supplier name cannot be null or empty!");
                }
                else
                {
                    mName = value;
                }
            }
        }

        public List<Item> Items
        {
            get
            {
                return mItems;
            }
        }
    }
}
