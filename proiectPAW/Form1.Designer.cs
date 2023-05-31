namespace proiectPAW
{
    partial class Form1
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
            this.utilizatorTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.newaccLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // utilizatorTextBox
            // 
            this.utilizatorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.utilizatorTextBox.Location = new System.Drawing.Point(108, 59);
            this.utilizatorTextBox.Name = "utilizatorTextBox";
            this.utilizatorTextBox.Size = new System.Drawing.Size(200, 20);
            this.utilizatorTextBox.TabIndex = 2;
            // 
            // parolaTextbox
            // 
            this.parolaTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parolaTextbox.Location = new System.Drawing.Point(108, 130);
            this.parolaTextbox.Name = "parolaTextbox";
            this.parolaTextbox.PasswordChar = '*';
            this.parolaTextbox.Size = new System.Drawing.Size(200, 20);
            this.parolaTextbox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(124, 190);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(162, 35);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Intra in cont";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // newaccLabel
            // 
            this.newaccLabel.AutoSize = true;
            this.newaccLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.newaccLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newaccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaccLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.newaccLabel.Location = new System.Drawing.Point(205, 82);
            this.newaccLabel.Name = "newaccLabel";
            this.newaccLabel.Size = new System.Drawing.Size(103, 16);
            this.newaccLabel.TabIndex = 5;
            this.newaccLabel.Text = "Creeaza un cont";
            this.newaccLabel.Click += new System.EventHandler(this.newaccLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(392, 270);
            this.Controls.Add(this.newaccLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.parolaTextbox);
            this.Controls.Add(this.utilizatorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox utilizatorTextBox;
        private System.Windows.Forms.TextBox parolaTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label newaccLabel;
    }
}

