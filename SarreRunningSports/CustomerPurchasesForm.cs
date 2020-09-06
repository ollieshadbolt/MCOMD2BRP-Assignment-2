using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarreRunningSports
{
    public partial class CustomerPurchasesForm : Form
    {
        public CustomerPurchasesForm()
        {
            InitializeComponent();
        }

        private void CustomerPurchasesForm_Load(object sender, EventArgs e)
        {
            uiCustomerComboBox.DataSource = StockSystem.Customers;
            uiCustomerComboBox.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiListTextBox.Text = null;

            Customer customer = (Customer)uiCustomerComboBox.SelectedItem;

            foreach (Purchase purchase in (customer.Purchases))
            {
                string line = String.Format("{0}: {1}", purchase.SaleDate.ToString("yyyy-MM-dd"), purchase.Price.ToString("0.00"));
                uiListTextBox.Text += line + Environment.NewLine;
            }
        }
    }
}
