namespace Lab1.View
{
    partial class addUpdateForm
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
            this.cityNameLabel = new System.Windows.Forms.Label();
            this.cityCountyIDLabel = new System.Windows.Forms.Label();
            this.cityIDLabel = new System.Windows.Forms.Label();
            this.addUpdateFormLayout = new System.Windows.Forms.TableLayoutPanel();
            this.countyIDTextBox = new System.Windows.Forms.TextBox();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.cityIDTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.addUpdateFormLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityNameLabel
            // 
            this.cityNameLabel.AutoSize = true;
            this.cityNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.cityNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cityNameLabel.Location = new System.Drawing.Point(33, 31);
            this.cityNameLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityNameLabel.Name = "cityNameLabel";
            this.cityNameLabel.Size = new System.Drawing.Size(64, 25);
            this.cityNameLabel.TabIndex = 0;
            this.cityNameLabel.Text = "Name";
            // 
            // cityCountyIDLabel
            // 
            this.cityCountyIDLabel.AutoSize = true;
            this.cityCountyIDLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.cityCountyIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cityCountyIDLabel.Location = new System.Drawing.Point(3, 60);
            this.cityCountyIDLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityCountyIDLabel.Name = "cityCountyIDLabel";
            this.cityCountyIDLabel.Size = new System.Drawing.Size(94, 25);
            this.cityCountyIDLabel.TabIndex = 1;
            this.cityCountyIDLabel.Text = "CountyID";
            // 
            // cityIDLabel
            // 
            this.cityIDLabel.AutoSize = true;
            this.cityIDLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.cityIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cityIDLabel.Location = new System.Drawing.Point(32, 2);
            this.cityIDLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityIDLabel.Name = "cityIDLabel";
            this.cityIDLabel.Size = new System.Drawing.Size(65, 25);
            this.cityIDLabel.TabIndex = 2;
            this.cityIDLabel.Text = "CityID";
            // 
            // addUpdateFormLayout
            // 
            this.addUpdateFormLayout.ColumnCount = 2;
            this.addUpdateFormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.addUpdateFormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addUpdateFormLayout.Controls.Add(this.countyIDTextBox, 1, 2);
            this.addUpdateFormLayout.Controls.Add(this.cityNameTextBox, 1, 1);
            this.addUpdateFormLayout.Controls.Add(this.cityIDLabel, 0, 0);
            this.addUpdateFormLayout.Controls.Add(this.cityCountyIDLabel, 0, 2);
            this.addUpdateFormLayout.Controls.Add(this.cityNameLabel, 0, 1);
            this.addUpdateFormLayout.Controls.Add(this.cityIDTextBox, 1, 0);
            this.addUpdateFormLayout.Location = new System.Drawing.Point(86, 113);
            this.addUpdateFormLayout.Name = "addUpdateFormLayout";
            this.addUpdateFormLayout.RowCount = 3;
            this.addUpdateFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.addUpdateFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.addUpdateFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.addUpdateFormLayout.Size = new System.Drawing.Size(416, 86);
            this.addUpdateFormLayout.TabIndex = 3;
            // 
            // countyIDTextBox
            // 
            this.countyIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countyIDTextBox.Location = new System.Drawing.Point(103, 61);
            this.countyIDTextBox.Name = "countyIDTextBox";
            this.countyIDTextBox.ReadOnly = true;
            this.countyIDTextBox.Size = new System.Drawing.Size(310, 22);
            this.countyIDTextBox.TabIndex = 5;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityNameTextBox.Location = new System.Drawing.Point(103, 32);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(310, 22);
            this.cityNameTextBox.TabIndex = 4;
            // 
            // cityIDTextBox
            // 
            this.cityIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityIDTextBox.Enabled = false;
            this.cityIDTextBox.Location = new System.Drawing.Point(103, 3);
            this.cityIDTextBox.Name = "cityIDTextBox";
            this.cityIDTextBox.ReadOnly = true;
            this.cityIDTextBox.Size = new System.Drawing.Size(310, 22);
            this.cityIDTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(189, 261);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(212, 56);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(616, 395);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addUpdateFormLayout);
            this.Name = "addUpdateForm";
            this.Text = "addUpdateForm";
            this.Load += new System.EventHandler(this.addUpdateForm_Load);
            this.addUpdateFormLayout.ResumeLayout(false);
            this.addUpdateFormLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cityNameLabel;
        private System.Windows.Forms.Label cityCountyIDLabel;
        private System.Windows.Forms.Label cityIDLabel;
        private System.Windows.Forms.TableLayoutPanel addUpdateFormLayout;
        private System.Windows.Forms.TextBox countyIDTextBox;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.TextBox cityIDTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}