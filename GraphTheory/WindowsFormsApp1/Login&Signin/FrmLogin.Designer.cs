namespace WindowsFormsApp1
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btbClear = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btbLogin = new System.Windows.Forms.Button();
            this.lblResig = new System.Windows.Forms.Label();
            this.checkboxShow = new System.Windows.Forms.CheckBox();
            this.lblXacthuc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btbClear
            // 
            this.btbClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btbClear.FlatAppearance.BorderSize = 2;
            this.btbClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btbClear.Location = new System.Drawing.Point(46, 387);
            this.btbClear.Name = "btbClear";
            this.btbClear.Size = new System.Drawing.Size(297, 36);
            this.btbClear.TabIndex = 7;
            this.btbClear.Text = "XÓA NHANH";
            this.btbClear.UseVisualStyleBackColor = true;
            this.btbClear.Click += new System.EventHandler(this.btbClear_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.txtUserName.Location = new System.Drawing.Point(46, 135);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(297, 43);
            this.txtUserName.TabIndex = 15;
            this.txtUserName.UseWaitCursor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.txtPassword.Location = new System.Drawing.Point(46, 220);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(297, 43);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.UseWaitCursor = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl2.Location = new System.Drawing.Point(44, 111);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(92, 23);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "UserName";
            this.lbl2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(44, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Password";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(40, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 45);
            this.label2.TabIndex = 19;
            this.label2.Text = "Đăng nhập";
            this.label2.UseWaitCursor = true;
            // 
            // btbLogin
            // 
            this.btbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbLogin.ForeColor = System.Drawing.Color.White;
            this.btbLogin.Location = new System.Drawing.Point(46, 334);
            this.btbLogin.Name = "btbLogin";
            this.btbLogin.Size = new System.Drawing.Size(297, 36);
            this.btbLogin.TabIndex = 20;
            this.btbLogin.Text = "ĐĂNG NHẬP";
            this.btbLogin.UseVisualStyleBackColor = false;
            this.btbLogin.UseWaitCursor = true;
            this.btbLogin.Click += new System.EventHandler(this.btbLogin_Click);
            // 
            // lblResig
            // 
            this.lblResig.AutoSize = true;
            this.lblResig.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(78)))), ((int)(((byte)(165)))));
            this.lblResig.Location = new System.Drawing.Point(125, 426);
            this.lblResig.Name = "lblResig";
            this.lblResig.Size = new System.Drawing.Size(162, 23);
            this.lblResig.TabIndex = 21;
            this.lblResig.Text = " Đăng ký tài khoản";
            this.lblResig.UseWaitCursor = true;
            this.lblResig.Click += new System.EventHandler(this.lblResig_Click);
            // 
            // checkboxShow
            // 
            this.checkboxShow.AutoSize = true;
            this.checkboxShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxShow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkboxShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkboxShow.Location = new System.Drawing.Point(191, 285);
            this.checkboxShow.Name = "checkboxShow";
            this.checkboxShow.Size = new System.Drawing.Size(152, 27);
            this.checkboxShow.TabIndex = 22;
            this.checkboxShow.Text = "Show Password";
            this.checkboxShow.UseVisualStyleBackColor = true;
            this.checkboxShow.CheckedChanged += new System.EventHandler(this.checkboxShow_CheckedChanged);
            // 
            // lblXacthuc
            // 
            this.lblXacthuc.AutoSize = true;
            this.lblXacthuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblXacthuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(78)))), ((int)(((byte)(165)))));
            this.lblXacthuc.Location = new System.Drawing.Point(125, 449);
            this.lblXacthuc.Name = "lblXacthuc";
            this.lblXacthuc.Size = new System.Drawing.Size(170, 23);
            this.lblXacthuc.TabIndex = 23;
            this.lblXacthuc.Text = "Xác thực đăng nhập";
            this.lblXacthuc.Click += new System.EventHandler(this.lblXacthuc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(134, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quên mật khẩu?";
            this.label4.Click += new System.EventHandler(this.ForgotPassword);
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(398, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblXacthuc);
            this.Controls.Add(this.checkboxShow);
            this.Controls.Add(this.lblResig);
            this.Controls.Add(this.btbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btbClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btbClear;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbLogin;
        private System.Windows.Forms.Label lblResig;
        private System.Windows.Forms.CheckBox checkboxShow;
        private System.Windows.Forms.Label lblXacthuc;
        private System.Windows.Forms.Label label4;
    }
}
