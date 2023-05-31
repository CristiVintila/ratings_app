namespace proiectPAW.Forms.AdminView
{
    partial class AdaugaLocatie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adaugaLocatieButton = new System.Windows.Forms.Button();
            this.locatieTextbox = new System.Windows.Forms.TextBox();
            this.pretTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Locatie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pret";
            // 
            // adaugaLocatieButton
            // 
            this.adaugaLocatieButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.adaugaLocatieButton.Location = new System.Drawing.Point(113, 131);
            this.adaugaLocatieButton.Name = "adaugaLocatieButton";
            this.adaugaLocatieButton.Size = new System.Drawing.Size(116, 33);
            this.adaugaLocatieButton.TabIndex = 2;
            this.adaugaLocatieButton.Text = "Adauga Locatie";
            this.adaugaLocatieButton.UseVisualStyleBackColor = false;
            this.adaugaLocatieButton.Click += new System.EventHandler(this.adaugaLocatieButton_Click);
            // 
            // locatieTextbox
            // 
            this.locatieTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.locatieTextbox.Location = new System.Drawing.Point(77, 31);
            this.locatieTextbox.Name = "locatieTextbox";
            this.locatieTextbox.Size = new System.Drawing.Size(175, 20);
            this.locatieTextbox.TabIndex = 3;
            // 
            // pretTextbox
            // 
            this.pretTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pretTextbox.Location = new System.Drawing.Point(77, 83);
            this.pretTextbox.Name = "pretTextbox";
            this.pretTextbox.Size = new System.Drawing.Size(125, 20);
            this.pretTextbox.TabIndex = 4;
            // 
            // AdaugaLocatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(344, 176);
            this.Controls.Add(this.pretTextbox);
            this.Controls.Add(this.locatieTextbox);
            this.Controls.Add(this.adaugaLocatieButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaLocatie";
            this.Text = "AdaugaLocatie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adaugaLocatieButton;
        private System.Windows.Forms.TextBox locatieTextbox;
        private System.Windows.Forms.TextBox pretTextbox;
    }
}