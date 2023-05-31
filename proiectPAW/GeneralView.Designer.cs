namespace proiectPAW
{
    partial class GeneralView
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
            this.locatiiDatagrid = new System.Windows.Forms.DataGridView();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.locatiiDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // locatiiDatagrid
            // 
            this.locatiiDatagrid.AllowUserToAddRows = false;
            this.locatiiDatagrid.AllowUserToDeleteRows = false;
            this.locatiiDatagrid.BackgroundColor = System.Drawing.Color.Silver;
            this.locatiiDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locatiiDatagrid.Location = new System.Drawing.Point(12, 12);
            this.locatiiDatagrid.Name = "locatiiDatagrid";
            this.locatiiDatagrid.ReadOnly = true;
            this.locatiiDatagrid.RowHeadersWidth = 51;
            this.locatiiDatagrid.Size = new System.Drawing.Size(451, 383);
            this.locatiiDatagrid.TabIndex = 0;
            this.locatiiDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.locatiiDatagrid_CellClick);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.logoutButton.Location = new System.Drawing.Point(377, 401);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(85, 40);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // GeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.locatiiDatagrid);
            this.Name = "GeneralView";
            this.Text = "GeneralView";
            ((System.ComponentModel.ISupportInitialize)(this.locatiiDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView locatiiDatagrid;
        private System.Windows.Forms.Button logoutButton;
    }
}