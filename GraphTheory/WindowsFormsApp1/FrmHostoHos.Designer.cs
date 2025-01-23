namespace WindowsFormsApp1
{
    partial class FrmHostoHos
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

        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHostoHos));
            this.radFormConverter1 = new Telerik.WinControls.UI.RadFormConverter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RGVPatient = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btbSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radSeparator2 = new Telerik.WinControls.UI.RadSeparator();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbHosPatient = new System.Windows.Forms.ComboBox();
            this.cmbToHos = new System.Windows.Forms.ComboBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.btbRun = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGVPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVPatient.MasterTemplate)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.9153F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.0847F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1376, 791);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.RGVPatient, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 295);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.57447F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 432F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1370, 493);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // RGVPatient
            // 
            this.RGVPatient.AutoSizeRows = true;
            this.RGVPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGVPatient.Location = new System.Drawing.Point(15, 76);
            this.RGVPatient.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            // 
            // 
            // 
            this.RGVPatient.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.RGVPatient.MasterTemplate.EnableGrouping = false;
            this.RGVPatient.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.RGVPatient.Name = "RGVPatient";
            this.RGVPatient.ReadOnly = true;
            this.RGVPatient.Size = new System.Drawing.Size(1340, 402);
            this.RGVPatient.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.53904F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.46096F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 417F));
            this.tableLayoutPanel5.Controls.Add(this.btbSearch, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.radSeparator1, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtName, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.radSeparator2, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.button2, 6, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1364, 55);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btbSearch
            // 
            this.btbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbSearch.Location = new System.Drawing.Point(3, 3);
            this.btbSearch.Name = "btbSearch";
            this.btbSearch.Size = new System.Drawing.Size(139, 49);
            this.btbSearch.TabIndex = 0;
            this.btbSearch.Text = "Tìm theo ID";
            this.btbSearch.UseVisualStyleBackColor = true;
            this.btbSearch.Click += new System.EventHandler(this.btbSearch_Click);
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.Location = new System.Drawing.Point(160, 10);
            this.txtID.Margin = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(202, 38);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radSeparator1
            // 
            this.radSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSeparator1.Location = new System.Drawing.Point(392, 15);
            this.radSeparator1.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator1.Size = new System.Drawing.Size(1, 25);
            this.radSeparator1.TabIndex = 2;
            ((Telerik.WinControls.UI.SeparatorElement)(this.radSeparator1.GetChildAt(0))).Orientation = System.Windows.Forms.Orientation.Vertical;
            ((Telerik.WinControls.UI.SeparatorElement)(this.radSeparator1.GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.LinePrimitive)(this.radSeparator1.GetChildAt(0).GetChildAt(0))).SeparatorOrientation = Telerik.WinControls.SepOrientation.Vertical;
            ((Telerik.WinControls.Primitives.LinePrimitive)(this.radSeparator1.GetChildAt(0).GetChildAt(0))).SweepAngle = 90;
            ((Telerik.WinControls.Primitives.LinePrimitive)(this.radSeparator1.GetChildAt(0).GetChildAt(0))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentPadding;
            ((Telerik.WinControls.Primitives.LinePrimitive)(this.radSeparator1.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.LinePrimitive)(this.radSeparator1.GetChildAt(0).GetChildAt(0))).AngleTransform = 0F;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(397, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm theo tên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchByName);
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(563, 10);
            this.txtName.Margin = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(343, 38);
            this.txtName.TabIndex = 4;
            // 
            // radSeparator2
            // 
            this.radSeparator2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSeparator2.Location = new System.Drawing.Point(936, 15);
            this.radSeparator2.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.radSeparator2.Name = "radSeparator2";
            this.radSeparator2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator2.Size = new System.Drawing.Size(1, 25);
            this.radSeparator2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(949, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(412, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Chọn bệnh nhân cần chuyển viện!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btbSelecPatient);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.73834F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.26166F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btbRun, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1370, 286);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel4.Controls.Add(this.cmbHosPatient, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmbToHos, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblPatient, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.35165F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.64835F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(716, 280);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // cmbHosPatient
            // 
            this.cmbHosPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHosPatient.Enabled = false;
            this.cmbHosPatient.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbHosPatient.FormattingEnabled = true;
            this.cmbHosPatient.Location = new System.Drawing.Point(15, 111);
            this.cmbHosPatient.Margin = new System.Windows.Forms.Padding(15);
            this.cmbHosPatient.Name = "cmbHosPatient";
            this.cmbHosPatient.Size = new System.Drawing.Size(602, 45);
            this.cmbHosPatient.TabIndex = 0;
            // 
            // cmbToHos
            // 
            this.cmbToHos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbToHos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToHos.Enabled = false;
            this.cmbToHos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbToHos.Location = new System.Drawing.Point(15, 213);
            this.cmbToHos.Margin = new System.Windows.Forms.Padding(15);
            this.cmbToHos.Name = "cmbToHos";
            this.cmbToHos.Size = new System.Drawing.Size(602, 45);
            this.cmbToHos.TabIndex = 1;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPatient.Location = new System.Drawing.Point(3, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(626, 96);
            this.lblPatient.TabIndex = 2;
            this.lblPatient.Text = "Chọn bệnh nhân bên dưới!!";
            this.lblPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btbRun
            // 
            this.btbRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbRun.Image = global::WindowsFormsApp1.Properties.Resources.resizeFrmHos;
            this.btbRun.Location = new System.Drawing.Point(747, 25);
            this.btbRun.Margin = new System.Windows.Forms.Padding(25);
            this.btbRun.Name = "btbRun";
            this.btbRun.Size = new System.Drawing.Size(598, 236);
            this.btbRun.TabIndex = 1;
            this.btbRun.Text = "Bắt đầu";
            this.btbRun.UseVisualStyleBackColor = true;
            this.btbRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // FrmHostoHos
            // 
            this.ClientSize = new System.Drawing.Size(1376, 791);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHostoHos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính năng chuyển tuyến";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGVPatient.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVPatient)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadFormConverter radFormConverter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btbRun;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btbSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cmbHosPatient;
        private System.Windows.Forms.ComboBox cmbToHos;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private Telerik.WinControls.UI.RadSeparator radSeparator2;
        private System.Windows.Forms.Button button2;
        private Telerik.WinControls.UI.RadGridView RGVPatient;
    }
}
