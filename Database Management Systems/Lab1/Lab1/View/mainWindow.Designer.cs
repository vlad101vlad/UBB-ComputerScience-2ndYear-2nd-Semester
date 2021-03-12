namespace Lab1
{
    partial class mainWindow
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.ubbPictureBox = new System.Windows.Forms.PictureBox();
            this.parentTableGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ubbPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentTableGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(9, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(985, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome! Let\'s manage some databases";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ubbPictureBox
            // 
            this.ubbPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ubbPictureBox.Image = global::Lab1.Properties.Resources.ubbLogo;
            this.ubbPictureBox.Location = new System.Drawing.Point(523, 626);
            this.ubbPictureBox.Margin = new System.Windows.Forms.Padding(3, 3, 16, 16);
            this.ubbPictureBox.Name = "ubbPictureBox";
            this.ubbPictureBox.Size = new System.Drawing.Size(470, 80);
            this.ubbPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ubbPictureBox.TabIndex = 1;
            this.ubbPictureBox.TabStop = false;
            // 
            // parentTableGridView
            // 
            this.parentTableGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parentTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentTableGridView.Location = new System.Drawing.Point(24, 61);
            this.parentTableGridView.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.parentTableGridView.Name = "parentTableGridView";
            this.parentTableGridView.RowHeadersWidth = 51;
            this.parentTableGridView.RowTemplate.Height = 24;
            this.parentTableGridView.Size = new System.Drawing.Size(958, 450);
            this.parentTableGridView.TabIndex = 2;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.parentTableGridView);
            this.Controls.Add(this.ubbPictureBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ubbPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentTableGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox ubbPictureBox;
        private System.Windows.Forms.DataGridView parentTableGridView;



    }
}

