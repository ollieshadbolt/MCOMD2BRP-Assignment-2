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
    public partial class NewSupplierForm : Form
    {
        public NewSupplierForm()
        {
            InitializeComponent();
        }

        private void NewSupplierForm_Load(object sender, EventArgs e)
        {
            uiItemCategoryComboBox.DataSource = StockSystem.ItemCategories;
            uiItemCategoryComboBox.SelectedItem = null;
        }

        private void uiItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { uiItemCapacityTextBox, uiItemSizeTextBox, uiItemColourTextBox, uiItemQuantityTextBox };

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Enabled = false;
                textBox.Text = null;
            }

            uiItemTypeComboBox.Enabled = false;
            uiItemStyleComboBox.Enabled = false;

            switch (uiItemCategoryComboBox.SelectedIndex)
            {
                case 0:
                    uiItemCapacityTextBox.Enabled = true;
                    break;
                case 1:
                    uiItemSizeTextBox.Enabled = true;
                    uiItemColourTextBox.Enabled = true;
                    uiItemStyleComboBox.Enabled = true;
                    uiItemStyleComboBox.DataSource = Clothing.Styles;
                    break;
                case 2:
                    uiItemQuantityTextBox.Enabled = true;
                    uiItemTypeComboBox.Enabled = true;
                    uiItemTypeComboBox.DataSource = Nutrition.Types;
                    break;
                case 3:
                    uiItemSizeTextBox.Enabled = true;
                    uiItemTypeComboBox.Enabled = true;
                    uiItemTypeComboBox.DataSource = Shoe.Types;
                    break;
                case 4:
                    uiItemTypeComboBox.Enabled = true;
                    uiItemTypeComboBox.DataSource = Watch.Types;
                    break;
            }

            uiItemTypeComboBox.Text = null;
            uiItemStyleComboBox.Text = null;
        }

        private void uiSubmitTextBox_Click(object sender, EventArgs e)
        {
            Item item;
            string name = uiItemNameTextBox.Text;
            string colour = uiItemColourTextBox.Text;
            string style = uiItemStyleComboBox.Text;
            string type = uiItemTypeComboBox.Text;
            
            if (!decimal.TryParse(uiItemPriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Price must be a decimal!");
            }
            else if (!int.TryParse(uiItemStockLevelTextBox.Text, out int stockLevel))
            {
                MessageBox.Show("Stock level must be an integer!");
            }
            else if (!int.TryParse(uiItemOrderStockLevelTextBox.Text, out int orderStockLevel))
            {
                MessageBox.Show("Order stock level must be an integer!");
            }
            else if (!int.TryParse(uiItemCapacityTextBox.Text, out int capacity) && uiItemCapacityTextBox.Enabled)
            {
                MessageBox.Show("Capacity must be an integer!");
            }
            else if (!int.TryParse(uiItemSizeTextBox.Text, out int size) && uiItemSizeTextBox.Enabled)
            {
                MessageBox.Show("Size must be an integer!");
            }
            else if (!int.TryParse(uiItemQuantityTextBox.Text, out int quantity) && uiItemQuantityTextBox.Enabled)
            {
                MessageBox.Show("Quantity must be an integer!");
            }
            else
            {
                try
                {
                    switch (uiItemCategoryComboBox.SelectedIndex)
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
                            throw new ArgumentException("Invalid item category!");
                    }

                    Supplier supplier = new Supplier(uiSupplierNameTextBox.Text, item);
                    StockSystem.AddSupplier(supplier);

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