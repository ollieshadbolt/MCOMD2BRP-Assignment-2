using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreRunningSports
{
    public sealed class StockSystem
    {
        // attributes
        static private readonly String[] mItemCategories = { "Clothing", "Shoe", "Nutrition", "Bag", "Watch" };
        static private List<Supplier> mSuppliers = new List<Supplier>();
        static private List<Customer> mCustomers = new List<Customer>();

        // methods
        static public void AddSupplier(Supplier Supplier)
        {
            mSuppliers.Add(Supplier);
        }
        
        static public void AddCustomer(Customer Customer)
        {
            mCustomers.Add(Customer);
        }

        static public List<Item> GetItems()
        {
            List<Item> list = new List<Item>();

            foreach (Supplier supplier in mSuppliers)
            {
                foreach (Item item in supplier.Items)
                {
                    list.Add(item);
                }
            }

            return list;
        }

        // accessors
        static public String[] ItemCategories
        {
            get
            {
                return mItemCategories;
            }
        }

        static public List<Supplier> Suppliers
        {
            get
            {
                return mSuppliers;
            }
        }

        static public List<Customer> Customers
        {
            get
            {
                return mCustomers;
            }
        }
    }
}
