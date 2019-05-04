namespace AssistantManage
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
            this.lbAssistants = new System.Windows.Forms.ListBox();
            this.lblAssistants = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxAssistantName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblStands = new System.Windows.Forms.Label();
            this.lbStands = new System.Windows.Forms.ListBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAssistants
            // 
            this.lbAssistants.FormattingEnabled = true;
            this.lbAssistants.Location = new System.Drawing.Point(27, 164);
            this.lbAssistants.Name = "lbAssistants";
            this.lbAssistants.Size = new System.Drawing.Size(272, 69);
            this.lbAssistants.TabIndex = 0;
            // 
            // lblAssistants
            // 
            this.lblAssistants.AutoSize = true;
            this.lblAssistants.Location = new System.Drawing.Point(24, 148);
            this.lblAssistants.Name = "lblAssistants";
            this.lblAssistants.Size = new System.Drawing.Size(57, 13);
            this.lblAssistants.TabIndex = 1;
            this.lblAssistants.Text = "Assistants:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAssistantName
            // 
            this.tbxAssistantName.Location = new System.Drawing.Point(27, 68);
            this.tbxAssistantName.Name = "tbxAssistantName";
            this.tbxAssistantName.Size = new System.Drawing.Size(272, 20);
            this.tbxAssistantName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Assistant name:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(108, 341);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblStands
            // 
            this.lblStands.AutoSize = true;
            this.lblStands.Location = new System.Drawing.Point(24, 238);
            this.lblStands.Name = "lblStands";
            this.lblStands.Size = new System.Drawing.Size(43, 13);
            this.lblStands.TabIndex = 14;
            this.lblStands.Text = "Stands:";
            // 
            // lbStands
            // 
            this.lbStands.FormattingEnabled = true;
            this.lbStands.Location = new System.Drawing.Point(27, 254);
            this.lbStands.Name = "lbStands";
            this.lbStands.Size = new System.Drawing.Size(272, 69);
            this.lbStands.TabIndex = 13;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(27, 120);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(272, 20);
            this.tbxPassword.TabIndex = 15;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(189, 341);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 17;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(224, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 396);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblStands);
            this.Controls.Add(this.lbStands);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxAssistantName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAssistants);
            this.Controls.Add(this.lbAssistants);
            this.Name = "MainInterface";
            this.Text = "Manage assistants";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAssistants;
        private System.Windows.Forms.Label lblAssistants;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxAssistantName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblStands;
        private System.Windows.Forms.ListBox lbStands;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnRefresh;
    }
}