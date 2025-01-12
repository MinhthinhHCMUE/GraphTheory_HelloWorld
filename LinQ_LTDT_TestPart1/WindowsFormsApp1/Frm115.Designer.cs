namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radFormConverter1 = new Telerik.WinControls.UI.RadFormConverter();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.EmercengyButton = new Telerik.WinControls.UI.RadButton();
            this.cmbDiseaseType = new System.Windows.Forms.ComboBox();
            this.txtStreetName = new Telerik.WinControls.UI.RadTextBox();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.btnRun = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmercengyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreetName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.79681F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.68983F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.31017F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1541, 438);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.5866F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.4134F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRun, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1535, 321);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.EmercengyButton, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.cmbDiseaseType, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtStreetName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtHint, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.12214F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.87786F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(851, 315);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // EmercengyButton
            // 
            this.EmercengyButton.BackColor = System.Drawing.Color.Red;
            this.EmercengyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmercengyButton.Image = ((System.Drawing.Image)(resources.GetObject("EmercengyButton.Image")));
            this.EmercengyButton.Location = new System.Drawing.Point(38, 169);
            this.EmercengyButton.Margin = new System.Windows.Forms.Padding(38, 38, 38, 38);
            this.EmercengyButton.Name = "EmercengyButton";
            this.EmercengyButton.Size = new System.Drawing.Size(775, 77);
            this.EmercengyButton.TabIndex = 3;
            this.EmercengyButton.Click += new System.EventHandler(this.EmergencyButton_Click);
            this.EmercengyButton.MouseLeave += new System.EventHandler(this.Emercengy_MouseLeave);
            this.EmercengyButton.MouseHover += new System.EventHandler(this.Emercengy_MouseHover);
            // 
            // cmbDiseaseType
            // 
            this.cmbDiseaseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDiseaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiseaseType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbDiseaseType.FormattingEnabled = true;
            this.cmbDiseaseType.Location = new System.Drawing.Point(12, 96);
            this.cmbDiseaseType.Margin = new System.Windows.Forms.Padding(12);
            this.cmbDiseaseType.Name = "cmbDiseaseType";
            this.cmbDiseaseType.Size = new System.Drawing.Size(827, 28);
            this.cmbDiseaseType.TabIndex = 2;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStreetName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtStreetName.Location = new System.Drawing.Point(55, 55);
            this.txtStreetName.Margin = new System.Windows.Forms.Padding(55, 55, 55, 55);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(741, 33);
            this.txtStreetName.TabIndex = 1;
            // 
            // txtHint
            // 
            this.txtHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHint.Location = new System.Drawing.Point(2, 286);
            this.txtHint.Margin = new System.Windows.Forms.Padding(2);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(847, 34);
            this.txtHint.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRun.Location = new System.Drawing.Point(881, 24);
            this.btnRun.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(533, 273);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Bắt đầu";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1541, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp cứu 115";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmercengyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreetName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadFormConverter radFormConverter1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Telerik.WinControls.UI.RadTextBox txtStreetName;
        private System.Windows.Forms.ComboBox cmbDiseaseType;
        private Telerik.WinControls.UI.RadButton btnRun;
        private Telerik.WinControls.UI.RadButton EmercengyButton;
        private System.Windows.Forms.TextBox txtHint;
    }
}
