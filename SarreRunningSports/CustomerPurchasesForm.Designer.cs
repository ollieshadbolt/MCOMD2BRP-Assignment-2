namespace SarreRunningSports
{
    partial class CustomerPurchasesForm
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
            this.uiCustomerLabel = new System.Windows.Forms.Label();
            this.uiCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.uiListTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiCustomerLabel
            // 
            this.uiCustomerLabel.AutoSize = true;
            this.uiCustomerLabel.Location = new System.Drawing.Point(12, 15);
            this.uiCustomerLabel.Name = "uiCustomerLabel";
            this.uiCustomerLabel.Size = new System.Drawing.Size(51, 13);
            this.uiCustomerLabel.TabIndex = 0;
            this.uiCustomerLabel.Text = "Customer";
            // 
            // uiCustomerComboBox
            // 
            this.uiCustomerComboBox.FormattingEnabled = true;
            this.uiCustomerComboBox.Location = new System.Drawing.Point(69, 12);
            this.uiCustomerComboBox.Name = "uiCustomerComboBox";
            this.uiCustomerComboBox.Size = new System.Drawing.Size(121, 21);
            this.uiCustomerComboBox.TabIndex = 1;
            this.uiCustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // uiListTextBox
            // 
            this.uiListTextBox.Location = new System.Drawing.Point(15, 39);
            this.uiListTextBox.Multiline = true;
            this.uiListTextBox.Name = "uiListTextBox";
            this.uiListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uiListTextBox.Size = new System.Drawing.Size(175, 399);
            this.uiListTextBox.TabIndex = 2;
            // 
            // CustomerPurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 450);
            this.Controls.Add(this.uiListTextBox);
            this.Controls.Add(this.uiCustomerComboBox);
            this.Controls.Add(this.uiCustomerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerPurchasesForm";
            this.ShowIcon = false;
            this.Text = "Customer Purchases";
            this.Load += new System.EventHandler(this.CustomerPurchasesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiCustomerLabel;
        private System.Windows.Forms.ComboBox uiCustomerComboBox;
        private System.Windows.Forms.TextBox uiListTextBox;
    }
}