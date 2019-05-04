namespace FoodDrinkStands
{
    partial class MainInterface
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
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnPreviousBill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tbxClientNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxNetAmount = new System.Windows.Forms.TextBox();
            this.btnSetClientNo = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblAssistantName = new System.Windows.Forms.Label();
            this.lblAssistantCaption = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResetClientNumber = new System.Windows.Forms.Button();
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.rbtnProductAll = new System.Windows.Forms.RadioButton();
            this.rbtnProductDescription = new System.Windows.Forms.RadioButton();
            this.lblClientCaption = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxResult = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnProductCode = new System.Windows.Forms.RadioButton();
            this.rbtnProductName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearchQuery = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblShopNameCaption = new System.Windows.Forms.Label();
            this.lblShopName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbAntenna = new System.Windows.Forms.CheckBox();
            this.pnlRFIDReader = new System.Windows.Forms.Panel();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblRFIDReaderSerialNumberCaption = new System.Windows.Forms.Label();
            this.lblRFIDReaderStatusCaption = new System.Windows.Forms.Label();
            this.lblRFIDReaderTagCaption = new System.Windows.Forms.Label();
            this.pnlBarcodeScanner = new System.Windows.Forms.Panel();
            this.lblBarcodeScannerSerialNumber = new System.Windows.Forms.Label();
            this.lblBarcodeScannerStatus = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblBarcodeScannerSerialNumberCaption = new System.Windows.Forms.Label();
            this.lblBarcodeScannerStatusCaption = new System.Windows.Forms.Label();
            this.lblBarcodeCaption = new System.Windows.Forms.Label();
            this.rbtnBarcodeScanner = new System.Windows.Forms.RadioButton();
            this.rbtnRFIDReader = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlRFIDReader.SuspendLayout();
            this.pnlBarcodeScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalize
            // 
            this.btnFinalize.BackColor = System.Drawing.Color.White;
            this.btnFinalize.Enabled = false;
            this.btnFinalize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnFinalize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFinalize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinalize.Location = new System.Drawing.Point(38, 379);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(102, 45);
            this.btnFinalize.TabIndex = 23;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // btnPreviousBill
            // 
            this.btnPreviousBill.BackColor = System.Drawing.Color.White;
            this.btnPreviousBill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnPreviousBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousBill.Location = new System.Drawing.Point(594, 379);
            this.btnPreviousBill.Name = "btnPreviousBill";
            this.btnPreviousBill.Size = new System.Drawing.Size(124, 45);
            this.btnPreviousBill.TabIndex = 22;
            this.btnPreviousBill.Text = "Previous bill";
            this.btnPreviousBill.UseVisualStyleBackColor = false;
            this.btnPreviousBill.Click += new System.EventHandler(this.btnPreviousBill_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(507, 379);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 45);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear bill";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Items";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(154, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 45);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tbxClientNo
            // 
            this.tbxClientNo.Location = new System.Drawing.Point(41, 36);
            this.tbxClientNo.Name = "tbxClientNo";
            this.tbxClientNo.Size = new System.Drawing.Size(160, 20);
            this.tbxClientNo.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Client No";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxNetAmount);
            this.panel1.Location = new System.Drawing.Point(501, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 48);
            this.panel1.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Net Amount";
            // 
            // tbxNetAmount
            // 
            this.tbxNetAmount.Location = new System.Drawing.Point(94, 16);
            this.tbxNetAmount.Name = "tbxNetAmount";
            this.tbxNetAmount.ReadOnly = true;
            this.tbxNetAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxNetAmount.TabIndex = 35;
            this.tbxNetAmount.Text = "0.00";
            // 
            // btnSetClientNo
            // 
            this.btnSetClientNo.BackColor = System.Drawing.Color.White;
            this.btnSetClientNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnSetClientNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetClientNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetClientNo.Location = new System.Drawing.Point(41, 62);
            this.btnSetClientNo.Name = "btnSetClientNo";
            this.btnSetClientNo.Size = new System.Drawing.Size(81, 26);
            this.btnSetClientNo.TabIndex = 34;
            this.btnSetClientNo.Text = "Set";
            this.btnSetClientNo.UseVisualStyleBackColor = false;
            this.btnSetClientNo.Click += new System.EventHandler(this.btnSetClientNo_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(412, 379);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 45);
            this.btnRemove.TabIndex = 44;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblAssistantName
            // 
            this.lblAssistantName.AutoSize = true;
            this.lblAssistantName.Location = new System.Drawing.Point(81, 44);
            this.lblAssistantName.Name = "lblAssistantName";
            this.lblAssistantName.Size = new System.Drawing.Size(10, 13);
            this.lblAssistantName.TabIndex = 46;
            this.lblAssistantName.Text = "-";
            // 
            // lblAssistantCaption
            // 
            this.lblAssistantCaption.AutoSize = true;
            this.lblAssistantCaption.Location = new System.Drawing.Point(26, 44);
            this.lblAssistantCaption.Name = "lblAssistantCaption";
            this.lblAssistantCaption.Size = new System.Drawing.Size(49, 13);
            this.lblAssistantCaption.TabIndex = 45;
            this.lblAssistantCaption.Text = "Assisant:";
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.White;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Location = new System.Drawing.Point(146, 379);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(107, 45);
            this.btnHistory.TabIndex = 48;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnResetClientNumber);
            this.panel2.Controls.Add(this.DGVItems);
            this.panel2.Controls.Add(this.numericUpDownQuantity);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.rbtnProductAll);
            this.panel2.Controls.Add(this.rbtnProductDescription);
            this.panel2.Controls.Add(this.lblClientCaption);
            this.panel2.Controls.Add(this.lblClientName);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lbxResult);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rbtnProductCode);
            this.panel2.Controls.Add(this.rbtnProductName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.tbxSearchQuery);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnHistory);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnPreviousBill);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSetClientNo);
            this.panel2.Controls.Add(this.tbxClientNo);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnFinalize);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(49, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 519);
            this.panel2.TabIndex = 0;
            // 
            // btnResetClientNumber
            // 
            this.btnResetClientNumber.BackColor = System.Drawing.Color.White;
            this.btnResetClientNumber.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnResetClientNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetClientNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResetClientNumber.Location = new System.Drawing.Point(128, 62);
            this.btnResetClientNumber.Name = "btnResetClientNumber";
            this.btnResetClientNumber.Size = new System.Drawing.Size(73, 26);
            this.btnResetClientNumber.TabIndex = 65;
            this.btnResetClientNumber.Text = "Reset";
            this.btnResetClientNumber.UseVisualStyleBackColor = false;
            this.btnResetClientNumber.Click += new System.EventHandler(this.btnResetClientNumber_Click);
            // 
            // DGVItems
            // 
            this.DGVItems.AllowUserToAddRows = false;
            this.DGVItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVItems.Location = new System.Drawing.Point(41, 238);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.Size = new System.Drawing.Size(678, 115);
            this.DGVItems.TabIndex = 64;
            this.DGVItems.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGVItems_CellValidating);
            this.DGVItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVItems_CellValueChanged);
            this.DGVItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGVItems_MouseClick);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(492, 176);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownQuantity.TabIndex = 63;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(437, 178);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 62;
            this.lblQuantity.Text = "Quantity:";
            // 
            // rbtnProductAll
            // 
            this.rbtnProductAll.AutoSize = true;
            this.rbtnProductAll.Checked = true;
            this.rbtnProductAll.Location = new System.Drawing.Point(438, 65);
            this.rbtnProductAll.Name = "rbtnProductAll";
            this.rbtnProductAll.Size = new System.Drawing.Size(63, 17);
            this.rbtnProductAll.TabIndex = 60;
            this.rbtnProductAll.TabStop = true;
            this.rbtnProductAll.Text = "All fields";
            this.rbtnProductAll.UseVisualStyleBackColor = true;
            // 
            // rbtnProductDescription
            // 
            this.rbtnProductDescription.AutoSize = true;
            this.rbtnProductDescription.Location = new System.Drawing.Point(622, 65);
            this.rbtnProductDescription.Name = "rbtnProductDescription";
            this.rbtnProductDescription.Size = new System.Drawing.Size(78, 17);
            this.rbtnProductDescription.TabIndex = 59;
            this.rbtnProductDescription.Text = "Description";
            this.rbtnProductDescription.UseVisualStyleBackColor = true;
            // 
            // lblClientCaption
            // 
            this.lblClientCaption.AutoSize = true;
            this.lblClientCaption.Location = new System.Drawing.Point(207, 39);
            this.lblClientCaption.Name = "lblClientCaption";
            this.lblClientCaption.Size = new System.Drawing.Size(36, 13);
            this.lblClientCaption.TabIndex = 47;
            this.lblClientCaption.Text = "Client:";
            this.lblClientCaption.Visible = false;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(243, 40);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(0, 13);
            this.lblClientName.TabIndex = 48;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(41, 110);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(160, 36);
            this.btnPrint.TabIndex = 58;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Results";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(643, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxResult
            // 
            this.lbxResult.FormattingEnabled = true;
            this.lbxResult.HorizontalScrollbar = true;
            this.lbxResult.Location = new System.Drawing.Point(438, 110);
            this.lbxResult.Name = "lbxResult";
            this.lbxResult.Size = new System.Drawing.Size(280, 56);
            this.lbxResult.TabIndex = 54;
            this.lbxResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxResult_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Product";
            // 
            // rbtnProductCode
            // 
            this.rbtnProductCode.AutoSize = true;
            this.rbtnProductCode.Location = new System.Drawing.Point(507, 65);
            this.rbtnProductCode.Name = "rbtnProductCode";
            this.rbtnProductCode.Size = new System.Drawing.Size(50, 17);
            this.rbtnProductCode.TabIndex = 52;
            this.rbtnProductCode.Text = "Code";
            this.rbtnProductCode.UseVisualStyleBackColor = true;
            // 
            // rbtnProductName
            // 
            this.rbtnProductName.AutoSize = true;
            this.rbtnProductName.Location = new System.Drawing.Point(563, 65);
            this.rbtnProductName.Name = "rbtnProductName";
            this.rbtnProductName.Size = new System.Drawing.Size(53, 17);
            this.rbtnProductName.TabIndex = 51;
            this.rbtnProductName.Text = "Name";
            this.rbtnProductName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(643, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearchQuery
            // 
            this.tbxSearchQuery.Location = new System.Drawing.Point(438, 37);
            this.tbxSearchQuery.Name = "tbxSearchQuery";
            this.tbxSearchQuery.Size = new System.Drawing.Size(199, 20);
            this.tbxSearchQuery.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblShopNameCaption);
            this.panel3.Controls.Add(this.lblShopName);
            this.panel3.Controls.Add(this.lblAssistantCaption);
            this.panel3.Controls.Add(this.lblAssistantName);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Location = new System.Drawing.Point(518, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 84);
            this.panel3.TabIndex = 47;
            // 
            // lblShopNameCaption
            // 
            this.lblShopNameCaption.AutoSize = true;
            this.lblShopNameCaption.Location = new System.Drawing.Point(26, 28);
            this.lblShopNameCaption.Name = "lblShopNameCaption";
            this.lblShopNameCaption.Size = new System.Drawing.Size(35, 13);
            this.lblShopNameCaption.TabIndex = 74;
            this.lblShopNameCaption.Text = "Shop:";
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Location = new System.Drawing.Point(65, 28);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(10, 13);
            this.lblShopName.TabIndex = 75;
            this.lblShopName.Text = "-";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(49, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 84);
            this.panel4.TabIndex = 48;
            // 
            // cbAntenna
            // 
            this.cbAntenna.AutoSize = true;
            this.cbAntenna.Enabled = false;
            this.cbAntenna.Location = new System.Drawing.Point(207, 9);
            this.cbAntenna.Name = "cbAntenna";
            this.cbAntenna.Size = new System.Drawing.Size(66, 17);
            this.cbAntenna.TabIndex = 68;
            this.cbAntenna.Text = "Antenna";
            this.cbAntenna.UseVisualStyleBackColor = true;
            // 
            // pnlRFIDReader
            // 
            this.pnlRFIDReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlRFIDReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRFIDReader.Controls.Add(this.lblSerialNumber);
            this.pnlRFIDReader.Controls.Add(this.lblStatus);
            this.pnlRFIDReader.Controls.Add(this.lblTag);
            this.pnlRFIDReader.Controls.Add(this.lblRFIDReaderSerialNumberCaption);
            this.pnlRFIDReader.Controls.Add(this.lblRFIDReaderStatusCaption);
            this.pnlRFIDReader.Controls.Add(this.cbAntenna);
            this.pnlRFIDReader.Controls.Add(this.lblRFIDReaderTagCaption);
            this.pnlRFIDReader.Location = new System.Drawing.Point(234, 27);
            this.pnlRFIDReader.Name = "pnlRFIDReader";
            this.pnlRFIDReader.Size = new System.Drawing.Size(278, 84);
            this.pnlRFIDReader.TabIndex = 72;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(119, 60);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(10, 13);
            this.lblSerialNumber.TabIndex = 13;
            this.lblSerialNumber.Text = "-";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(119, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Not Connected";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(119, 9);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(10, 13);
            this.lblTag.TabIndex = 11;
            this.lblTag.Text = "-";
            // 
            // lblRFIDReaderSerialNumberCaption
            // 
            this.lblRFIDReaderSerialNumberCaption.AutoSize = true;
            this.lblRFIDReaderSerialNumberCaption.Location = new System.Drawing.Point(22, 60);
            this.lblRFIDReaderSerialNumberCaption.Name = "lblRFIDReaderSerialNumberCaption";
            this.lblRFIDReaderSerialNumberCaption.Size = new System.Drawing.Size(76, 13);
            this.lblRFIDReaderSerialNumberCaption.TabIndex = 10;
            this.lblRFIDReaderSerialNumberCaption.Text = "Serial Number:";
            // 
            // lblRFIDReaderStatusCaption
            // 
            this.lblRFIDReaderStatusCaption.AutoSize = true;
            this.lblRFIDReaderStatusCaption.Location = new System.Drawing.Point(22, 34);
            this.lblRFIDReaderStatusCaption.Name = "lblRFIDReaderStatusCaption";
            this.lblRFIDReaderStatusCaption.Size = new System.Drawing.Size(40, 13);
            this.lblRFIDReaderStatusCaption.TabIndex = 9;
            this.lblRFIDReaderStatusCaption.Text = "Status:";
            // 
            // lblRFIDReaderTagCaption
            // 
            this.lblRFIDReaderTagCaption.AutoSize = true;
            this.lblRFIDReaderTagCaption.Location = new System.Drawing.Point(22, 9);
            this.lblRFIDReaderTagCaption.Name = "lblRFIDReaderTagCaption";
            this.lblRFIDReaderTagCaption.Size = new System.Drawing.Size(29, 13);
            this.lblRFIDReaderTagCaption.TabIndex = 8;
            this.lblRFIDReaderTagCaption.Text = "Tag:";
            // 
            // pnlBarcodeScanner
            // 
            this.pnlBarcodeScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBarcodeScanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarcodeScanner.Controls.Add(this.lblBarcodeScannerSerialNumber);
            this.pnlBarcodeScanner.Controls.Add(this.lblBarcodeScannerStatus);
            this.pnlBarcodeScanner.Controls.Add(this.lblBarcode);
            this.pnlBarcodeScanner.Controls.Add(this.lblBarcodeScannerSerialNumberCaption);
            this.pnlBarcodeScanner.Controls.Add(this.lblBarcodeScannerStatusCaption);
            this.pnlBarcodeScanner.Controls.Add(this.lblBarcodeCaption);
            this.pnlBarcodeScanner.Location = new System.Drawing.Point(234, 27);
            this.pnlBarcodeScanner.Name = "pnlBarcodeScanner";
            this.pnlBarcodeScanner.Size = new System.Drawing.Size(278, 84);
            this.pnlBarcodeScanner.TabIndex = 73;
            // 
            // lblBarcodeScannerSerialNumber
            // 
            this.lblBarcodeScannerSerialNumber.AutoSize = true;
            this.lblBarcodeScannerSerialNumber.Location = new System.Drawing.Point(119, 60);
            this.lblBarcodeScannerSerialNumber.Name = "lblBarcodeScannerSerialNumber";
            this.lblBarcodeScannerSerialNumber.Size = new System.Drawing.Size(10, 13);
            this.lblBarcodeScannerSerialNumber.TabIndex = 13;
            this.lblBarcodeScannerSerialNumber.Text = "-";
            // 
            // lblBarcodeScannerStatus
            // 
            this.lblBarcodeScannerStatus.AutoSize = true;
            this.lblBarcodeScannerStatus.Location = new System.Drawing.Point(119, 34);
            this.lblBarcodeScannerStatus.Name = "lblBarcodeScannerStatus";
            this.lblBarcodeScannerStatus.Size = new System.Drawing.Size(79, 13);
            this.lblBarcodeScannerStatus.TabIndex = 12;
            this.lblBarcodeScannerStatus.Text = "Not Connected";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(119, 9);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(10, 13);
            this.lblBarcode.TabIndex = 11;
            this.lblBarcode.Text = "-";
            // 
            // lblBarcodeScannerSerialNumberCaption
            // 
            this.lblBarcodeScannerSerialNumberCaption.AutoSize = true;
            this.lblBarcodeScannerSerialNumberCaption.Location = new System.Drawing.Point(22, 60);
            this.lblBarcodeScannerSerialNumberCaption.Name = "lblBarcodeScannerSerialNumberCaption";
            this.lblBarcodeScannerSerialNumberCaption.Size = new System.Drawing.Size(76, 13);
            this.lblBarcodeScannerSerialNumberCaption.TabIndex = 10;
            this.lblBarcodeScannerSerialNumberCaption.Text = "Serial Number:";
            // 
            // lblBarcodeScannerStatusCaption
            // 
            this.lblBarcodeScannerStatusCaption.AutoSize = true;
            this.lblBarcodeScannerStatusCaption.Location = new System.Drawing.Point(22, 34);
            this.lblBarcodeScannerStatusCaption.Name = "lblBarcodeScannerStatusCaption";
            this.lblBarcodeScannerStatusCaption.Size = new System.Drawing.Size(40, 13);
            this.lblBarcodeScannerStatusCaption.TabIndex = 9;
            this.lblBarcodeScannerStatusCaption.Text = "Status:";
            // 
            // lblBarcodeCaption
            // 
            this.lblBarcodeCaption.AutoSize = true;
            this.lblBarcodeCaption.Location = new System.Drawing.Point(22, 9);
            this.lblBarcodeCaption.Name = "lblBarcodeCaption";
            this.lblBarcodeCaption.Size = new System.Drawing.Size(50, 13);
            this.lblBarcodeCaption.TabIndex = 8;
            this.lblBarcodeCaption.Text = "Barcode:";
            // 
            // rbtnBarcodeScanner
            // 
            this.rbtnBarcodeScanner.AutoSize = true;
            this.rbtnBarcodeScanner.Location = new System.Drawing.Point(323, 117);
            this.rbtnBarcodeScanner.Name = "rbtnBarcodeScanner";
            this.rbtnBarcodeScanner.Size = new System.Drawing.Size(106, 17);
            this.rbtnBarcodeScanner.TabIndex = 65;
            this.rbtnBarcodeScanner.Text = "Barcode scanner";
            this.rbtnBarcodeScanner.UseVisualStyleBackColor = true;
            this.rbtnBarcodeScanner.Visible = false;
            this.rbtnBarcodeScanner.CheckedChanged += new System.EventHandler(this.rbtnBarcodeScanner_CheckedChanged);
            // 
            // rbtnRFIDReader
            // 
            this.rbtnRFIDReader.AutoSize = true;
            this.rbtnRFIDReader.Checked = true;
            this.rbtnRFIDReader.Location = new System.Drawing.Point(234, 117);
            this.rbtnRFIDReader.Name = "rbtnRFIDReader";
            this.rbtnRFIDReader.Size = new System.Drawing.Size(83, 17);
            this.rbtnRFIDReader.TabIndex = 66;
            this.rbtnRFIDReader.TabStop = true;
            this.rbtnRFIDReader.Text = "RFID reader";
            this.rbtnRFIDReader.UseVisualStyleBackColor = true;
            this.rbtnRFIDReader.Visible = false;
            this.rbtnRFIDReader.CheckedChanged += new System.EventHandler(this.rbtnRFIDReader_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FoodDrinkStands.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-97, -35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(244)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(865, 712);
            this.Controls.Add(this.rbtnBarcodeScanner);
            this.Controls.Add(this.pnlRFIDReader);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.rbtnRFIDReader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlBarcodeScanner);
            this.Name = "MainInterface";
            this.Text = "Mysteryland";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainInterface_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlRFIDReader.ResumeLayout(false);
            this.pnlRFIDReader.PerformLayout();
            this.pnlBarcodeScanner.ResumeLayout(false);
            this.pnlBarcodeScanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnPreviousBill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxClientNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxNetAmount;
        private System.Windows.Forms.Button btnSetClientNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblAssistantName;
        private System.Windows.Forms.Label lblAssistantCaption;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnProductCode;
        private System.Windows.Forms.RadioButton rbtnProductName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearchQuery;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblClientCaption;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.RadioButton rbtnProductAll;
        private System.Windows.Forms.RadioButton rbtnProductDescription;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView DGVItems;
        private System.Windows.Forms.CheckBox cbAntenna;
        private System.Windows.Forms.Panel pnlRFIDReader;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblRFIDReaderSerialNumberCaption;
        private System.Windows.Forms.Label lblRFIDReaderStatusCaption;
        private System.Windows.Forms.Label lblRFIDReaderTagCaption;
        private System.Windows.Forms.RadioButton rbtnBarcodeScanner;
        private System.Windows.Forms.RadioButton rbtnRFIDReader;
        private System.Windows.Forms.Panel pnlBarcodeScanner;
        private System.Windows.Forms.Label lblBarcodeScannerSerialNumber;
        private System.Windows.Forms.Label lblBarcodeScannerStatus;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblBarcodeScannerSerialNumberCaption;
        private System.Windows.Forms.Label lblBarcodeScannerStatusCaption;
        private System.Windows.Forms.Label lblBarcodeCaption;
        private System.Windows.Forms.Button btnResetClientNumber;
        private System.Windows.Forms.Label lblShopNameCaption;
        private System.Windows.Forms.Label lblShopName;
    }
}

