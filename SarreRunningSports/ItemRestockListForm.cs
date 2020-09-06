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
    public partial class ItemRestockListForm : Form
    {
        public ItemRestockListForm()
        {
            InitializeComponent();
        }

        private void ItemRestockListForm_Load(object sender, EventArgs e)
        {
            uiSupplierComboBox.DataSource = StockSystem.Suppliers;
            uiSupplierComboBox.DisplayMember = "Name";
        }

        private void uiSupplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiListTextBox.Text = null;

            Supplier supplier = (Supplier) uiSupplierComboBox.SelectedItem;

            foreach (Item item in (supplier.Items))
            {
                if (item.NeedsRestock())
                {
                    uiListTextBox.Text += item.Name + Environment.NewLine;
                }
            }
        }
    }
}
