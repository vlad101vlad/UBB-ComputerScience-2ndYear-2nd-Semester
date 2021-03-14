namespace Lab1
{
    partial class CitiesWindow
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
            this.informationLabel = new System.Windows.Forms.Label();
            this.countyLabel = new System.Windows.Forms.Label();
            this.citiesDataGridView = new System.Windows.Forms.DataGridView();
            this.addNewCityButton = new System.Windows.Forms.Button();
            this.updateSelectedCityButton = new System.Windows.Forms.Button();
            this.deleteSelectedCityButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.informationLabel.Location = new System.Drawing.Point(12, 9);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(259, 25);
            this.informationLabel.TabIndex = 0;
            this.informationLabel.Text = "Showing cities for the county";
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.countyLabel.Location = new System.Drawing.Point(293, 9);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(133, 25);
            this.countyLabel.TabIndex = 1;
            this.countyLabel.Text = "someCounty";
            // 
            // citiesDataGridView
            // 
            this.citiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesDataGridView.Location = new System.Drawing.Point(17, 54);
            this.citiesDataGridView.MultiSelect = false;
            this.citiesDataGridView.Name = "citiesDataGridView";
            this.citiesDataGridView.RowHeadersWidth = 51;
            this.citiesDataGridView.ReadOnly = true;
            this.citiesDataGridView.RowTemplate.Height = 24;
            this.citiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.citiesDataGridView.Size = new System.Drawing.Size(771, 260);
            this.citiesDataGridView.TabIndex = 2;
            this.citiesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.citiesDataGridView_DataBindingComplete);
            // 
            // addNewCityButton
            // 
            this.addNewCityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNewCityButton.Location = new System.Drawing.Point(3, 3);
            this.addNewCityButton.Name = "addNewCityButton";
            this.addNewCityButton.Size = new System.Drawing.Size(765, 29);
            this.addNewCityButton.TabIndex = 3;
            this.addNewCityButton.Text = "Add new city";
            this.addNewCityButton.UseVisualStyleBackColor = true;
            this.addNewCityButton.Click += new System.EventHandler(this.addNewCityButton_Click);
            // 
            // updateSelectedCityButton
            // 
            this.updateSelectedCityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateSelectedCityButton.Location = new System.Drawing.Point(3, 3);
            this.updateSelectedCityButton.Name = "updateSelectedCityButton";
            this.updateSelectedCityButton.Size = new System.Drawing.Size(379, 29);
            this.updateSelectedCityButton.TabIndex = 4;
            this.updateSelectedCityButton.Text = "Update selected";
            this.updateSelectedCityButton.UseVisualStyleBackColor = true;
            this.updateSelectedCityButton.Click += new System.EventHandler(this.updateSelectedCityButton_Click);
            // 
            // deleteSelectedCityButton
            // 
            this.deleteSelectedCityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteSelectedCityButton.Location = new System.Drawing.Point(388, 3);
            this.deleteSelectedCityButton.Name = "deleteSelectedCityButton";
            this.deleteSelectedCityButton.Size = new System.Drawing.Size(380, 29);
            this.deleteSelectedCityButton.TabIndex = 5;
            this.deleteSelectedCityButton.Text = "Delete Selected";
            this.deleteSelectedCityButton.UseVisualStyleBackColor = true;
            this.deleteSelectedCityButton.Click += new System.EventHandler(this.deleteSelectedCityButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.updateSelectedCityButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteSelectedCityButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 362);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(771, 35);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.addNewCityButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 320);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(771, 35);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // CitiesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.citiesDataGridView);
            this.Controls.Add(this.countyLabel);
            this.Controls.Add(this.informationLabel);
            this.Name = "CitiesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CitiesWindow";
            this.Load += new System.EventHandler(this.CitiesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label countyLabel;
        private System.Windows.Forms.DataGridView citiesDataGridView;
        private System.Windows.Forms.Button addNewCityButton;
        private System.Windows.Forms.Button updateSelectedCityButton;
        private System.Windows.Forms.Button deleteSelectedCityButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}