namespace SarreRunningSports
{
    partial class ExistingCustomerSaleForm
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
            this.uiItemComboBox = new System.Windows.Forms.ComboBox();
            this.uiSubmitButton = new System.Windows.Forms.Button();
            this.uiItemLabel = new System.Windows.Forms.Label();
            this.uiSaleDateLabel = new System.Windows.Forms.Label();
            this.uiSaleDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uiCustomerLabel
            // 
            this.uiCustomerLabel.AutoSize = true;
            this.uiCustomerLabel.Location = new System.Drawing.Point(12, 13);
            this.uiCustomerLabel.Name = "uiCustomerLabel";
            this.uiCustomerLabel.Size = new System.Drawing.Size(51, 13);
            this.uiCustomerLabel.TabIndex = 0;
            this.uiCustomerLabel.Text = "Customer";
            // 
            // uiCustomerComboBox
            // 
            this.uiCustomerComboBox.FormattingEnabled = true;
            this.uiCustomerComboBox.Location = new System.Drawing.Point(70, 10);
            this.uiCustomerComboBox.Name = "uiCustomerComboBox";
            this.uiCustomerComboBox.Size = new System.Drawing.Size(200, 21);
            this.uiCustomerComboBox.TabIndex = 1;
            // 
            // uiItemComboBox
            // 
            this.uiItemComboBox.FormattingEnabled = true;
            this.uiItemComboBox.Location = new System.Drawing.Point(70, 37);
            this.uiItemComboBox.Name = "uiItemComboBox";
            this.uiItemComboBox.Size = new System.Drawing.Size(200, 21);
            this.uiItemComboBox.TabIndex = 2;
            // 
            // uiSubmitButton
            // 
            this.uiSubmitButton.Location = new System.Drawing.Point(15, 90);
            this.uiSubmitButton.Name = "uiSubmitButton";
            this.uiSubmitButton.Size = new System.Drawing.Size(256, 23);
            this.uiSubmitButton.TabIndex = 4;
            this.uiSubmitButton.Text = "Submit";
            this.uiSubmitButton.UseVisualStyleBackColor = true;
            this.uiSubmitButton.Click += new System.EventHandler(this.uiSubmitButton_Click);
            // 
            // uiItemLabel
            // 
            this.uiItemLabel.AutoSize = true;
            this.uiItemLabel.Location = new System.Drawing.Point(12, 40);
            this.uiItemLabel.Name = "uiItemLabel";
            this.uiItemLabel.Size = new System.Drawing.Size(27, 13);
            this.uiItemLabel.TabIndex = 6;
            this.uiItemLabel.Text = "Item";
            // 
            // uiSaleDateLabel
            // 
            this.uiSaleDateLabel.AutoSize = true;
            this.uiSaleDateLabel.Location = new System.Drawing.Point(12, 70);
            this.uiSaleDateLabel.Name = "uiSaleDateLabel";
            this.uiSaleDateLabel.Size = new System.Drawing.Size(54, 13);
            this.uiSaleDateLabel.TabIndex = 7;
            this.uiSaleDateLabel.Text = "Sale Date";
            // 
            // uiSaleDateDateTimePicker
            // 
            this.uiSaleDateDateTimePicker.Location = new System.Drawing.Point(70, 64);
            this.uiSaleDateDateTimePicker.Name = "uiSaleDateDateTimePicker";
            this.uiSaleDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.uiSaleDateDateTimePicker.TabIndex = 3;
            // 
            // ExistingCustomerSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 123);
            this.Controls.Add(this.uiSaleDateDateTimePicker);
            this.Controls.Add(this.uiSaleDateLabel);
            this.Controls.Add(this.uiItemLabel);
            this.Controls.Add(this.uiSubmitButton);
            this.Controls.Add(this.uiItemComboBox);
            this.Controls.Add(this.uiCustomerComboBox);
            this.Controls.Add(this.uiCustomerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExistingCustomerSaleForm";
            this.ShowIcon = false;
            this.Text = "Existing Customer Sale";
            this.Load += new System.EventHandler(this.ExistingCustomerSaleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiCustomerLabel;
        private System.Windows.Forms.ComboBox uiCustomerComboBox;
        private System.Windows.Forms.ComboBox uiItemComboBox;
        private System.Windows.Forms.Button uiSubmitButton;
        private System.Windows.Forms.Label uiItemLabel;
        private System.Windows.Forms.Label uiSaleDateLabel;
        private System.Windows.Forms.DateTimePicker uiSaleDateDateTimePicker;
    }
}