namespace WindowsFormsApp1.QuanLyData
{
    partial class RadForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.bunifuAppBar1 = new Bunifu.Utils.BunifuAppBar();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.ngvView = new Telerik.WinControls.UI.RadNavigationView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.dgvData = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ngvView)).BeginInit();
            this.ngvView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuAppBar1
            // 
            this.bunifuAppBar1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuAppBar1.ControlBoxColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuAppBar1.ControlBoxColorActive = System.Drawing.Color.White;
            this.bunifuAppBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuAppBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuAppBar1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuAppBar1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuAppBar1.Icon")));
            this.bunifuAppBar1.Location = new System.Drawing.Point(455, 0);
            this.bunifuAppBar1.Name = "bunifuAppBar1";
            this.bunifuAppBar1.Size = new System.Drawing.Size(981, 46);
            this.bunifuAppBar1.TabIndex = 0;
            this.bunifuAppBar1.Title = "QUẢN LÝ THÔNG TIN";
            this.bunifuAppBar1.TitleMargin = new System.Windows.Forms.Padding(9);
            // 
            // ngvView
            // 
            this.ngvView.CollapsedPaneWidth = 79;
            this.ngvView.CompactModeThresholdWidth = 1251;
            this.ngvView.Controls.Add(this.radPageViewPage1);
            this.ngvView.Controls.Add(this.radPageViewPage2);
            this.ngvView.Controls.Add(this.radPageViewPage3);
            this.ngvView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ngvView.ExpandedModeThresholdWidth = 1969;
            this.ngvView.ExpandedPaneWidth = 548;
            this.ngvView.HeaderHeight = 60;
            this.ngvView.HierarchyIndent = 39;
            this.ngvView.Location = new System.Drawing.Point(0, 0);
            this.ngvView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ngvView.Name = "ngvView";
            this.ngvView.SelectedPage = this.radPageViewPage2;
            this.ngvView.Size = new System.Drawing.Size(455, 735);
            this.ngvView.TabIndex = 1;
            this.ngvView.ThemeName = "Crystal";
            this.ngvView.SelectedPageChanged += new System.EventHandler(this.btnAmbulance_Click);
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(140F, 44F);
            this.radPageViewPage1.Location = new System.Drawing.Point(549, 61);
            this.radPageViewPage1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(0, 673);
            this.radPageViewPage1.Text = "Quản lý xe";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(140F, 44F);
            this.radPageViewPage2.Location = new System.Drawing.Point(549, 61);
            this.radPageViewPage2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(0, 673);
            this.radPageViewPage2.Text = "Quản lý";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.radPageViewPage3.ItemSize = new System.Drawing.SizeF(140F, 44F);
            this.radPageViewPage3.Location = new System.Drawing.Point(549, 61);
            this.radPageViewPage3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(0, 856);
            this.radPageViewPage3.Text = "Xe cứu thương";
            // 
            // dgvData
            // 
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(455, 46);
            this.dgvData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            // 
            // 
            // 
            this.dgvData.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(981, 689);
            this.dgvData.TabIndex = 2;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 735);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.bunifuAppBar1);
            this.Controls.Add(this.ngvView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RadForm1";
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.ngvView)).EndInit();
            this.ngvView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Utils.BunifuAppBar bunifuAppBar1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadNavigationView ngvView;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadGridView dgvData;
    }
}
