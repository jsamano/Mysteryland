namespace ShopManage
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
            this.lbShops = new System.Windows.Forms.ListBox();
            this.lblShops = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.rbtnShop = new System.Windows.Forms.RadioButton();
            this.rbtnLoanStand = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbShops
            // 
            this.lbShops.FormattingEnabled = true;
            this.lbShops.Location = new System.Drawing.Point(27, 121);
            this.lbShops.Name = "lbShops";
            this.lbShops.Size = new System.Drawing.Size(272, 69);
            this.lbShops.TabIndex = 0;
            // 
            // lblShops
            // 
            this.lblShops.AutoSize = true;
            this.lblShops.Location = new System.Drawing.Point(24, 105);
            this.lblShops.Name = "lblShops";
            this.lblShops.Size = new System.Drawing.Size(40, 13);
            this.lblShops.TabIndex = 1;
            this.lblShops.Text = "Shops:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(27, 196);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(27, 44);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(191, 20);
            this.tbxName.TabIndex = 4;
            // 
            // rbtnShop
            // 
            this.rbtnShop.AutoSize = true;
            this.rbtnShop.Checked = true;
            this.rbtnShop.Location = new System.Drawing.Point(27, 70);
            this.rbtnShop.Name = "rbtnShop";
            this.rbtnShop.Size = new System.Drawing.Size(112, 17);
            this.rbtnShop.TabIndex = 5;
            this.rbtnShop.TabStop = true;
            this.rbtnShop.Text = "Food / drink stand";
            this.rbtnShop.UseVisualStyleBackColor = true;
            // 
            // rbtnLoanStand
            // 
            this.rbtnLoanStand.AutoSize = true;
            this.rbtnLoanStand.Location = new System.Drawing.Point(140, 70);
            this.rbtnLoanStand.Name = "rbtnLoanStand";
            this.rbtnLoanStand.Size = new System.Drawing.Size(78, 17);
            this.rbtnLoanStand.TabIndex = 6;
            this.rbtnLoanStand.Text = "Loan stand";
            this.rbtnLoanStand.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(224, 196);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 257);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rbtnLoanStand);
            this.Controls.Add(this.rbtnShop);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblShops);
            this.Controls.Add(this.lbShops);
            this.Name = "MainInterface";
            this.Text = "Manage shops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbShops;
        private System.Windows.Forms.Label lblShops;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.RadioButton rbtnShop;
        private System.Windows.Forms.RadioButton rbtnLoanStand;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRefresh;
    }
}