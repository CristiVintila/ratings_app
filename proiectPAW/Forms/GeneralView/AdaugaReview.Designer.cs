namespace proiectPAW.Forms.GeneralView
{
    partial class AdaugaReview
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
            this.reviewTextbox = new System.Windows.Forms.TextBox();
            this.addReviewButton = new System.Windows.Forms.Button();
            this.notaTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locatieTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.modificaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reviewDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewDatagrid
            // 
            this.reviewDatagrid.BackgroundColor = System.Drawing.Color.Silver;
            this.reviewDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewDatagrid.Location = new System.Drawing.Point(12, 76);
            this.reviewDatagrid.Name = "reviewDatagrid";
            this.reviewDatagrid.Size = new System.Drawing.Size(551, 362);
            this.reviewDatagrid.TabIndex = 0;
            this.reviewDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reviewDatagrid_CellClick);
            // 
            // reviewTextbox
            // 
            this.reviewTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reviewTextbox.Location = new System.Drawing.Point(596, 76);
            this.reviewTextbox.Multiline = true;
            this.reviewTextbox.Name = "reviewTextbox";
            this.reviewTextbox.Size = new System.Drawing.Size(258, 164);
            this.reviewTextbox.TabIndex = 1;
            // 
            // addReviewButton
            // 
            this.addReviewButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.addReviewButton.Location = new System.Drawing.Point(779, 246);
            this.addReviewButton.Name = "addReviewButton";
            this.addReviewButton.Size = new System.Drawing.Size(75, 27);
            this.addReviewButton.TabIndex = 2;
            this.addReviewButton.Text = "Adauga";
            this.addReviewButton.UseVisualStyleBackColor = false;
            this.addReviewButton.Click += new System.EventHandler(this.addReviewButton_Click);
            // 
            // notaTrackBar
            // 
            this.notaTrackBar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.notaTrackBar.Location = new System.Drawing.Point(734, 25);
            this.notaTrackBar.Maximum = 5;
            this.notaTrackBar.Minimum = 1;
            this.notaTrackBar.Name = "notaTrackBar";
            this.notaTrackBar.Size = new System.Drawing.Size(104, 45);
            this.notaTrackBar.TabIndex = 4;
            this.notaTrackBar.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "1    2     3    4     5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Locatie";
            // 
            // locatieTextbox
            // 
            this.locatieTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.locatieTextbox.Enabled = false;
            this.locatieTextbox.Location = new System.Drawing.Point(15, 46);
            this.locatieTextbox.Name = "locatieTextbox";
            this.locatieTextbox.Size = new System.Drawing.Size(121, 20);
            this.locatieTextbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rating";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(330, 51);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(41, 15);
            this.ratingLabel.TabIndex = 10;
            this.ratingLabel.Text = "label5";
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.finishButton.Location = new System.Drawing.Point(691, 371);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(97, 29);
            this.finishButton.TabIndex = 11;
            this.finishButton.Text = "Gata!";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // modificaButton
            // 
            this.modificaButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.modificaButton.Enabled = false;
            this.modificaButton.Location = new System.Drawing.Point(596, 246);
            this.modificaButton.Name = "modificaButton";
            this.modificaButton.Size = new System.Drawing.Size(75, 27);
            this.modificaButton.TabIndex = 12;
            this.modificaButton.Text = "Modifica";
            this.modificaButton.UseVisualStyleBackColor = false;
            this.modificaButton.Visible = false;
            this.modificaButton.Click += new System.EventHandler(this.modificaButton_Click);
            // 
            // AdaugaReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.modificaButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.locatieTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notaTrackBar);
            this.Controls.Add(this.addReviewButton);
            this.Controls.Add(this.reviewTextbox);
            this.Controls.Add(this.reviewDatagrid);
            this.Name = "AdaugaReview";
            this.Text = "AdaugaReview";
            ((System.ComponentModel.ISupportInitialize)(this.reviewDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reviewDatagrid;
        private System.Windows.Forms.TextBox reviewTextbox;
        private System.Windows.Forms.Button addReviewButton;
        private System.Windows.Forms.TrackBar notaTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locatieTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button modificaButton;
    }
}