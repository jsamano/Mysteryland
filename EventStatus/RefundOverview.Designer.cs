namespace EventStatus
{
    partial class RefundOverview
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
            this.timerUpdateData = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMinRefundAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAvgRefundAmount = new System.Windows.Forms.Label();
            this.lblMaxRefundAmount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMostRefundsProduct = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblMostRefundsShop = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMostRefundsAssistant = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblMostRefundsVisitor = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblLastRefund = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalNrOfRefunds = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalRefundAmount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DGVRefundsPerShop = new System.Windows.Forms.DataGridView();
            this.DGVRefunds = new System.Windows.Forms.DataGridView();
            this.btnRefreshRefundsPerShop = new System.Windows.Forms.Button();
            this.btnRefreshRefunds = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRefundsPerShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRefunds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerUpdateData
            // 
            this.timerUpdateData.Interval = 10000;
            this.timerUpdateData.Tick += new System.EventHandler(this.timerUpdateData_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Minimum refund amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Maximum refund amount:";
            // 
            // lblMinRefundAmount
            // 
            this.lblMinRefundAmount.AutoSize = true;
            this.lblMinRefundAmount.Location = new System.Drawing.Point(162, 14);
            this.lblMinRefundAmount.Name = "lblMinRefundAmount";
            this.lblMinRefundAmount.Size = new System.Drawing.Size(35, 13);
            this.lblMinRefundAmount.TabIndex = 14;
            this.lblMinRefundAmount.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Average refund amount:";
            // 
            // lblAvgRefundAmount
            // 
            this.lblAvgRefundAmount.AutoSize = true;
            this.lblAvgRefundAmount.Location = new System.Drawing.Point(370, 14);
            this.lblAvgRefundAmount.Name = "lblAvgRefundAmount";
            this.lblAvgRefundAmount.Size = new System.Drawing.Size(35, 13);
            this.lblAvgRefundAmount.TabIndex = 16;
            this.lblAvgRefundAmount.Text = "label8";
            // 
            // lblMaxRefundAmount
            // 
            this.lblMaxRefundAmount.AutoSize = true;
            this.lblMaxRefundAmount.Location = new System.Drawing.Point(162, 37);
            this.lblMaxRefundAmount.Name = "lblMaxRefundAmount";
            this.lblMaxRefundAmount.Size = new System.Drawing.Size(35, 13);
            this.lblMaxRefundAmount.TabIndex = 17;
            this.lblMaxRefundAmount.Text = "label9";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblMostRefundsProduct);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.lblMostRefundsShop);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblMostRefundsAssistant);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.lblMostRefundsVisitor);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.lblLastRefund);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblMinRefundAmount);
            this.panel3.Controls.Add(this.lblMaxRefundAmount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblAvgRefundAmount);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(33, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 125);
            this.panel3.TabIndex = 18;
            // 
            // lblMostRefundsProduct
            // 
            this.lblMostRefundsProduct.AutoSize = true;
            this.lblMostRefundsProduct.Location = new System.Drawing.Point(370, 72);
            this.lblMostRefundsProduct.Name = "lblMostRefundsProduct";
            this.lblMostRefundsProduct.Size = new System.Drawing.Size(35, 13);
            this.lblMostRefundsProduct.TabIndex = 33;
            this.lblMostRefundsProduct.Text = "label8";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(223, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Most refunds of product:";
            // 
            // lblMostRefundsShop
            // 
            this.lblMostRefundsShop.AutoSize = true;
            this.lblMostRefundsShop.Location = new System.Drawing.Point(162, 72);
            this.lblMostRefundsShop.Name = "lblMostRefundsShop";
            this.lblMostRefundsShop.Size = new System.Drawing.Size(35, 13);
            this.lblMostRefundsShop.TabIndex = 31;
            this.lblMostRefundsShop.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Most refunds by shop:";
            // 
            // lblMostRefundsAssistant
            // 
            this.lblMostRefundsAssistant.AutoSize = true;
            this.lblMostRefundsAssistant.Location = new System.Drawing.Point(162, 95);
            this.lblMostRefundsAssistant.Name = "lblMostRefundsAssistant";
            this.lblMostRefundsAssistant.Size = new System.Drawing.Size(41, 13);
            this.lblMostRefundsAssistant.TabIndex = 29;
            this.lblMostRefundsAssistant.Text = "label29";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(15, 95);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(129, 13);
            this.label30.TabIndex = 28;
            this.label30.Text = "Most refunds by assistant:";
            // 
            // lblMostRefundsVisitor
            // 
            this.lblMostRefundsVisitor.AutoSize = true;
            this.lblMostRefundsVisitor.Location = new System.Drawing.Point(370, 95);
            this.lblMostRefundsVisitor.Name = "lblMostRefundsVisitor";
            this.lblMostRefundsVisitor.Size = new System.Drawing.Size(41, 13);
            this.lblMostRefundsVisitor.TabIndex = 27;
            this.lblMostRefundsVisitor.Text = "label25";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(223, 95);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(116, 13);
            this.label26.TabIndex = 26;
            this.label26.Text = "Most refunds for visitor:";
            // 
            // lblLastRefund
            // 
            this.lblLastRefund.AutoSize = true;
            this.lblLastRefund.Location = new System.Drawing.Point(370, 37);
            this.lblLastRefund.Name = "lblLastRefund";
            this.lblLastRefund.Size = new System.Drawing.Size(41, 13);
            this.lblLastRefund.TabIndex = 22;
            this.lblLastRefund.Text = "label23";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(223, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 13);
            this.label24.TabIndex = 21;
            this.label24.Text = "Last refund date:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblTotalNrOfRefunds);
            this.panel4.Location = new System.Drawing.Point(407, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 92);
            this.panel4.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total number of\r\nrefunds";
            // 
            // lblTotalNrOfRefunds
            // 
            this.lblTotalNrOfRefunds.AutoSize = true;
            this.lblTotalNrOfRefunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalNrOfRefunds.Location = new System.Drawing.Point(5, 40);
            this.lblTotalNrOfRefunds.Name = "lblTotalNrOfRefunds";
            this.lblTotalNrOfRefunds.Size = new System.Drawing.Size(36, 37);
            this.lblTotalNrOfRefunds.TabIndex = 21;
            this.lblTotalNrOfRefunds.Text = "2";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.lblTotalRefundAmount);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(243, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 92);
            this.panel5.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Total refund amount";
            // 
            // lblTotalRefundAmount
            // 
            this.lblTotalRefundAmount.AutoSize = true;
            this.lblTotalRefundAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRefundAmount.Location = new System.Drawing.Point(37, 39);
            this.lblTotalRefundAmount.Name = "lblTotalRefundAmount";
            this.lblTotalRefundAmount.Size = new System.Drawing.Size(74, 37);
            this.lblTotalRefundAmount.TabIndex = 21;
            this.lblTotalRefundAmount.Text = "535";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(13, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 37);
            this.label16.TabIndex = 22;
            this.label16.Text = "€";
            // 
            // DGVRefundsPerShop
            // 
            this.DGVRefundsPerShop.AllowUserToAddRows = false;
            this.DGVRefundsPerShop.AllowUserToDeleteRows = false;
            this.DGVRefundsPerShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRefundsPerShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRefundsPerShop.Location = new System.Drawing.Point(563, 234);
            this.DGVRefundsPerShop.Name = "DGVRefundsPerShop";
            this.DGVRefundsPerShop.Size = new System.Drawing.Size(397, 109);
            this.DGVRefundsPerShop.TabIndex = 26;
            // 
            // DGVRefunds
            // 
            this.DGVRefunds.AllowUserToAddRows = false;
            this.DGVRefunds.AllowUserToDeleteRows = false;
            this.DGVRefunds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRefunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRefunds.Location = new System.Drawing.Point(563, 62);
            this.DGVRefunds.Name = "DGVRefunds";
            this.DGVRefunds.Size = new System.Drawing.Size(397, 109);
            this.DGVRefunds.TabIndex = 25;
            // 
            // btnRefreshRefundsPerShop
            // 
            this.btnRefreshRefundsPerShop.BackColor = System.Drawing.Color.White;
            this.btnRefreshRefundsPerShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRefundsPerShop.Location = new System.Drawing.Point(885, 202);
            this.btnRefreshRefundsPerShop.Name = "btnRefreshRefundsPerShop";
            this.btnRefreshRefundsPerShop.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshRefundsPerShop.TabIndex = 24;
            this.btnRefreshRefundsPerShop.Text = "Refresh";
            this.btnRefreshRefundsPerShop.UseVisualStyleBackColor = false;
            this.btnRefreshRefundsPerShop.Click += new System.EventHandler(this.btnRefreshRefundsPerShop_Click);
            // 
            // btnRefreshRefunds
            // 
            this.btnRefreshRefunds.BackColor = System.Drawing.Color.White;
            this.btnRefreshRefunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRefunds.Location = new System.Drawing.Point(885, 30);
            this.btnRefreshRefunds.Name = "btnRefreshRefunds";
            this.btnRefreshRefunds.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshRefunds.TabIndex = 23;
            this.btnRefreshRefunds.Text = "Refresh";
            this.btnRefreshRefunds.UseVisualStyleBackColor = false;
            this.btnRefreshRefunds.Click += new System.EventHandler(this.btnRefreshRefunds_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(560, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Refunds per shop";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(560, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "All refunds";
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
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 27;
            this.label1.Text = "Refund View";
            // 
            // RefundOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(244)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(995, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVRefundsPerShop);
            this.Controls.Add(this.DGVRefunds);
            this.Controls.Add(this.btnRefreshRefundsPerShop);
            this.Controls.Add(this.btnRefreshRefunds);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RefundOverview";
            this.Text = "Refund view";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRefundsPerShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRefunds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerUpdateData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMinRefundAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAvgRefundAmount;
        private System.Windows.Forms.Label lblMaxRefundAmount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalNrOfRefunds;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalRefundAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblLastRefund;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView DGVRefundsPerShop;
        private System.Windows.Forms.DataGridView DGVRefunds;
        private System.Windows.Forms.Button btnRefreshRefundsPerShop;
        private System.Windows.Forms.Button btnRefreshRefunds;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblMostRefundsAssistant;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblMostRefundsVisitor;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblMostRefundsProduct;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblMostRefundsShop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}

