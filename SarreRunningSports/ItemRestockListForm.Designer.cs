namespace SarreRunningSports
{
    partial class ItemRestockListForm
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
            this.uiSupplierLabel = new System.Windows.Forms.Label();
            this.uiSupplierComboBox = new System.Windows.Forms.ComboBox();
            this.uiListTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiSupplierLabel
            // 
            this.uiSupplierLabel.AutoSize = true;
            this.uiSupplierLabel.Location = new System.Drawing.Point(12, 15);
            this.uiSupplierLabel.Name = "uiSupplierLabel";
            this.uiSupplierLabel.Size = new System.Drawing.Size(45, 13);
            this.uiSupplierLabel.TabIndex = 0;
            this.uiSupplierLabel.Text = "Supplier";
            // 
            // uiSupplierComboBox
            // 
            this.uiSupplierComboBox.FormattingEnabled = true;
            this.uiSupplierComboBox.Location = new System.Drawing.Point(63, 12);
            this.uiSupplierComboBox.Name = "uiSupplierComboBox";
            this.uiSupplierComboBox.Size = new System.Drawing.Size(121, 21);
            this.uiSupplierComboBox.TabIndex = 1;
            this.uiSupplierComboBox.SelectedIndexChanged += new System.EventHandler(this.uiSupplierComboBox_SelectedIndexChanged);
            // 
            // uiListTextBox
            // 
            this.uiListTextBox.Location = new System.Drawing.Point(15, 39);
            this.uiListTextBox.Multiline = true;
            this.uiListTextBox.Name = "uiListTextBox";
            this.uiListTextBox.ReadOnly = true;
            this.uiListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uiListTextBox.Size = new System.Drawing.Size(169, 399);
            this.uiListTextBox.TabIndex = 2;
            // 
            // ItemRestockListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 450);
            this.Controls.Add(this.uiListTextBox);
            this.Controls.Add(this.uiSupplierComboBox);
            this.Controls.Add(this.uiSupplierLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemRestockListForm";
            this.ShowIcon = false;
            this.Text = "Item Restock List";
            this.Load += new System.EventHandler(this.ItemRestockListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiSupplierLabel;
        private System.Windows.Forms.ComboBox uiSupplierComboBox;
        private System.Windows.Forms.TextBox uiListTextBox;
    }
}