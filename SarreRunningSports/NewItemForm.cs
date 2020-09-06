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
    public partial class NewItemForm : Form
    {
        public NewItemForm()
        {
            InitializeComponent();
        }

        private void NewItemForm_Load(object sender, EventArgs e)
        {
            uiCategoryComboBox.DataSource = StockSystem.ItemCategories;
            uiCategoryComboBox.SelectedItem = null;

            uiSupplierComboBox.DataSource = StockSystem.Suppliers;
            uiSupplierComboBox.DisplayMember = "Name";
        }

        private void uiItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { uiCapacityTextBox, uiSizeTextBox, uiColourTextBox, uiQuantityTextBox };

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Enabled = false;
                textBox.Text = null;
            }

            uiTypeComboBox.Enabled = false;
            uiStyleComboBox.Enabled = false;

            switch (uiCategoryComboBox.SelectedIndex)
            {
                case 0:
                    uiCapacityTextBox.Enabled = true;
                    break;
                case 1:
                    uiSizeTextBox.Enabled = true;
                    uiColourTextBox.Enabled = true;
                    uiStyleComboBox.Enabled = true;
                    uiStyleComboBox.DataSource = Clothing.Styles;
                    break;
                case 2:
                    uiQuantityTextBox.Enabled = true;
                    uiTypeComboBox.Enabled = true;
                    uiTypeComboBox.DataSource = Nutrition.Types;
                    break;
                case 3:
                    uiSizeTextBox.Enabled = true;
                    uiTypeComboBox.Enabled = true;
                    uiTypeComboBox.DataSource = Shoe.Types;
                    break;
                case 4:
                    uiTypeComboBox.Enabled = true;
                    uiTypeComboBox.DataSource = Watch.Types;
                    break;
            }

            uiTypeComboBox.Text = null;
            uiStyleComboBox.Text = null;
        }

        private void uiSubmitTextBox_Click(object sender, EventArgs e)
        {
            Item item;
            string name = uiNameTextBox.Text;
            string colour = uiColourTextBox.Text;
            string style = uiStyleComboBox.Text;
            string type = uiTypeComboBox.Text;

            if (uiSupplierComboBox.SelectedItem == null)
            {
                MessageBox.Show("Invalid supplier!");
            }
            else if (!decimal.TryParse(uiPriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Price must be a decimal!");
            }
            else if (!int.TryParse(uiStockLevelTextBox.Text, out int stockLevel))
            {
                MessageBox.Show("Stock level must be an integer!");
            }
            else if (!int.TryParse(uiOrderStockLevelTextBox.Text, out int orderStockLevel))
            {
                MessageBox.Show("Order stock level must be an integer!");
            }
            else if (!int.TryParse(uiCapacityTextBox.Text, out int capacity) && uiCapacityTextBox.Enabled)
            {
                MessageBox.Show("Capacity must be an integer!");
            }
            else if (!int.TryParse(uiSizeTextBox.Text, out int size) && uiSizeTextBox.Enabled)
            {
                MessageBox.Show("Size must be an integer!");
            }
            else if (!int.TryParse(uiQuantityTextBox.Text, out int quantity) && uiQuantityTextBox.Enabled)
            {
                MessageBox.Show("Quantity must be an integer!");
            }
            else
            {
                try
                {
                    switch (uiCategoryComboBox.SelectedIndex)
                    {
                        case 0:
                            item = new Bag(capacity, name, price, stockLevel, orderStockLevel);
                            break;
                        case 1:
                            item = new Clothing(size, colour, style, name, price, stockLevel, orderStockLevel);
                            break;
                        case 2:
                            item = new Nutrition(quantity, type, name, price, stockLevel, orderStockLevel);
                            break;
                        case 3:
                            item = new Shoe(size, type, name, price, stockLevel, orderStockLevel);
                            break;
                        case 4:
                            item = new Watch(type, name, price, stockLevel, orderStockLevel);
                            break;
                        default:
                            throw new ArgumentException("Invalid category!");
                    }
                    
                    Supplier supplier = (Supplier)uiSupplierComboBox.SelectedItem;
                    supplier.AddItem(item);

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
