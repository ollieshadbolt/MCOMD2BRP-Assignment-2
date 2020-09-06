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
    public partial class NewCustomerSaleForm : Form
    {
        public NewCustomerSaleForm()
        {
            InitializeComponent();
        }

        private void NewCustomerSaleForm_Load(object sender, EventArgs e)
        {
            uiItemComboBox.DataSource = StockSystem.GetItems();
            uiItemComboBox.DisplayMember = "Name";
        }

        private void uiSubmitButton_Click(object sender, EventArgs e)
        {
            if (uiItemComboBox.SelectedItem == null)
            {
                MessageBox.Show("Invalid item!");
            }
            else
            {
                try
                {
                    Item item = (Item)uiItemComboBox.SelectedItem;
                    Purchase purchase = new Purchase(uiSaleDateDateTimePicker.Value, item);
                    Customer customer = new Customer(uiNameTextBox.Text, uiEmailTextBox.Text, uiGDPRCheckBox.Checked, purchase);
                    StockSystem.AddCustomer(customer);

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
