namespace WindowsFormsApp1
{
    partial class FormView
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
            this.lblTime = new System.Windows.Forms.Label();
            this.ViewChose = new System.Windows.Forms.ComboBox();
            this.dTIME = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblNextRoute = new System.Windows.Forms.Label();
            this.radFormConverter1 = new Telerik.WinControls.UI.RadFormConverter();
            this.TimerFlashing = new System.Windows.Forms.Timer(this.components);
            this.flashingCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.lblNotiForTrackbar = new Telerik.WinControls.UI.RadLabel();
            this.lblNotiPause = new Telerik.WinControls.UI.RadLabel();
            this.pictureBoxZoom = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radTrackBar1 = new Telerik.WinControls.UI.RadTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.flashingCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNotiForTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNotiPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTime.Location = new System.Drawing.Point(1, 177);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 28);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            // 
            // ViewChose
            // 
            this.ViewChose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewChose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ViewChose.FormattingEnabled = true;
            this.ViewChose.Location = new System.Drawing.Point(3, 6);
            this.ViewChose.Name = "ViewChose";
            this.ViewChose.Size = new System.Drawing.Size(196, 31);
            this.ViewChose.TabIndex = 1;
            this.ViewChose.SelectedIndexChanged += new System.EventHandler(this.ViewChose_SelectedIndexChanged);
            // 
            // dTIME
            // 
            this.dTIME.Enabled = true;
            this.dTIME.Tick += new System.EventHandler(this.dTIME_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(212, 6);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(52, 21);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "label1";
            // 
            // lblNextRoute
            // 
            this.lblNextRoute.AutoSize = true;
            this.lblNextRoute.Location = new System.Drawing.Point(212, 33);
            this.lblNextRoute.Name = "lblNextRoute";
            this.lblNextRoute.Size = new System.Drawing.Size(52, 21);
            this.lblNextRoute.TabIndex = 5;
            this.lblNextRoute.Text = "label2";
            // 
            // TimerFlashing
            // 
            this.TimerFlashing.Interval = 500;
            this.TimerFlashing.Tick += new System.EventHandler(this.timerFlash_Tick);
            // 
            // flashingCheck
            // 
            this.flashingCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.flashingCheck.Location = new System.Drawing.Point(6, 225);
            this.flashingCheck.Margin = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.flashingCheck.Name = "flashingCheck";
            this.flashingCheck.Size = new System.Drawing.Size(204, 29);
            this.flashingCheck.TabIndex = 6;
            this.flashingCheck.Text = "Hiển thị đường đi";
            this.flashingCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.flashingCheck_ToggleStateChanged);
            // 
            // lblNotiForTrackbar
            // 
            this.lblNotiForTrackbar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNotiForTrackbar.Location = new System.Drawing.Point(6, 64);
            this.lblNotiForTrackbar.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.lblNotiForTrackbar.Name = "lblNotiForTrackbar";
            this.lblNotiForTrackbar.Size = new System.Drawing.Size(200, 24);
            this.lblNotiForTrackbar.TabIndex = 8;
            this.lblNotiForTrackbar.Text = "Thay đổi tốc độ mô phỏng";
            // 
            // lblNotiPause
            // 
            this.lblNotiPause.BackColor = System.Drawing.Color.Transparent;
            this.lblNotiPause.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNotiPause.ForeColor = System.Drawing.Color.Red;
            this.lblNotiPause.Location = new System.Drawing.Point(1831, 30);
            this.lblNotiPause.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.lblNotiPause.Name = "lblNotiPause";
            this.lblNotiPause.Size = new System.Drawing.Size(120, 35);
            this.lblNotiPause.TabIndex = 9;
            this.lblNotiPause.Text = "radLabel1";
            this.lblNotiPause.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNotiPause.ThemeName = "ControlDefault";
            this.lblNotiPause.Visible = false;
            // 
            // pictureBoxZoom
            // 
            this.pictureBoxZoom.Location = new System.Drawing.Point(159, 57);
            this.pictureBoxZoom.Name = "pictureBoxZoom";
            this.pictureBoxZoom.Size = new System.Drawing.Size(1696, 859);
            this.pictureBoxZoom.TabIndex = 3;
            this.pictureBoxZoom.TabStop = false;
            this.pictureBoxZoom.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2000, 2000);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radTrackBar1
            // 
            this.radTrackBar1.Location = new System.Drawing.Point(6, 105);
            this.radTrackBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radTrackBar1.Name = "radTrackBar1";
            this.radTrackBar1.Size = new System.Drawing.Size(242, 55);
            this.radTrackBar1.TabIndex = 10;
            this.radTrackBar1.ThumbSize = new System.Drawing.Size(20, 49);
            this.radTrackBar1.ValueChanged += new System.EventHandler(this.TimeTrackBar_ValueChanged);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.radTrackBar1);
            this.Controls.Add(this.lblNotiPause);
            this.Controls.Add(this.lblNotiForTrackbar);
            this.Controls.Add(this.flashingCheck);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNextRoute);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.pictureBoxZoom);
            this.Controls.Add(this.ViewChose);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "FormView";
            this.Text = "FormView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormView_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasueAnimation);
            ((System.ComponentModel.ISupportInitialize)(this.flashingCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNotiForTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNotiPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox ViewChose;
        private System.Windows.Forms.Timer dTIME;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxZoom;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblNextRoute;
        private Telerik.WinControls.UI.RadFormConverter radFormConverter1;
        private System.Windows.Forms.Timer TimerFlashing;
        private Telerik.WinControls.UI.RadCheckBox flashingCheck;
        private Telerik.WinControls.UI.RadLabel lblNotiForTrackbar;
        private Telerik.WinControls.UI.RadLabel lblNotiPause;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar1;
    }
}
