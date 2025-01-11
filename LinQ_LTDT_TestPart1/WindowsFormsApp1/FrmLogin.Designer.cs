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
            this.lblNoti = new Telerik.WinControls.UI.RadLabel();
            this.lbl1 = new Telerik.WinControls.UI.RadLabel();
            this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new Telerik.WinControls.UI.RadLabel();
            this.checkboxShow = new Telerik.WinControls.UI.RadCheckBox();
            this.btbLogin = new Telerik.WinControls.UI.RadButton();
            this.btbClear = new System.Windows.Forms.Button();
            this.lblResig = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblNoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoti
            // 
            this.lblNoti.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblNoti.Location = new System.Drawing.Point(125, 14);
            this.lblNoti.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(166, 39);
            this.lblNoti.TabIndex = 0;
            this.lblNoti.Text = "Đăng nhập";
            this.lblNoti.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lbl1.Location = new System.Drawing.Point(50, 84);
            this.lbl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(90, 26);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUserName.Location = new System.Drawing.Point(50, 127);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(297, 32);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.Location = new System.Drawing.Point(50, 232);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(297, 32);
            this.txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(50, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // checkboxShow
            // 
            this.checkboxShow.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkboxShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkboxShow.Location = new System.Drawing.Point(195, 291);
            this.checkboxShow.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkboxShow.Name = "checkboxShow";
            this.checkboxShow.Size = new System.Drawing.Size(152, 24);
            this.checkboxShow.TabIndex = 5;
            this.checkboxShow.Text = "Show Password";
            this.checkboxShow.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.checkboxShow_ToggleStateChanged);
            // 
            // btbLogin
            // 
            this.btbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btbLogin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btbLogin.ForeColor = System.Drawing.Color.White;
            this.btbLogin.Location = new System.Drawing.Point(50, 351);
            this.btbLogin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btbLogin.Name = "btbLogin";
            this.btbLogin.Size = new System.Drawing.Size(297, 41);
            this.btbLogin.TabIndex = 6;
            this.btbLogin.Text = "Đăng nhập";
            this.btbLogin.Click += new System.EventHandler(this.btbLogin_Click);
            // 
            // btbClear
            // 
            this.btbClear.FlatAppearance.BorderSize = 2;
            this.btbClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbClear.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btbClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btbClear.Location = new System.Drawing.Point(50, 400);
            this.btbClear.Name = "btbClear";
            this.btbClear.Size = new System.Drawing.Size(297, 36);
            this.btbClear.TabIndex = 7;
            this.btbClear.Text = "Xóa nhanh";
            this.btbClear.UseVisualStyleBackColor = true;
            this.btbClear.Click += new System.EventHandler(this.btbClear_Click);
            // 
            // lblResig
            // 
            this.lblResig.AutoSize = true;
            this.lblResig.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(78)))), ((int)(((byte)(165)))));
            this.lblResig.Location = new System.Drawing.Point(121, 448);
            this.lblResig.Name = "lblResig";
            this.lblResig.Size = new System.Drawing.Size(159, 23);
            this.lblResig.TabIndex = 8;
            this.lblResig.Text = "Đăng ký tài khoản";
            this.lblResig.Click += new System.EventHandler(this.lblResig_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 522);
            this.Controls.Add(this.lblResig);
            this.Controls.Add(this.btbClear);
            this.Controls.Add(this.btbLogin);
            this.Controls.Add(this.checkboxShow);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblNoti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.lblNoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblNoti;
        private Telerik.WinControls.UI.RadLabel lbl1;
        private Telerik.WinControls.UI.RadTextBox txtUserName;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadLabel label2;
        private Telerik.WinControls.UI.RadCheckBox checkboxShow;
        private Telerik.WinControls.UI.RadButton btbLogin;
        private System.Windows.Forms.Button btbClear;
        private System.Windows.Forms.Label lblResig;
    }
}
