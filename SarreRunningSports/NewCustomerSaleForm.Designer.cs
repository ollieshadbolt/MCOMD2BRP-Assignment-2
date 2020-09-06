namespace SarreRunningSports
{
    partial class NewCustomerSaleForm
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
            this.uiNameLabel = new System.Windows.Forms.Label();
            this.uiNameTextBox = new System.Windows.Forms.TextBox();
            this.uiEmailTextBox = new System.Windows.Forms.TextBox();
            this.uiGDPRCheckBox = new System.Windows.Forms.CheckBox();
            this.uiSubmitButton = new System.Windows.Forms.Button();
            this.uiEmailLabel = new System.Windows.Forms.Label();
            this.uiGDPRLabel = new System.Windows.Forms.Label();
            this.uiItemComboBox = new System.Windows.Forms.ComboBox();
            this.uiItemLabel = new System.Windows.Forms.Label();
            this.uiSaleDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiSaleDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiNameLabel
            // 
            this.uiNameLabel.AutoSize = true;
            this.uiNameLabel.Location = new System.Drawing.Point(12, 15);
            this.uiNameLabel.Name = "uiNameLabel";
            this.uiNameLabel.Size = new System.Drawing.Size(35, 13);
            this.uiNameLabel.TabIndex = 0;
            this.uiNameLabel.Text = "Name";
            // 
            // uiNameTextBox
            // 
            this.uiNameTextBox.Location = new System.Drawing.Point(72, 12);
            this.uiNameTextBox.Name = "uiNameTextBox";
            this.uiNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.uiNameTextBox.TabIndex = 0;
            // 
            // uiEmailTextBox
            // 
            this.uiEmailTextBox.Location = new System.Drawing.Point(72, 38);
            this.uiEmailTextBox.Name = "uiEmailTextBox";
            this.uiEmailTextBox.Size = new System.Drawing.Size(156, 20);
            this.uiEmailTextBox.TabIndex = 1;
            // 
            // uiGDPRCheckBox
            // 
            this.uiGDPRCheckBox.AutoSize = true;
            this.uiGDPRCheckBox.Location = new System.Drawing.Point(72, 66);
            this.uiGDPRCheckBox.Name = "uiGDPRCheckBox";
            this.uiGDPRCheckBox.Size = new System.Drawing.Size(15, 14);
            this.uiGDPRCheckBox.TabIndex = 2;
            this.uiGDPRCheckBox.UseVisualStyleBackColor = true;
            // 
            // uiSubmitButton
            // 
            this.uiSubmitButton.Location = new System.Drawing.Point(15, 141);
            this.uiSubmitButton.Name = "uiSubmitButton";
            this.uiSubmitButton.Size = new System.Drawing.Size(214, 23);
            this.uiSubmitButton.TabIndex = 5;
            this.uiSubmitButton.Text = "Submit";
            this.uiSubmitButton.UseVisualStyleBackColor = true;
            this.uiSubmitButton.Click += new System.EventHandler(this.uiSubmitButton_Click);
            // 
            // uiEmailLabel
            // 
            this.uiEmailLabel.AutoSize = true;
            this.uiEmailLabel.Location = new System.Drawing.Point(12, 41);
            this.uiEmailLabel.Name = "uiEmailLabel";
            this.uiEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.uiEmailLabel.TabIndex = 5;
            this.uiEmailLabel.Text = "Email";
            // 
            // uiGDPRLabel
            // 
            this.uiGDPRLabel.AutoSize = true;
            this.uiGDPRLabel.Location = new System.Drawing.Point(12, 66);
            this.uiGDPRLabel.Name = "uiGDPRLabel";
            this.uiGDPRLabel.Size = new System.Drawing.Size(38, 13);
            this.uiGDPRLabel.TabIndex = 6;
            this.uiGDPRLabel.Text = "GDPR";
            // 
            // uiItemComboBox
            // 
            this.uiItemComboBox.FormattingEnabled = true;
            this.uiItemComboBox.Location = new System.Drawing.Point(72, 114);
            this.uiItemComboBox.Name = "uiItemComboBox";
            this.uiItemComboBox.Size = new System.Drawing.Size(156, 21);
            this.uiItemComboBox.TabIndex = 4;
            // 
            // uiItemLabel
            // 
            this.uiItemLabel.AutoSize = true;
            this.uiItemLabel.Location = new System.Drawing.Point(12, 117);
            this.uiItemLabel.Name = "uiItemLabel";
            this.uiItemLabel.Size = new System.Drawing.Size(27, 13);
            this.uiItemLabel.TabIndex = 8;
            this.uiItemLabel.Text = "Item";
            // 
            // uiSaleDateDateTimePicker
            // 
            this.uiSaleDateDateTimePicker.Location = new System.Drawing.Point(72, 86);
            this.uiSaleDateDateTimePicker.Name = "uiSaleDateDateTimePicker";
            this.uiSaleDateDateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.uiSaleDateDateTimePicker.TabIndex = 3;
            // 
            // uiSaleDateLabel
            // 
            this.uiSaleDateLabel.AutoSize = true;
            this.uiSaleDateLabel.Location = new System.Drawing.Point(12, 92);
            this.uiSaleDateLabel.Name = "uiSaleDateLabel";
            this.uiSaleDateLabel.Size = new System.Drawing.Size(54, 13);
            this.uiSaleDateLabel.TabIndex = 10;
            this.uiSaleDateLabel.Text = "Sale Date";
            // 
            // NewCustomerSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 176);
            this.Controls.Add(this.uiSaleDateLabel);
            this.Controls.Add(this.uiSaleDateDateTimePicker);
            this.Controls.Add(this.uiItemLabel);
            this.Controls.Add(this.uiItemComboBox);
            this.Controls.Add(this.uiGDPRLabel);
            this.Controls.Add(this.uiEmailLabel);
            this.Controls.Add(this.uiSubmitButton);
            this.Controls.Add(this.uiGDPRCheckBox);
            this.Controls.Add(this.uiEmailTextBox);
            this.Controls.Add(this.uiNameTextBox);
            this.Controls.Add(this.uiNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCustomerSaleForm";
            this.ShowIcon = false;
            this.Text = "New Customer Sale";
            this.Load += new System.EventHandler(this.NewCustomerSaleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.TextBox uiNameTextBox;
        private System.Windows.Forms.TextBox uiEmailTextBox;
        private System.Windows.Forms.CheckBox uiGDPRCheckBox;
        private System.Windows.Forms.Button uiSubmitButton;
        private System.Windows.Forms.Label uiEmailLabel;
        private System.Windows.Forms.Label uiGDPRLabel;
        private System.Windows.Forms.ComboBox uiItemComboBox;
        private System.Windows.Forms.Label uiItemLabel;
        private System.Windows.Forms.DateTimePicker uiSaleDateDateTimePicker;
        private System.Windows.Forms.Label uiSaleDateLabel;
    }
}