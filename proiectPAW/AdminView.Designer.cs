namespace proiectPAW
{
    partial class AdminView
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
            this.calatoriButton = new System.Windows.Forms.Button();
            this.locatiiButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calatoriButton
            // 
            this.calatoriButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.calatoriButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calatoriButton.Location = new System.Drawing.Point(12, 47);
            this.calatoriButton.Name = "calatoriButton";
            this.calatoriButton.Size = new System.Drawing.Size(172, 90);
            this.calatoriButton.TabIndex = 0;
            this.calatoriButton.Text = "Calatori";
            this.calatoriButton.UseVisualStyleBackColor = false;
            this.calatoriButton.Click += new System.EventHandler(this.calatoriButton_Click);
            // 
            // locatiiButton
            // 
            this.locatiiButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.locatiiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locatiiButton.Location = new System.Drawing.Point(289, 47);
            this.locatiiButton.Name = "locatiiButton";
            this.locatiiButton.Size = new System.Drawing.Size(172, 90);
            this.locatiiButton.TabIndex = 1;
            this.locatiiButton.Text = "Locatii";
            this.locatiiButton.UseVisualStyleBackColor = false;
            this.locatiiButton.Click += new System.EventHandler(this.locatiiButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(179, 168);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(116, 44);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(473, 224);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.locatiiButton);
            this.Controls.Add(this.calatoriButton);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calatoriButton;
        private System.Windows.Forms.Button locatiiButton;
        private System.Windows.Forms.Button logoutButton;
    }
}