namespace proiectPAW.Forms.AdminView
{
    partial class AdminCalatori
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
            this.calatoriDatagrid = new System.Windows.Forms.DataGridView();
            this.addCalatorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.calatoriDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // calatoriDatagrid
            // 
            this.calatoriDatagrid.AllowUserToAddRows = false;
            this.calatoriDatagrid.AllowUserToDeleteRows = false;
            this.calatoriDatagrid.BackgroundColor = System.Drawing.Color.Silver;
            this.calatoriDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calatoriDatagrid.Location = new System.Drawing.Point(13, 52);
            this.calatoriDatagrid.Name = "calatoriDatagrid";
            this.calatoriDatagrid.ReadOnly = true;
            this.calatoriDatagrid.Size = new System.Drawing.Size(775, 386);
            this.calatoriDatagrid.TabIndex = 0;
            this.calatoriDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calatoriDatagrid_CellClick);
            // 
            // addCalatorButton
            // 
            this.addCalatorButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.addCalatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCalatorButton.Location = new System.Drawing.Point(13, 13);
            this.addCalatorButton.Name = "addCalatorButton";
            this.addCalatorButton.Size = new System.Drawing.Size(125, 33);
            this.addCalatorButton.TabIndex = 1;
            this.addCalatorButton.Text = "Adauga Calator";
            this.addCalatorButton.UseVisualStyleBackColor = false;
            this.addCalatorButton.Click += new System.EventHandler(this.addCalatorButton_Click);
            // 
            // AdminCalatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCalatorButton);
            this.Controls.Add(this.calatoriDatagrid);
            this.Name = "AdminCalatori";
            this.Text = "AdminCalatori";
            ((System.ComponentModel.ISupportInitialize)(this.calatoriDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView calatoriDatagrid;
        private System.Windows.Forms.Button addCalatorButton;
    }
}