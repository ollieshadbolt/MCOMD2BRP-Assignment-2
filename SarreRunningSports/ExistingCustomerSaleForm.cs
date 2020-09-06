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
    public partial class ExistingCustomerSaleForm : Form
    {
        public ExistingCustomerSaleForm()
        {
            InitializeComponent();
        }

        private void ExistingCustomerSaleForm_Load(object sender, EventArgs e)
        {
            uiCustomerComboBox.DataSource = StockSystem.Customers;
            uiCustomerComboBox.DisplayMember = "Name";

            uiItemComboBox.DataSource = StockSystem.GetItems();
            uiItemComboBox.DisplayMember = "Name";
        }

        private void uiSubmitButton_Click(object sender, EventArgs e)
        {

            if (uiCustomerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Invalid customer!");
            }
            else if (uiItemComboBox.SelectedItem == null)
            {
                MessageBox.Show("Invalid item!");
            }
            else
            {
                Item item = (Item)uiItemComboBox.SelectedItem;
                Customer customer = (Customer)uiCustomerComboBox.SelectedItem;

                try
                {
                    customer.AddPurchase(new Purchase(uiSaleDateDateTimePicker.Value, item));

                    MessageBox.Show("Success!");
                    Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }
    }
}
