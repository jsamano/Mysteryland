namespace FoodDrinkStands
{
    partial class InvoiceSearch
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRefundAmount = new System.Windows.Forms.Label();
            this.tbxRefundSelectedAmount = new System.Windows.Forms.TextBox();
            this.lblIDCaption = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAssistantCaption = new System.Windows.Forms.Label();
            this.lblAssistant = new System.Windows.Forms.Label();
            this.lblClientCaption = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblInvoiceNoCaption = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblDateCaption = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnRefundAll = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxNetAmount = new System.Windows.Forms.TextBox();
            this.btnRefundSelected = new System.Windows.Forms.Button();
            this.lblItems = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInvoiceNoSearch = new System.Windows.Forms.Label();
            this.btnInvoiceSearch = new System.Windows.Forms.Button();
            this.tbxInvoiceSearch = new System.Windows.Forms.TextBox();
            this.lblLastInvoices = new System.Windows.Forms.Label();
            this.lbxLastInvoices = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.lblLastUpdateCaption = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(28, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 84);
            this.panel4.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FoodDrinkStands.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-77, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DGVItems);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.lblIDCaption);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.lblAssistantCaption);
            this.panel2.Controls.Add(this.lblAssistant);
            this.panel2.Controls.Add(this.lblClientCaption);
            this.panel2.Controls.Add(this.lblClient);
            this.panel2.Controls.Add(this.lblInvoiceNoCaption);
            this.panel2.Controls.Add(this.lblInvoiceNo);
            this.panel2.Controls.Add(this.lblDateCaption);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.btnRefundAll);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnRefundSelected);
            this.panel2.Controls.Add(this.lblItems);
            this.panel2.Location = new System.Drawing.Point(47, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 266);
            this.panel2.TabIndex = 49;
            // 
            // DGVItems
            // 
            this.DGVItems.AllowUserToAddRows = false;
            this.DGVItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVItems.Location = new System.Drawing.Point(41, 41);
            this.DGVItems.MultiSelect = false;
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.Size = new System.Drawing.Size(678, 115);
            this.DGVItems.TabIndex = 75;
            this.DGVItems.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGVItems_CellValidating);
            this.DGVItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVItems_CellValueChanged);
            this.DGVItems.SelectionChanged += new System.EventHandler(this.DGVItems_SelectionChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblRefundAmount);
            this.panel6.Controls.Add(this.tbxRefundSelectedAmount);
            this.panel6.Location = new System.Drawing.Point(601, 182);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(118, 45);
            this.panel6.TabIndex = 74;
            // 
            // lblRefundAmount
            // 
            this.lblRefundAmount.AutoSize = true;
            this.lblRefundAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRefundAmount.Location = new System.Drawing.Point(3, 4);
            this.lblRefundAmount.Name = "lblRefundAmount";
            this.lblRefundAmount.Size = new System.Drawing.Size(94, 13);
            this.lblRefundAmount.TabIndex = 34;
            this.lblRefundAmount.Text = "Refund Amount";
            // 
            // tbxRefundSelectedAmount
            // 
            this.tbxRefundSelectedAmount.Location = new System.Drawing.Point(6, 20);
            this.tbxRefundSelectedAmount.Name = "tbxRefundSelectedAmount";
            this.tbxRefundSelectedAmount.ReadOnly = true;
            this.tbxRefundSelectedAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxRefundSelectedAmount.TabIndex = 35;
            this.tbxRefundSelectedAmount.Text = "0.00";
            // 
            // lblIDCaption
            // 
            this.lblIDCaption.AutoSize = true;
            this.lblIDCaption.Location = new System.Drawing.Point(35, 240);
            this.lblIDCaption.Name = "lblIDCaption";
            this.lblIDCaption.Size = new System.Drawing.Size(21, 13);
            this.lblIDCaption.TabIndex = 71;
            this.lblIDCaption.Text = "ID:";
            this.lblIDCaption.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(62, 240);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(10, 13);
            this.lblID.TabIndex = 70;
            this.lblID.Text = "-";
            this.lblID.Visible = false;
            // 
            // lblAssistantCaption
            // 
            this.lblAssistantCaption.AutoSize = true;
            this.lblAssistantCaption.Location = new System.Drawing.Point(248, 240);
            this.lblAssistantCaption.Name = "lblAssistantCaption";
            this.lblAssistantCaption.Size = new System.Drawing.Size(52, 13);
            this.lblAssistantCaption.TabIndex = 69;
            this.lblAssistantCaption.Text = "Assistant:";
            this.lblAssistantCaption.Visible = false;
            // 
            // lblAssistant
            // 
            this.lblAssistant.AutoSize = true;
            this.lblAssistant.Location = new System.Drawing.Point(306, 240);
            this.lblAssistant.Name = "lblAssistant";
            this.lblAssistant.Size = new System.Drawing.Size(10, 13);
            this.lblAssistant.TabIndex = 68;
            this.lblAssistant.Text = "-";
            this.lblAssistant.Visible = false;
            // 
            // lblClientCaption
            // 
            this.lblClientCaption.AutoSize = true;
            this.lblClientCaption.Location = new System.Drawing.Point(98, 240);
            this.lblClientCaption.Name = "lblClientCaption";
            this.lblClientCaption.Size = new System.Drawing.Size(36, 13);
            this.lblClientCaption.TabIndex = 65;
            this.lblClientCaption.Text = "Client:";
            this.lblClientCaption.Visible = false;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(137, 240);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(10, 13);
            this.lblClient.TabIndex = 64;
            this.lblClient.Text = "-";
            this.lblClient.Visible = false;
            // 
            // lblInvoiceNoCaption
            // 
            this.lblInvoiceNoCaption.AutoSize = true;
            this.lblInvoiceNoCaption.Location = new System.Drawing.Point(620, 240);
            this.lblInvoiceNoCaption.Name = "lblInvoiceNoCaption";
            this.lblInvoiceNoCaption.Size = new System.Drawing.Size(62, 13);
            this.lblInvoiceNoCaption.TabIndex = 63;
            this.lblInvoiceNoCaption.Text = "Invoice No:";
            this.lblInvoiceNoCaption.Visible = false;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(685, 240);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(10, 13);
            this.lblInvoiceNo.TabIndex = 62;
            this.lblInvoiceNo.Text = "-";
            this.lblInvoiceNo.Visible = false;
            // 
            // lblDateCaption
            // 
            this.lblDateCaption.AutoSize = true;
            this.lblDateCaption.Location = new System.Drawing.Point(456, 240);
            this.lblDateCaption.Name = "lblDateCaption";
            this.lblDateCaption.Size = new System.Drawing.Size(33, 13);
            this.lblDateCaption.TabIndex = 61;
            this.lblDateCaption.Text = "Date:";
            this.lblDateCaption.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(495, 240);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(10, 13);
            this.lblDate.TabIndex = 60;
            this.lblDate.Text = "-";
            this.lblDate.Visible = false;
            // 
            // btnRefundAll
            // 
            this.btnRefundAll.BackColor = System.Drawing.Color.White;
            this.btnRefundAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnRefundAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRefundAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefundAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefundAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefundAll.Location = new System.Drawing.Point(146, 182);
            this.btnRefundAll.Name = "btnRefundAll";
            this.btnRefundAll.Size = new System.Drawing.Size(102, 45);
            this.btnRefundAll.TabIndex = 59;
            this.btnRefundAll.Text = "Refund all";
            this.btnRefundAll.UseVisualStyleBackColor = false;
            this.btnRefundAll.Click += new System.EventHandler(this.btnRefundAll_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(254, 182);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 45);
            this.btnPrint.TabIndex = 58;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxNetAmount);
            this.panel1.Location = new System.Drawing.Point(475, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 45);
            this.panel1.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Net Amount";
            // 
            // tbxNetAmount
            // 
            this.tbxNetAmount.Location = new System.Drawing.Point(6, 20);
            this.tbxNetAmount.Name = "tbxNetAmount";
            this.tbxNetAmount.ReadOnly = true;
            this.tbxNetAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxNetAmount.TabIndex = 35;
            this.tbxNetAmount.Text = "0.00";
            // 
            // btnRefundSelected
            // 
            this.btnRefundSelected.BackColor = System.Drawing.Color.White;
            this.btnRefundSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnRefundSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRefundSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefundSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefundSelected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefundSelected.Location = new System.Drawing.Point(38, 182);
            this.btnRefundSelected.Name = "btnRefundSelected";
            this.btnRefundSelected.Size = new System.Drawing.Size(102, 45);
            this.btnRefundSelected.TabIndex = 23;
            this.btnRefundSelected.Text = "Refund selected";
            this.btnRefundSelected.UseVisualStyleBackColor = false;
            this.btnRefundSelected.Click += new System.EventHandler(this.btnRefundSelected_Click);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(38, 16);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(32, 13);
            this.lblItems.TabIndex = 14;
            this.lblItems.Text = "Items";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblInvoiceNoSearch);
            this.panel3.Controls.Add(this.btnInvoiceSearch);
            this.panel3.Controls.Add(this.tbxInvoiceSearch);
            this.panel3.Location = new System.Drawing.Point(554, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 84);
            this.panel3.TabIndex = 52;
            // 
            // lblInvoiceNoSearch
            // 
            this.lblInvoiceNoSearch.AutoSize = true;
            this.lblInvoiceNoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInvoiceNoSearch.Location = new System.Drawing.Point(9, 16);
            this.lblInvoiceNoSearch.Name = "lblInvoiceNoSearch";
            this.lblInvoiceNoSearch.Size = new System.Drawing.Size(69, 13);
            this.lblInvoiceNoSearch.TabIndex = 56;
            this.lblInvoiceNoSearch.Text = "Invoice No";
            // 
            // btnInvoiceSearch
            // 
            this.btnInvoiceSearch.BackColor = System.Drawing.Color.White;
            this.btnInvoiceSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceSearch.Location = new System.Drawing.Point(166, 30);
            this.btnInvoiceSearch.Name = "btnInvoiceSearch";
            this.btnInvoiceSearch.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceSearch.TabIndex = 55;
            this.btnInvoiceSearch.Text = "Search";
            this.btnInvoiceSearch.UseVisualStyleBackColor = false;
            this.btnInvoiceSearch.Click += new System.EventHandler(this.btnInvoiceSearch_Click);
            // 
            // tbxInvoiceSearch
            // 
            this.tbxInvoiceSearch.Location = new System.Drawing.Point(12, 32);
            this.tbxInvoiceSearch.Name = "tbxInvoiceSearch";
            this.tbxInvoiceSearch.Size = new System.Drawing.Size(148, 20);
            this.tbxInvoiceSearch.TabIndex = 54;
            // 
            // lblLastInvoices
            // 
            this.lblLastInvoices.AutoSize = true;
            this.lblLastInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastInvoices.Location = new System.Drawing.Point(13, 18);
            this.lblLastInvoices.Name = "lblLastInvoices";
            this.lblLastInvoices.Size = new System.Drawing.Size(82, 13);
            this.lblLastInvoices.TabIndex = 56;
            this.lblLastInvoices.Text = "Last invoices";
            // 
            // lbxLastInvoices
            // 
            this.lbxLastInvoices.FormattingEnabled = true;
            this.lbxLastInvoices.Location = new System.Drawing.Point(16, 32);
            this.lbxLastInvoices.Name = "lbxLastInvoices";
            this.lbxLastInvoices.Size = new System.Drawing.Size(264, 43);
            this.lbxLastInvoices.TabIndex = 57;
            this.lbxLastInvoices.DoubleClick += new System.EventHandler(this.lbxLastInvoices_DoubleClick);
            this.lbxLastInvoices.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxLastInvoices_MouseMove);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblLastUpdate);
            this.panel5.Controls.Add(this.lblLastUpdateCaption);
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.lbxLastInvoices);
            this.panel5.Controls.Add(this.lblLastInvoices);
            this.panel5.Location = new System.Drawing.Point(252, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 84);
            this.panel5.TabIndex = 53;
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Location = new System.Drawing.Point(85, 5);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(10, 13);
            this.lblLastUpdate.TabIndex = 77;
            this.lblLastUpdate.Text = "-";
            // 
            // lblLastUpdateCaption
            // 
            this.lblLastUpdateCaption.AutoSize = true;
            this.lblLastUpdateCaption.Location = new System.Drawing.Point(13, 5);
            this.lblLastUpdateCaption.Name = "lblLastUpdateCaption";
            this.lblLastUpdateCaption.Size = new System.Drawing.Size(66, 13);
            this.lblLastUpdateCaption.TabIndex = 76;
            this.lblLastUpdateCaption.Text = "Last update:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(219, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(61, 23);
            this.btnRefresh.TabIndex = 57;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // InvoiceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(244)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(857, 405);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "InvoiceSearch";
            this.Text = "Search for invoice - Mysteryland";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxNetAmount;
        private System.Windows.Forms.Button btnRefundSelected;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Button btnRefundAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInvoiceNoSearch;
        private System.Windows.Forms.Button btnInvoiceSearch;
        private System.Windows.Forms.TextBox tbxInvoiceSearch;
        private System.Windows.Forms.Label lblLastInvoices;
        private System.Windows.Forms.ListBox lbxLastInvoices;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblInvoiceNoCaption;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblDateCaption;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblIDCaption;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAssistantCaption;
        private System.Windows.Forms.Label lblAssistant;
        private System.Windows.Forms.Label lblClientCaption;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblRefundAmount;
        private System.Windows.Forms.TextBox tbxRefundSelectedAmount;
        private System.Windows.Forms.DataGridView DGVItems;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label lblLastUpdateCaption;
    }
}