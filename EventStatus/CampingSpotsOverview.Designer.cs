namespace EventStatus
{
    partial class CampingSpotsOverview
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBookedSpots = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblFreeSpots = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalSpots = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerUpdateData = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblBookedSpots);
            this.panel1.Location = new System.Drawing.Point(243, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 92);
            this.panel1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Booked spots";
            // 
            // lblBookedSpots
            // 
            this.lblBookedSpots.AutoSize = true;
            this.lblBookedSpots.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBookedSpots.Location = new System.Drawing.Point(18, 41);
            this.lblBookedSpots.Name = "lblBookedSpots";
            this.lblBookedSpots.Size = new System.Drawing.Size(74, 37);
            this.lblBookedSpots.TabIndex = 42;
            this.lblBookedSpots.Text = "937";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lblFreeSpots);
            this.panel2.Location = new System.Drawing.Point(379, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 92);
            this.panel2.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Free spots";
            // 
            // lblFreeSpots
            // 
            this.lblFreeSpots.AutoSize = true;
            this.lblFreeSpots.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFreeSpots.Location = new System.Drawing.Point(16, 41);
            this.lblFreeSpots.Name = "lblFreeSpots";
            this.lblFreeSpots.Size = new System.Drawing.Size(55, 37);
            this.lblFreeSpots.TabIndex = 38;
            this.lblFreeSpots.Text = "63";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalSpots);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(504, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 92);
            this.panel3.TabIndex = 7;
            // 
            // lblTotalSpots
            // 
            this.lblTotalSpots.AutoSize = true;
            this.lblTotalSpots.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalSpots.Location = new System.Drawing.Point(18, 41);
            this.lblTotalSpots.Name = "lblTotalSpots";
            this.lblTotalSpots.Size = new System.Drawing.Size(91, 37);
            this.lblTotalSpots.TabIndex = 40;
            this.lblTotalSpots.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Total spots";
            // 
            // timerUpdateData
            // 
            this.timerUpdateData.Interval = 10000;
            this.timerUpdateData.Tick += new System.EventHandler(this.timerUpdateData_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EventStatus.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(33, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 43);
            this.label1.TabIndex = 28;
            this.label1.Text = "Camping Spots View";
            // 
            // CampingSpotsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(244)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(674, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CampingSpotsOverview";
            this.Text = "Camping spots view";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerUpdateData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBookedSpots;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblFreeSpots;
        private System.Windows.Forms.Label lblTotalSpots;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

