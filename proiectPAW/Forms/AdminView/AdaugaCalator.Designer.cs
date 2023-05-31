namespace proiectPAW.Forms.AdminView
{
    partial class AdaugaCalator
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
            this.label3 = new System.Windows.Forms.Label();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.utilizatorTextbox = new System.Windows.Forms.TextBox();
            this.parolaTextbox = new System.Windows.Forms.TextBox();
            this.confirmaTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirma Parola";
            // 
            // addAccountButton
            // 
            this.addAccountButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.addAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccountButton.Location = new System.Drawing.Point(134, 148);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(105, 30);
            this.addAccountButton.TabIndex = 3;
            this.addAccountButton.Text = "Creeaza Cont ";
            this.addAccountButton.UseVisualStyleBackColor = false;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // utilizatorTextbox
            // 
            this.utilizatorTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.utilizatorTextbox.Location = new System.Drawing.Point(134, 10);
            this.utilizatorTextbox.Name = "utilizatorTextbox";
            this.utilizatorTextbox.Size = new System.Drawing.Size(178, 20);
            this.utilizatorTextbox.TabIndex = 4;
            // 
            // parolaTextbox
            // 
            this.parolaTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parolaTextbox.Location = new System.Drawing.Point(134, 53);
            this.parolaTextbox.Name = "parolaTextbox";
            this.parolaTextbox.PasswordChar = '*';
            this.parolaTextbox.Size = new System.Drawing.Size(178, 20);
            this.parolaTextbox.TabIndex = 5;
            // 
            // confirmaTextbox
            // 
            this.confirmaTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.confirmaTextbox.Location = new System.Drawing.Point(134, 96);
            this.confirmaTextbox.Name = "confirmaTextbox";
            this.confirmaTextbox.PasswordChar = '*';
            this.confirmaTextbox.Size = new System.Drawing.Size(178, 20);
            this.confirmaTextbox.TabIndex = 6;
            // 
            // AdaugaCalator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(358, 190);
            this.Controls.Add(this.confirmaTextbox);
            this.Controls.Add(this.parolaTextbox);
            this.Controls.Add(this.utilizatorTextbox);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaCalator";
            this.Text = "AdaugaCalator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.TextBox utilizatorTextbox;
        private System.Windows.Forms.TextBox parolaTextbox;
        private System.Windows.Forms.TextBox confirmaTextbox;
    }
}