namespace proiectPAW.Forms.AdminView
{
    partial class AdminLocatii
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
            this.addLocatieButton = new System.Windows.Forms.Button();
            this.locatiiDatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.locatiiDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addLocatieButton
            // 
            this.addLocatieButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.addLocatieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLocatieButton.Location = new System.Drawing.Point(13, 13);
            this.addLocatieButton.Name = "addLocatieButton";
            this.addLocatieButton.Size = new System.Drawing.Size(122, 33);
            this.addLocatieButton.TabIndex = 3;
            this.addLocatieButton.Text = "Adauga Locatie";
            this.addLocatieButton.UseVisualStyleBackColor = false;
            this.addLocatieButton.Click += new System.EventHandler(this.addLocatieButton_Click);
            // 
            // locatiiDatagrid
            // 
            this.locatiiDatagrid.AllowUserToAddRows = false;
            this.locatiiDatagrid.AllowUserToDeleteRows = false;
            this.locatiiDatagrid.BackgroundColor = System.Drawing.Color.Silver;
            this.locatiiDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locatiiDatagrid.Location = new System.Drawing.Point(13, 52);
            this.locatiiDatagrid.Name = "locatiiDatagrid";
            this.locatiiDatagrid.ReadOnly = true;
            this.locatiiDatagrid.Size = new System.Drawing.Size(775, 386);
            this.locatiiDatagrid.TabIndex = 2;
            this.locatiiDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.locatiiDatagrid_CellClick);
            // 
            // AdminLocatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addLocatieButton);
            this.Controls.Add(this.locatiiDatagrid);
            this.Name = "AdminLocatii";
            this.Text = "AdminLocatii";
            ((System.ComponentModel.ISupportInitialize)(this.locatiiDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addLocatieButton;
        private System.Windows.Forms.DataGridView locatiiDatagrid;
    }
}