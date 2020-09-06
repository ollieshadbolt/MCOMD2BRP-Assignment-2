using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SarreRunningSports;

namespace CustomerTest
{
    [TestClass]
    public class UnitTest
    {
        // attributes
        public static int mSize = 1;
        public static String mColour = "Test Colour";
        public static String mStyle = Clothing.Styles[0];
        public static String mItemName = "Test Item";
        public static Decimal mPrice = 1.00m;
        public static int mStockLevel = 10;
        public static int mOrderStockLevel = 1;
        public static Item mItem = new Clothing(mSize, mColour, mStyle, mItemName, mPrice, mStockLevel, mOrderStockLevel);

        // methods
        [TestMethod]
        public void AddCustomer()
        {
            DateTime saleDate = DateTime.Today;

            Purchase purchase = new Purchase(saleDate, mItem);

            string customerName = "Test Customer";
            string email = "test@test.test";
            bool GDPR = true;

            Customer customer = new Customer(customerName, email, GDPR, purchase);

            StockSystem.AddCustomer(customer);

            customer = StockSystem.Customers[0];

            Assert.AreEqual(customer.Name, customerName);
            Assert.AreEqual(customer.Email, email);
            Assert.AreEqual(customer.GDPR, GDPR);

            purchase = customer.Purchases[0];

            Assert.AreEqual(purchase.SaleDate, saleDate);
            Assert.AreEqual(purchase.Price, mItem.Price);
        }

        [TestMethod]
        public void AddSupplier()
        {
            string supplierName = "Test Supplier";

            Supplier supplier = new Supplier(supplierName, mItem);

            StockSystem.AddSupplier(supplier);

            supplier = StockSystem.Suppliers[0];

            Assert.AreEqual(supplier.Name, supplierName);

            Clothing clothing = (Clothing) supplier.Items[0];

            Assert.AreEqual(clothing.Size, mSize);
            Assert.AreEqual(clothing.Colour, mColour);
            Assert.AreEqual(clothing.Style, mStyle);
            Assert.AreEqual(clothing.Name, mItemName);
            Assert.AreEqual(clothing.Price, mItem.Price);
            Assert.AreEqual(clothing.StockLevel, mStockLevel - 1); // - 1 due to previous customer sale
            Assert.AreEqual(clothing.OrderStockLevel, mOrderStockLevel);
        }
    }
}
