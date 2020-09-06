namespace SarreRunningSports
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiNewItemButton = new System.Windows.Forms.Button();
            this.uiNewSupplierButton = new System.Windows.Forms.Button();
            this.uiItemRestockListButton = new System.Windows.Forms.Button();
            this.uiNewCustomerSaleButton = new System.Windows.Forms.Button();
            this.uiExistingCustomerSaleButton = new System.Windows.Forms.Button();
            this.uiCustomerPurchasesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiNewItemButton
            // 
            this.uiNewItemButton.Location = new System.Drawing.Point(13, 13);
            this.uiNewItemButton.Name = "uiNewItemButton";
            this.uiNewItemButton.Size = new System.Drawing.Size(123, 23);
            this.uiNewItemButton.TabIndex = 0;
            this.uiNewItemButton.Text = "New Item";
            this.uiNewItemButton.UseVisualStyleBackColor = true;
            this.uiNewItemButton.Click += new System.EventHandler(this.uiNewItemButton_Click);
            // 
            // uiNewSupplierButton
            // 
            this.uiNewSupplierButton.Location = new System.Drawing.Point(13, 43);
            this.uiNewSupplierButton.Name = "uiNewSupplierButton";
            this.uiNewSupplierButton.Size = new System.Drawing.Size(123, 23);
            this.uiNewSupplierButton.TabIndex = 1;
            this.uiNewSupplierButton.Text = "New Supplier";
            this.uiNewSupplierButton.UseVisualStyleBackColor = true;
            this.uiNewSupplierButton.Click += new System.EventHandler(this.uiNewSupplierButton_Click);
            // 
            // uiItemRestockListButton
            // 
            this.uiItemRestockListButton.Location = new System.Drawing.Point(13, 73);
            this.uiItemRestockListButton.Name = "uiItemRestockListButton";
            this.uiItemRestockListButton.Size = new System.Drawing.Size(123, 23);
            this.uiItemRestockListButton.TabIndex = 2;
            this.uiItemRestockListButton.Text = "Item Restock List";
            this.uiItemRestockListButton.UseVisualStyleBackColor = true;
            this.uiItemRestockListButton.Click += new System.EventHandler(this.uiItemRestockListButton_Click);
            // 
            // uiNewCustomerSaleButton
            // 
            this.uiNewCustomerSaleButton.Location = new System.Drawing.Point(13, 103);
            this.uiNewCustomerSaleButton.Name = "uiNewCustomerSaleButton";
            this.uiNewCustomerSaleButton.Size = new System.Drawing.Size(123, 23);
            this.uiNewCustomerSaleButton.TabIndex = 3;
            this.uiNewCustomerSaleButton.Text = "New Customer Sale";
            this.uiNewCustomerSaleButton.UseVisualStyleBackColor = true;
            this.uiNewCustomerSaleButton.Click += new System.EventHandler(this.uiNewCustomerSaleButton_Click);
            // 
            // uiExistingCustomerSaleButton
            // 
            this.uiExistingCustomerSaleButton.Location = new System.Drawing.Point(13, 133);
            this.uiExistingCustomerSaleButton.Name = "uiExistingCustomerSaleButton";
            this.uiExistingCustomerSaleButton.Size = new System.Drawing.Size(123, 23);
            this.uiExistingCustomerSaleButton.TabIndex = 4;
            this.uiExistingCustomerSaleButton.Text = "Existing Customer Sale";
            this.uiExistingCustomerSaleButton.UseVisualStyleBackColor = true;
            this.uiExistingCustomerSaleButton.Click += new System.EventHandler(this.uiExistingCustomerSaleButton_Click);
            // 
            // uiCustomerPurchasesButton
            // 
            this.uiCustomerPurchasesButton.Location = new System.Drawing.Point(13, 163);
            this.uiCustomerPurchasesButton.Name = "uiCustomerPurchasesButton";
            this.uiCustomerPurchasesButton.Size = new System.Drawing.Size(123, 23);
            this.uiCustomerPurchasesButton.TabIndex = 5;
            this.uiCustomerPurchasesButton.Text = "Customer Purchases";
            this.uiCustomerPurchasesButton.UseVisualStyleBackColor = true;
            this.uiCustomerPurchasesButton.Click += new System.EventHandler(this.uiCustomerPurchasesButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 199);
            this.Controls.Add(this.uiCustomerPurchasesButton);
            this.Controls.Add(this.uiExistingCustomerSaleButton);
            this.Controls.Add(this.uiNewCustomerSaleButton);
            this.Controls.Add(this.uiItemRestockListButton);
            this.Controls.Add(this.uiNewSupplierButton);
            this.Controls.Add(this.uiNewItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiNewItemButton;
        private System.Windows.Forms.Button uiNewSupplierButton;
        private System.Windows.Forms.Button uiItemRestockListButton;
        private System.Windows.Forms.Button uiNewCustomerSaleButton;
        private System.Windows.Forms.Button uiExistingCustomerSaleButton;
        private System.Windows.Forms.Button uiCustomerPurchasesButton;
    }
}

