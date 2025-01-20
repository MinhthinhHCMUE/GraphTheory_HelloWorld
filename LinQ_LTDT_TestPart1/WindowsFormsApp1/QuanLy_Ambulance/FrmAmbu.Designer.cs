namespace WindowsFormsApp1.QuanLy_Ambulance
{
    partial class FrmAmbu
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.timercheck = new System.Windows.Forms.Timer(this.components);
            this.RGVAmbu = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNotication = new System.Windows.Forms.Label();
            this.cmbListAmbu = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btbView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu.MasterTemplate)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // timercheck
            // 
            this.timercheck.Tick += new System.EventHandler(this.timercheck_Tick);
            // 
            // RGVAmbu
            // 
            this.RGVAmbu.AutoSizeRows = true;
            this.RGVAmbu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGVAmbu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RGVAmbu.Location = new System.Drawing.Point(12, 137);
            this.RGVAmbu.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            // 
            // 
            // 
            this.RGVAmbu.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.RGVAmbu.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.RGVAmbu.Name = "RGVAmbu";
            this.RGVAmbu.ReadOnly = true;
            this.RGVAmbu.Size = new System.Drawing.Size(1317, 656);
            this.RGVAmbu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RGVAmbu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.65217F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.34782F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1341, 805);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.56089F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.43911F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btbView, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1335, 119);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblNotication, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbListAmbu, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.26316F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.73684F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(927, 113);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblNotication
            // 
            this.lblNotication.AutoSize = true;
            this.lblNotication.BackColor = System.Drawing.Color.White;
            this.lblNotication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNotication.Location = new System.Drawing.Point(3, 10);
            this.lblNotication.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblNotication.Name = "lblNotication";
            this.lblNotication.Size = new System.Drawing.Size(921, 42);
            this.lblNotication.TabIndex = 0;
            this.lblNotication.Text = "Đang chờ tín hiệu từ xe cứu thương!";
            this.lblNotication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbListAmbu
            // 
            this.cmbListAmbu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbListAmbu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListAmbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbListAmbu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbListAmbu.FormattingEnabled = true;
            this.cmbListAmbu.Location = new System.Drawing.Point(3, 72);
            this.cmbListAmbu.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.cmbListAmbu.Name = "cmbListAmbu";
            this.cmbListAmbu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbListAmbu.Size = new System.Drawing.Size(921, 36);
            this.cmbListAmbu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(948, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "Phản hồi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btbView
            // 
            this.btbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbView.FlatAppearance.BorderSize = 2;
            this.btbView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbView.Location = new System.Drawing.Point(1149, 15);
            this.btbView.Margin = new System.Windows.Forms.Padding(6, 15, 6, 15);
            this.btbView.Name = "btbView";
            this.btbView.Size = new System.Drawing.Size(180, 89);
            this.btbView.TabIndex = 2;
            this.btbView.Text = "Xem mô phỏng";
            this.btbView.UseVisualStyleBackColor = true;
            this.btbView.Click += new System.EventHandler(this.btbClick);
            // 
            // FrmAmbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(1341, 805);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAmbu";
            this.Text = "FrmAmbu";
            this.Load += new System.EventHandler(this.FrmAmbu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timercheck;
        private Telerik.WinControls.UI.RadGridView RGVAmbu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblNotication;
        private System.Windows.Forms.ComboBox cmbListAmbu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btbView;
    }
}
