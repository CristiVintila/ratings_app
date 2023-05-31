namespace proiectPAW.Forms.AdminView
{
    partial class EditCalator
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
            this.parolaTextbox = new System.Windows.Forms.TextBox();
            this.utilizatorTextbox = new System.Windows.Forms.TextBox();
            this.editAccountButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parolaTextbox
            // 
            this.parolaTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parolaTextbox.Location = new System.Drawing.Point(121, 58);
            this.parolaTextbox.Name = "parolaTextbox";
            this.parolaTextbox.Size = new System.Drawing.Size(178, 20);
            this.parolaTextbox.TabIndex = 12;
            // 
            // utilizatorTextbox
            // 
            this.utilizatorTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.utilizatorTextbox.Location = new System.Drawing.Point(121, 12);
            this.utilizatorTextbox.Name = "utilizatorTextbox";
            this.utilizatorTextbox.Size = new System.Drawing.Size(178, 20);
            this.utilizatorTextbox.TabIndex = 11;
            // 
            // editAccountButton
            // 
            this.editAccountButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.editAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAccountButton.Location = new System.Drawing.Point(170, 99);
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.Size = new System.Drawing.Size(129, 34);
            this.editAccountButton.TabIndex = 10;
            this.editAccountButton.Text = "Salveaza Modificari";
            this.editAccountButton.UseVisualStyleBackColor = false;
            this.editAccountButton.Click += new System.EventHandler(this.editAccountButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Utilizator";
            // 
            // EditCalator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(315, 139);
            this.Controls.Add(this.parolaTextbox);
            this.Controls.Add(this.utilizatorTextbox);
            this.Controls.Add(this.editAccountButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCalator";
            this.Text = "EditCalator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox parolaTextbox;
        private System.Windows.Forms.TextBox utilizatorTextbox;
        private System.Windows.Forms.Button editAccountButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}