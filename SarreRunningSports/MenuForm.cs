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
    public partial class MenuForm : Form
    {
        List<Form> forms;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void ReinitialiseForms()
        {
            forms = new List<Form>
            {
                new NewItemForm(),
                new NewSupplierForm(),
                new ItemRestockListForm(),
                new NewCustomerSaleForm(),
                new ExistingCustomerSaleForm(),
                new CustomerPurchasesForm(),
            };
        }

        public void CloseForms()
        {
            foreach (Form form in forms)
            {
                form.Close();
            }

            ReinitialiseForms();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            ReinitialiseForms();
        }

        private void uiNewItemButton_Click(object sender, EventArgs e)
        {
            CloseForms();
            forms[0].Show();
        }

        private void uiNewSupplierButton_Click(object sender, EventArgs e)
        {
            CloseForms();
            forms[1].Show();
        }

        private void uiItemRestockListButton_Click(object sender, EventArgs e)
        {
            CloseForms();
            forms[2].Show();
        }

        private void uiNewCustomerSaleButton_Click(object sender, EventArgs e)
        {
            CloseForms();
            forms[3].Show();
        }

        private void uiExistingCustomerSaleButton_Click(object sender, EventArgs e)
        {
            CloseForms();
            forms[4].Show();
        }

        private void uiCustomerPurchasesButton_Click(object sender, EventArgs e)
        {
            CloseForms();
            forms[5].Show();
        }
    }
}
