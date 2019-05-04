namespace ProductManage
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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProductFromShop = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.rtbxDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbShops = new System.Windows.Forms.ListBox();
            this.btnAddProductToShop = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.pnlRFIDReader = new System.Windows.Forms.Panel();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblRFIDReaderSerialNumberCaption = new System.Windows.Forms.Label();
            this.lblRFIDReaderStatusCaption = new System.Windows.Forms.Label();
            this.cbAntenna = new System.Windows.Forms.CheckBox();
            this.lblRFIDReaderTagCaption = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlRFIDReader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(27, 220);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(272, 69);
            this.lbProducts.TabIndex = 0;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(24, 204);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(52, 13);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(27, 168);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProductFromShop
            // 
            this.btnRemoveProductFromShop.Location = new System.Drawing.Point(402, 267);
            this.btnRemoveProductFromShop.Name = "btnRemoveProductFromShop";
            this.btnRemoveProductFromShop.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveProductFromShop.TabIndex = 3;
            this.btnRemoveProductFromShop.Text = "Remove from shop";
            this.btnRemoveProductFromShop.UseVisualStyleBackColor = true;
            this.btnRemoveProductFromShop.Click += new System.EventHandler(this.btnRemoveProductFromShop_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(27, 44);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(272, 20);
            this.tbxName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Product name:";
            // 
            // rtbxDescription
            // 
            this.rtbxDescription.Location = new System.Drawing.Point(27, 95);
            this.rtbxDescription.Name = "rtbxDescription";
            this.rtbxDescription.Size = new System.Drawing.Size(272, 66);
            this.rtbxDescription.TabIndex = 8;
            this.rtbxDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(24, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Shops:";
            // 
            // lbShops
            // 
            this.lbShops.FormattingEnabled = true;
            this.lbShops.Location = new System.Drawing.Point(321, 141);
            this.lbShops.Name = "lbShops";
            this.lbShops.Size = new System.Drawing.Size(272, 69);
            this.lbShops.TabIndex = 10;
            // 
            // btnAddProductToShop
            // 
            this.btnAddProductToShop.Location = new System.Drawing.Point(321, 267);
            this.btnAddProductToShop.Name = "btnAddProductToShop";
            this.btnAddProductToShop.Size = new System.Drawing.Size(75, 23);
            this.btnAddProductToShop.TabIndex = 2;
            this.btnAddProductToShop.Text = "Add to shop";
            this.btnAddProductToShop.UseVisualStyleBackColor = true;
            this.btnAddProductToShop.Click += new System.EventHandler(this.btnAddProductToShop_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(108, 168);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveProduct.TabIndex = 12;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(318, 215);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(490, 215);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price:";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(493, 231);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxPrice.TabIndex = 15;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(321, 231);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbxQuantity.TabIndex = 16;
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
            this.pnlRFIDReader.Location = new System.Drawing.Point(321, 26);
            this.pnlRFIDReader.Name = "pnlRFIDReader";
            this.pnlRFIDReader.Size = new System.Drawing.Size(272, 84);
            this.pnlRFIDReader.TabIndex = 73;
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
            // cbAntenna
            // 
            this.cbAntenna.AutoSize = true;
            this.cbAntenna.Enabled = false;
            this.cbAntenna.Location = new System.Drawing.Point(200, 9);
            this.cbAntenna.Name = "cbAntenna";
            this.cbAntenna.Size = new System.Drawing.Size(66, 17);
            this.cbAntenna.TabIndex = 68;
            this.cbAntenna.Text = "Antenna";
            this.cbAntenna.UseVisualStyleBackColor = true;
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(518, 266);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 327);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlRFIDReader);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbShops);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rtbxDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnRemoveProductFromShop);
            this.Controls.Add(this.btnAddProductToShop);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lbProducts);
            this.Name = "MainInterface";
            this.Text = "Manage products";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainInterface_FormClosing);
            this.pnlRFIDReader.ResumeLayout(false);
            this.pnlRFIDReader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProductFromShop;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox rtbxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbShops;
        private System.Windows.Forms.Button btnAddProductToShop;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Panel pnlRFIDReader;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblRFIDReaderSerialNumberCaption;
        private System.Windows.Forms.Label lblRFIDReaderStatusCaption;
        private System.Windows.Forms.CheckBox cbAntenna;
        private System.Windows.Forms.Label lblRFIDReaderTagCaption;
        private System.Windows.Forms.Button btnRefresh;
    }
}