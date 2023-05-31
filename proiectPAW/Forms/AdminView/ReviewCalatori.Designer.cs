namespace proiectPAW.Forms.AdminView
{
    partial class ReviewCalatori
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
            this.reviewDatagrid = new System.Windows.Forms.DataGridView();
            this.calatorTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.reviewDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewDatagrid
            // 
            this.reviewDatagrid.AllowUserToAddRows = false;
            this.reviewDatagrid.AllowUserToDeleteRows = false;
            this.reviewDatagrid.BackgroundColor = System.Drawing.Color.Silver;
            this.reviewDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewDatagrid.Location = new System.Drawing.Point(13, 53);
            this.reviewDatagrid.Name = "reviewDatagrid";
            this.reviewDatagrid.ReadOnly = true;
            this.reviewDatagrid.Size = new System.Drawing.Size(775, 385);
            this.reviewDatagrid.TabIndex = 0;
            this.reviewDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reviewDatagrid_CellClick);
            // 
            // calatorTextbox
            // 
            this.calatorTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.calatorTextbox.Enabled = false;
            this.calatorTextbox.Location = new System.Drawing.Point(13, 13);
            this.calatorTextbox.Name = "calatorTextbox";
            this.calatorTextbox.Size = new System.Drawing.Size(167, 20);
            this.calatorTextbox.TabIndex = 1;
            // 
            // ReviewCalatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calatorTextbox);
            this.Controls.Add(this.reviewDatagrid);
            this.Name = "ReviewCalatori";
            this.Text = "ReviewCalatori";
            ((System.ComponentModel.ISupportInitialize)(this.reviewDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reviewDatagrid;
        private System.Windows.Forms.TextBox calatorTextbox;
    }
}