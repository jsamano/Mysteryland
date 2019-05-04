namespace ATMLogConvert
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblLatestConvertCaption = new System.Windows.Forms.Label();
            this.lblLatestConvert = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.White;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Location = new System.Drawing.Point(116, 100);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(124, 40);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblLatestConvertCaption
            // 
            this.lblLatestConvertCaption.AutoSize = true;
            this.lblLatestConvertCaption.Location = new System.Drawing.Point(264, 20);
            this.lblLatestConvertCaption.Name = "lblLatestConvertCaption";
            this.lblLatestConvertCaption.Size = new System.Drawing.Size(78, 13);
            this.lblLatestConvertCaption.TabIndex = 1;
            this.lblLatestConvertCaption.Text = "Latest convert:";
            // 
            // lblLatestConvert
            // 
            this.lblLatestConvert.AutoSize = true;
            this.lblLatestConvert.Location = new System.Drawing.Point(264, 44);
            this.lblLatestConvert.Name = "lblLatestConvert";
            this.lblLatestConvert.Size = new System.Drawing.Size(61, 13);
            this.lblLatestConvert.TabIndex = 2;
            this.lblLatestConvert.Text = "18.02.1996";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATMLogConvert.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(244)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(363, 168);
            this.Controls.Add(this.lblLatestConvert);
            this.Controls.Add(this.lblLatestConvertCaption);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Convert ATM Logs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblLatestConvertCaption;
        private System.Windows.Forms.Label lblLatestConvert;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

