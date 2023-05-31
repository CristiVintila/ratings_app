namespace proiectPAW.Forms.AdminView
{
    partial class EditLocatie
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
            this.pretTextbox = new System.Windows.Forms.TextBox();
            this.locatieTextbox = new System.Windows.Forms.TextBox();
            this.modificaLocatieButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pretTextbox
            // 
            this.pretTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pretTextbox.Location = new System.Drawing.Point(78, 64);
            this.pretTextbox.Name = "pretTextbox";
            this.pretTextbox.Size = new System.Drawing.Size(125, 20);
            this.pretTextbox.TabIndex = 9;
            // 
            // locatieTextbox
            // 
            this.locatieTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.locatieTextbox.Location = new System.Drawing.Point(78, 12);
            this.locatieTextbox.Name = "locatieTextbox";
            this.locatieTextbox.Size = new System.Drawing.Size(175, 20);
            this.locatieTextbox.TabIndex = 8;
            // 
            // modificaLocatieButton
            // 
            this.modificaLocatieButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.modificaLocatieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaLocatieButton.Location = new System.Drawing.Point(103, 115);
            this.modificaLocatieButton.Name = "modificaLocatieButton";
            this.modificaLocatieButton.Size = new System.Drawing.Size(93, 30);
            this.modificaLocatieButton.TabIndex = 7;
            this.modificaLocatieButton.Text = "Modifica";
            this.modificaLocatieButton.UseVisualStyleBackColor = false;
            this.modificaLocatieButton.Click += new System.EventHandler(this.modificaLocatieButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pret";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Locatie";
            // 
            // EditLocatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(274, 159);
            this.Controls.Add(this.pretTextbox);
            this.Controls.Add(this.locatieTextbox);
            this.Controls.Add(this.modificaLocatieButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditLocatie";
            this.Text = "EditLocatie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pretTextbox;
        private System.Windows.Forms.TextBox locatieTextbox;
        private System.Windows.Forms.Button modificaLocatieButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}