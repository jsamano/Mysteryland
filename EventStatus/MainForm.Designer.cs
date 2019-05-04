namespace EventStatus
{
    partial class MainForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPresentVisitors = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMoreAboutVisitors = new System.Windows.Forms.Button();
            this.lblBookedSpots = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMoreAboutCampingSpots = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.lbVisitors = new System.Windows.Forms.ListBox();
            this.btnVisitorSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMoreAboutVisitorBalance = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowVisitorInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefreshTotalMoney = new System.Windows.Forms.Button();
            this.btnRefreshSoldAmount = new System.Windows.Forms.Button();
            this.timerUpdateData = new System.Windows.Forms.Timer(this.components);
            this.DGVShops = new System.Windows.Forms.DataGridView();
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMoreAboutRefunds = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRefunds = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 376);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(710, 95);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Latest visitors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visitors presented";
            // 
            // lblPresentVisitors
            // 
            this.lblPresentVisitors.AutoSize = true;
            this.lblPresentVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPresentVisitors.ForeColor = System.Drawing.Color.Green;
            this.lblPresentVisitors.Location = new System.Drawing.Point(15, 43);
            this.lblPresentVisitors.Name = "lblPresentVisitors";
            this.lblPresentVisitors.Size = new System.Drawing.Size(112, 37);
            this.lblPresentVisitors.TabIndex = 4;
            this.lblPresentVisitors.Text = "24753";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMoreAboutVisitors);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPresentVisitors);
            this.panel1.Location = new System.Drawing.Point(313, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 116);
            this.panel1.TabIndex = 5;
            // 
            // btnMoreAboutVisitors
            // 
            this.btnMoreAboutVisitors.BackColor = System.Drawing.Color.White;
            this.btnMoreAboutVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreAboutVisitors.Location = new System.Drawing.Point(68, 88);
            this.btnMoreAboutVisitors.Name = "btnMoreAboutVisitors";
            this.btnMoreAboutVisitors.Size = new System.Drawing.Size(75, 23);
            this.btnMoreAboutVisitors.TabIndex = 19;
            this.btnMoreAboutVisitors.Text = "See more";
            this.btnMoreAboutVisitors.UseVisualStyleBackColor = false;
            this.btnMoreAboutVisitors.Click += new System.EventHandler(this.btnMoreAboutVisitors_Click);
            // 
            // lblBookedSpots
            // 
            this.lblBookedSpots.AutoSize = true;
            this.lblBookedSpots.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBookedSpots.Location = new System.Drawing.Point(17, 39);
            this.lblBookedSpots.Name = "lblBookedSpots";
            this.lblBookedSpots.Size = new System.Drawing.Size(74, 37);
            this.lblBookedSpots.TabIndex = 4;
            this.lblBookedSpots.Text = "937";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Booked spots";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMoreAboutCampingSpots);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblBookedSpots);
            this.panel2.Location = new System.Drawing.Point(467, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 116);
            this.panel2.TabIndex = 6;
            // 
            // btnMoreAboutCampingSpots
            // 
            this.btnMoreAboutCampingSpots.BackColor = System.Drawing.Color.White;
            this.btnMoreAboutCampingSpots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreAboutCampingSpots.Location = new System.Drawing.Point(39, 88);
            this.btnMoreAboutCampingSpots.Name = "btnMoreAboutCampingSpots";
            this.btnMoreAboutCampingSpots.Size = new System.Drawing.Size(75, 23);
            this.btnMoreAboutCampingSpots.TabIndex = 20;
            this.btnMoreAboutCampingSpots.Text = "See more";
            this.btnMoreAboutCampingSpots.UseVisualStyleBackColor = false;
            this.btnMoreAboutCampingSpots.Click += new System.EventHandler(this.btnMoreAboutCampingSpots_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(35, 376);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(710, 95);
            this.listBox2.TabIndex = 0;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(35, 376);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(710, 95);
            this.listBox3.TabIndex = 0;
            // 
            // lbVisitors
            // 
            this.lbVisitors.FormattingEnabled = true;
            this.lbVisitors.Location = new System.Drawing.Point(35, 376);
            this.lbVisitors.Name = "lbVisitors";
            this.lbVisitors.Size = new System.Drawing.Size(857, 95);
            this.lbVisitors.TabIndex = 0;
            this.lbVisitors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbVisitors_MouseDoubleClick);
            // 
            // btnVisitorSearch
            // 
            this.btnVisitorSearch.BackColor = System.Drawing.Color.White;
            this.btnVisitorSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorSearch.Location = new System.Drawing.Point(692, 486);
            this.btnVisitorSearch.Name = "btnVisitorSearch";
            this.btnVisitorSearch.Size = new System.Drawing.Size(200, 43);
            this.btnVisitorSearch.TabIndex = 2;
            this.btnVisitorSearch.Text = "Search for visitor";
            this.btnVisitorSearch.UseVisualStyleBackColor = false;
            this.btnVisitorSearch.Click += new System.EventHandler(this.btnVisitorSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnMoreAboutVisitorBalance);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblTotalBalance);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(592, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 116);
            this.panel3.TabIndex = 7;
            // 
            // btnMoreAboutVisitorBalance
            // 
            this.btnMoreAboutVisitorBalance.BackColor = System.Drawing.Color.White;
            this.btnMoreAboutVisitorBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreAboutVisitorBalance.Location = new System.Drawing.Point(94, 88);
            this.btnMoreAboutVisitorBalance.Name = "btnMoreAboutVisitorBalance";
            this.btnMoreAboutVisitorBalance.Size = new System.Drawing.Size(75, 23);
            this.btnMoreAboutVisitorBalance.TabIndex = 21;
            this.btnMoreAboutVisitorBalance.Text = "See more";
            this.btnMoreAboutVisitorBalance.UseVisualStyleBackColor = false;
            this.btnMoreAboutVisitorBalance.Click += new System.EventHandler(this.btnMoreAboutVisitorBalance_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total balance";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalBalance.Location = new System.Drawing.Point(39, 39);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(74, 37);
            this.lblTotalBalance.TabIndex = 4;
            this.lblTotalBalance.Text = "535";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "€";
            // 
            // btnShowVisitorInfo
            // 
            this.btnShowVisitorInfo.BackColor = System.Drawing.Color.White;
            this.btnShowVisitorInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowVisitorInfo.Location = new System.Drawing.Point(548, 486);
            this.btnShowVisitorInfo.Name = "btnShowVisitorInfo";
            this.btnShowVisitorInfo.Size = new System.Drawing.Size(138, 43);
            this.btnShowVisitorInfo.TabIndex = 12;
            this.btnShowVisitorInfo.Text = "Show info";
            this.btnShowVisitorInfo.UseVisualStyleBackColor = false;
            this.btnShowVisitorInfo.Click += new System.EventHandler(this.btnShowVisitorInfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total money sold per shop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total amount sold per product";
            // 
            // btnRefreshTotalMoney
            // 
            this.btnRefreshTotalMoney.BackColor = System.Drawing.Color.White;
            this.btnRefreshTotalMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTotalMoney.Location = new System.Drawing.Point(378, 315);
            this.btnRefreshTotalMoney.Name = "btnRefreshTotalMoney";
            this.btnRefreshTotalMoney.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshTotalMoney.TabIndex = 15;
            this.btnRefreshTotalMoney.Text = "Refresh";
            this.btnRefreshTotalMoney.UseVisualStyleBackColor = false;
            this.btnRefreshTotalMoney.Click += new System.EventHandler(this.btnRefreshTotalMoney_Click);
            // 
            // btnRefreshSoldAmount
            // 
            this.btnRefreshSoldAmount.BackColor = System.Drawing.Color.White;
            this.btnRefreshSoldAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSoldAmount.Location = new System.Drawing.Point(817, 315);
            this.btnRefreshSoldAmount.Name = "btnRefreshSoldAmount";
            this.btnRefreshSoldAmount.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshSoldAmount.TabIndex = 16;
            this.btnRefreshSoldAmount.Text = "Refresh";
            this.btnRefreshSoldAmount.UseVisualStyleBackColor = false;
            this.btnRefreshSoldAmount.Click += new System.EventHandler(this.btnRefreshSoldAmount_Click);
            // 
            // timerUpdateData
            // 
            this.timerUpdateData.Interval = 10000;
            this.timerUpdateData.Tick += new System.EventHandler(this.timerUpdateData_Tick);
            // 
            // DGVShops
            // 
            this.DGVShops.AllowUserToAddRows = false;
            this.DGVShops.AllowUserToDeleteRows = false;
            this.DGVShops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVShops.Location = new System.Drawing.Point(35, 200);
            this.DGVShops.Name = "DGVShops";
            this.DGVShops.Size = new System.Drawing.Size(418, 109);
            this.DGVShops.TabIndex = 17;
            // 
            // DGVProducts
            // 
            this.DGVProducts.AllowUserToAddRows = false;
            this.DGVProducts.AllowUserToDeleteRows = false;
            this.DGVProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducts.Location = new System.Drawing.Point(474, 200);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.Size = new System.Drawing.Size(418, 110);
            this.DGVProducts.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EventStatus.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-76, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnMoreAboutRefunds);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblRefunds);
            this.panel4.Location = new System.Drawing.Point(773, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 116);
            this.panel4.TabIndex = 19;
            // 
            // btnMoreAboutRefunds
            // 
            this.btnMoreAboutRefunds.BackColor = System.Drawing.Color.White;
            this.btnMoreAboutRefunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreAboutRefunds.Location = new System.Drawing.Point(39, 88);
            this.btnMoreAboutRefunds.Name = "btnMoreAboutRefunds";
            this.btnMoreAboutRefunds.Size = new System.Drawing.Size(75, 23);
            this.btnMoreAboutRefunds.TabIndex = 20;
            this.btnMoreAboutRefunds.Text = "See more";
            this.btnMoreAboutRefunds.UseVisualStyleBackColor = false;
            this.btnMoreAboutRefunds.Click += new System.EventHandler(this.btnMoreAboutRefunds_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Refunds";
            // 
            // lblRefunds
            // 
            this.lblRefunds.AutoSize = true;
            this.lblRefunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRefunds.Location = new System.Drawing.Point(17, 39);
            this.lblRefunds.Name = "lblRefunds";
            this.lblRefunds.Size = new System.Drawing.Size(53, 37);
            this.lblRefunds.TabIndex = 4;
            this.lblRefunds.Text = "14";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(725, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 36);
            this.label7.TabIndex = 28;
            this.label7.Text = "General View";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(244)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(938, 559);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DGVProducts);
            this.Controls.Add(this.DGVShops);
            this.Controls.Add(this.btnRefreshSoldAmount);
            this.Controls.Add(this.btnRefreshTotalMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnShowVisitorInfo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnVisitorSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbVisitors);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Event overview";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPresentVisitors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBookedSpots;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox lbVisitors;
        private System.Windows.Forms.Button btnVisitorSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowVisitorInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefreshTotalMoney;
        private System.Windows.Forms.Button btnRefreshSoldAmount;
        private System.Windows.Forms.Timer timerUpdateData;
        private System.Windows.Forms.DataGridView DGVShops;
        private System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMoreAboutVisitors;
        private System.Windows.Forms.Button btnMoreAboutCampingSpots;
        private System.Windows.Forms.Button btnMoreAboutVisitorBalance;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMoreAboutRefunds;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRefunds;
        private System.Windows.Forms.Label label7;
    }
}

