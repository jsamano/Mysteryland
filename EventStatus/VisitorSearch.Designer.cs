namespace EventStatus
{
    partial class VisitorSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnVisitorNo = new System.Windows.Forms.RadioButton();
            this.rbtnVisitorName = new System.Windows.Forms.RadioButton();
            this.btnVisitorSearch = new System.Windows.Forms.Button();
            this.tbxVisitorSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Results";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.BackColor = System.Drawing.Color.White;
            this.btnShowInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowInfo.Location = new System.Drawing.Point(29, 183);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(339, 37);
            this.btnShowInfo.TabIndex = 51;
            this.btnShowInfo.Text = "Show info";
            this.btnShowInfo.UseVisualStyleBackColor = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(29, 108);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(339, 69);
            this.lbResults.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Visitor";
            // 
            // rbtnVisitorNo
            // 
            this.rbtnVisitorNo.AutoSize = true;
            this.rbtnVisitorNo.Checked = true;
            this.rbtnVisitorNo.Location = new System.Drawing.Point(29, 64);
            this.rbtnVisitorNo.Name = "rbtnVisitorNo";
            this.rbtnVisitorNo.Size = new System.Drawing.Size(70, 17);
            this.rbtnVisitorNo.TabIndex = 48;
            this.rbtnVisitorNo.TabStop = true;
            this.rbtnVisitorNo.Text = "Visitor No";
            this.rbtnVisitorNo.UseVisualStyleBackColor = true;
            // 
            // rbtnVisitorName
            // 
            this.rbtnVisitorName.AutoSize = true;
            this.rbtnVisitorName.Location = new System.Drawing.Point(105, 64);
            this.rbtnVisitorName.Name = "rbtnVisitorName";
            this.rbtnVisitorName.Size = new System.Drawing.Size(53, 17);
            this.rbtnVisitorName.TabIndex = 47;
            this.rbtnVisitorName.Text = "Name";
            this.rbtnVisitorName.UseVisualStyleBackColor = true;
            // 
            // btnVisitorSearch
            // 
            this.btnVisitorSearch.BackColor = System.Drawing.Color.White;
            this.btnVisitorSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorSearch.Location = new System.Drawing.Point(293, 36);
            this.btnVisitorSearch.Name = "btnVisitorSearch";
            this.btnVisitorSearch.Size = new System.Drawing.Size(75, 23);
            this.btnVisitorSearch.TabIndex = 46;
            this.btnVisitorSearch.Text = "Search";
            this.btnVisitorSearch.UseVisualStyleBackColor = false;
            this.btnVisitorSearch.Click += new System.EventHandler(this.btnVisitorSearch_Click);
            // 
            // tbxVisitorSearch
            // 
            this.tbxVisitorSearch.Location = new System.Drawing.Point(29, 38);
            this.tbxVisitorSearch.Name = "tbxVisitorSearch";
            this.tbxVisitorSearch.Size = new System.Drawing.Size(244, 20);
            this.tbxVisitorSearch.TabIndex = 45;
            // 
            // VisitorSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(244)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(392, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtnVisitorNo);
            this.Controls.Add(this.rbtnVisitorName);
            this.Controls.Add(this.btnVisitorSearch);
            this.Controls.Add(this.tbxVisitorSearch);
            this.Name = "VisitorSearch";
            this.Text = "Visitor search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnVisitorNo;
        private System.Windows.Forms.RadioButton rbtnVisitorName;
        private System.Windows.Forms.Button btnVisitorSearch;
        private System.Windows.Forms.TextBox tbxVisitorSearch;
    }
}