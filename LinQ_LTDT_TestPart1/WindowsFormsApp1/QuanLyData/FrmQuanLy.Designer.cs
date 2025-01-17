﻿using System.Windows.Forms;

namespace WindowsFormsApp1.QuanLyData
{
    partial class FrmQuanLy
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radNavigationView1 = new Telerik.WinControls.UI.RadNavigationView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btbAmbuView = new System.Windows.Forms.Button();
            this.btbAmbuEdit = new System.Windows.Forms.Button();
            this.RGVAmbu = new Telerik.WinControls.UI.RadGridView();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btbXemUser = new System.Windows.Forms.Button();
            this.btbEditUser = new System.Windows.Forms.Button();
            this.RGVUser = new Telerik.WinControls.UI.RadGridView();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btbXemHospital = new System.Windows.Forms.Button();
            this.btbEditHospital = new System.Windows.Forms.Button();
            this.RGVHospital = new Telerik.WinControls.UI.RadGridView();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btbXemPatient = new System.Windows.Forms.Button();
            this.btbSuaPatient = new System.Windows.Forms.Button();
            this.RGVPatient = new Telerik.WinControls.UI.RadGridView();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radNavigationView1)).BeginInit();
            this.radNavigationView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu.MasterTemplate)).BeginInit();
            this.radPageViewPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGVUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVUser.MasterTemplate)).BeginInit();
            this.radPageViewPage4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGVHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVHospital.MasterTemplate)).BeginInit();
            this.radPageViewPage2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGVPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVPatient.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radNavigationView1
            // 
            this.radNavigationView1.CollapsedPaneWidth = 380;
            this.radNavigationView1.CompactModeThresholdWidth = 5968;
            this.radNavigationView1.Controls.Add(this.radPageViewPage1);
            this.radNavigationView1.Controls.Add(this.radPageViewPage3);
            this.radNavigationView1.Controls.Add(this.radPageViewPage4);
            this.radNavigationView1.Controls.Add(this.radPageViewPage2);
            this.radNavigationView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radNavigationView1.ExpandedModeThresholdWidth = 9388;
            this.radNavigationView1.ExpandedPaneWidth = 2614;
            this.radNavigationView1.HeaderHeight = 289;
            this.radNavigationView1.HierarchyIndent = 186;
            this.radNavigationView1.Location = new System.Drawing.Point(0, 0);
            this.radNavigationView1.Margin = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.radNavigationView1.Name = "radNavigationView1";
            this.radNavigationView1.SelectedPage = this.radPageViewPage4;
            this.radNavigationView1.Size = new System.Drawing.Size(1912, 1047);
            this.radNavigationView1.TabIndex = 0;
            this.radNavigationView1.ThemeName = "Crystal";
            this.radNavigationView1.SelectedPageChanged += new System.EventHandler(this.RadNavigationChanged);
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.tableLayoutPanel1);
            this.radPageViewPage1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(22F, 22F);
            this.radPageViewPage1.Location = new System.Drawing.Point(381, 290);
            this.radPageViewPage1.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(1530, 756);
            this.radPageViewPage1.Text = "Quản lý xe cứu thương";
            this.radPageViewPage1.Click += new System.EventHandler(this.btnAmbulance_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RGVAmbu, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.54978F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.45023F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1530, 756);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.03946F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.96054F));
            this.tableLayoutPanel2.Controls.Add(this.btbAmbuView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btbAmbuEdit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1510, 59);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btbAmbuView
            // 
            this.btbAmbuView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbAmbuView.Location = new System.Drawing.Point(6, 6);
            this.btbAmbuView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btbAmbuView.Name = "btbAmbuView";
            this.btbAmbuView.Size = new System.Drawing.Size(743, 47);
            this.btbAmbuView.TabIndex = 0;
            this.btbAmbuView.Text = "Xem";
            this.btbAmbuView.UseVisualStyleBackColor = true;
            this.btbAmbuView.Click += new System.EventHandler(this.btnAmbulance_Click);
            // 
            // btbAmbuEdit
            // 
            this.btbAmbuEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbAmbuEdit.Location = new System.Drawing.Point(761, 6);
            this.btbAmbuEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btbAmbuEdit.Name = "btbAmbuEdit";
            this.btbAmbuEdit.Size = new System.Drawing.Size(743, 47);
            this.btbAmbuEdit.TabIndex = 1;
            this.btbAmbuEdit.Text = "Chỉnh sửa";
            this.btbAmbuEdit.UseVisualStyleBackColor = true;
            this.btbAmbuEdit.Click += new System.EventHandler(this.btnAmbulanceEdit_Click);
            // 
            // RGVAmbu
            // 
            this.RGVAmbu.AutoGenerateHierarchy = true;
            this.RGVAmbu.AutoSizeRows = true;
            this.RGVAmbu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGVAmbu.Location = new System.Drawing.Point(12, 91);
            this.RGVAmbu.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            // 
            // 
            // 
            this.RGVAmbu.MasterTemplate.AutoExpandGroups = true;
            this.RGVAmbu.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.RGVAmbu.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.RGVAmbu.Name = "RGVAmbu";
            this.RGVAmbu.Size = new System.Drawing.Size(1506, 653);
            this.RGVAmbu.TabIndex = 1;
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.Controls.Add(this.tableLayoutPanel3);
            this.radPageViewPage3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radPageViewPage3.ItemSize = new System.Drawing.SizeF(22F, 22F);
            this.radPageViewPage3.Location = new System.Drawing.Point(381, 290);
            this.radPageViewPage3.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(1530, 756);
            this.radPageViewPage3.Text = "Quản lý User";
            this.radPageViewPage3.Click += new System.EventHandler(this.btbUser_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.RGVUser, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.54237F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.45763F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1530, 756);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btbXemUser, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btbEditUser, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1514, 63);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btbXemUser
            // 
            this.btbXemUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbXemUser.Location = new System.Drawing.Point(610, 30);
            this.btbXemUser.Margin = new System.Windows.Forms.Padding(610, 30, 610, 30);
            this.btbXemUser.Name = "btbXemUser";
            this.btbXemUser.Size = new System.Drawing.Size(1, 3);
            this.btbXemUser.TabIndex = 0;
            this.btbXemUser.Text = "Xem";
            this.btbXemUser.UseVisualStyleBackColor = true;
            this.btbXemUser.Click += new System.EventHandler(this.btbUser_Click);
            // 
            // btbEditUser
            // 
            this.btbEditUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbEditUser.Location = new System.Drawing.Point(1367, 30);
            this.btbEditUser.Margin = new System.Windows.Forms.Padding(610, 30, 610, 30);
            this.btbEditUser.Name = "btbEditUser";
            this.btbEditUser.Size = new System.Drawing.Size(1, 3);
            this.btbEditUser.TabIndex = 1;
            this.btbEditUser.Text = "Chỉnh sửa";
            this.btbEditUser.UseVisualStyleBackColor = true;
            this.btbEditUser.Click += new System.EventHandler(this.btbUserEdit_Click);
            // 
            // RGVUser
            // 
            this.RGVUser.AutoSizeRows = true;
            this.RGVUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGVUser.Location = new System.Drawing.Point(8, 87);
            this.RGVUser.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            // 
            // 
            // 
            this.RGVUser.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.RGVUser.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.RGVUser.Name = "RGVUser";
            this.RGVUser.Size = new System.Drawing.Size(1514, 661);
            this.RGVUser.TabIndex = 1;
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.Controls.Add(this.tableLayoutPanel7);
            this.radPageViewPage4.ItemSize = new System.Drawing.SizeF(22F, 22F);
            this.radPageViewPage4.Location = new System.Drawing.Point(381, 290);
            this.radPageViewPage4.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Size = new System.Drawing.Size(1530, 756);
            this.radPageViewPage4.Text = "Quản lý hospital";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.RGVHospital, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.60891F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.39109F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1530, 756);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.btbXemHospital, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btbEditHospital, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1514, 64);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // btbXemHospital
            // 
            this.btbXemHospital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbXemHospital.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btbXemHospital.Location = new System.Drawing.Point(15, 15);
            this.btbXemHospital.Margin = new System.Windows.Forms.Padding(15);
            this.btbXemHospital.Name = "btbXemHospital";
            this.btbXemHospital.Size = new System.Drawing.Size(727, 34);
            this.btbXemHospital.TabIndex = 0;
            this.btbXemHospital.Text = "Xem";
            this.btbXemHospital.UseVisualStyleBackColor = true;
            this.btbXemHospital.Click += new System.EventHandler(this.btbHospital_Click);
            // 
            // btbEditHospital
            // 
            this.btbEditHospital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbEditHospital.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btbEditHospital.Location = new System.Drawing.Point(1367, 30);
            this.btbEditHospital.Margin = new System.Windows.Forms.Padding(610, 30, 610, 30);
            this.btbEditHospital.Name = "btbEditHospital";
            this.btbEditHospital.Size = new System.Drawing.Size(1, 4);
            this.btbEditHospital.TabIndex = 1;
            this.btbEditHospital.Text = "Chỉnh sửa";
            this.btbEditHospital.UseVisualStyleBackColor = true;
            this.btbEditHospital.Click += new System.EventHandler(this.btbHospitalEdit_Click);
            // 
            // RGVHospital
            // 
            this.RGVHospital.AutoSizeRows = true;
            this.RGVHospital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGVHospital.Location = new System.Drawing.Point(6, 86);
            this.RGVHospital.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            // 
            // 
            // 
            this.RGVHospital.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.RGVHospital.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.RGVHospital.Name = "RGVHospital";
            this.RGVHospital.Size = new System.Drawing.Size(1518, 664);
            this.RGVHospital.TabIndex = 1;
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Controls.Add(this.tableLayoutPanel5);
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(22F, 22F);
            this.radPageViewPage2.Location = new System.Drawing.Point(381, 290);
            this.radPageViewPage2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(1530, 756);
            this.radPageViewPage2.Text = "Quản lý bệnh nhân";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.RGVPatient, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47766F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.52234F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1530, 756);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btbXemPatient, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btbSuaPatient, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1514, 63);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btbXemPatient
            // 
            this.btbXemPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbXemPatient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btbXemPatient.Location = new System.Drawing.Point(610, 30);
            this.btbXemPatient.Margin = new System.Windows.Forms.Padding(610, 30, 610, 30);
            this.btbXemPatient.Name = "btbXemPatient";
            this.btbXemPatient.Size = new System.Drawing.Size(1, 3);
            this.btbXemPatient.TabIndex = 0;
            this.btbXemPatient.Text = "Xem";
            this.btbXemPatient.UseVisualStyleBackColor = true;
            this.btbXemPatient.Click += new System.EventHandler(this.btbPatient_Click);
            // 
            // btbSuaPatient
            // 
            this.btbSuaPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbSuaPatient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btbSuaPatient.Location = new System.Drawing.Point(1367, 30);
            this.btbSuaPatient.Margin = new System.Windows.Forms.Padding(610, 30, 610, 30);
            this.btbSuaPatient.Name = "btbSuaPatient";
            this.btbSuaPatient.Size = new System.Drawing.Size(1, 3);
            this.btbSuaPatient.TabIndex = 1;
            this.btbSuaPatient.Text = "Chỉnh sửa";
            this.btbSuaPatient.UseVisualStyleBackColor = true;
            this.btbSuaPatient.Click += new System.EventHandler(this.btbPatientEdit_Click);
            // 
            // RGVPatient
            // 
            this.RGVPatient.AutoSizeRows = true;
            this.RGVPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGVPatient.Location = new System.Drawing.Point(6, 85);
            this.RGVPatient.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            // 
            // 
            // 
            this.RGVPatient.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.RGVPatient.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.RGVPatient.Name = "RGVPatient";
            this.RGVPatient.Size = new System.Drawing.Size(1518, 665);
            this.RGVPatient.TabIndex = 1;
            // 
            // FrmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1047);
            this.Controls.Add(this.radNavigationView1);
            this.Name = "FrmQuanLy";
            this.Text = "FrmQuanLy";
            this.Load += new System.EventHandler(this.FrmQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radNavigationView1)).EndInit();
            this.radNavigationView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu)).EndInit();
            this.radPageViewPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGVUser.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVUser)).EndInit();
            this.radPageViewPage4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGVHospital.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVHospital)).EndInit();
            this.radPageViewPage2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGVPatient.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadNavigationView radNavigationView1;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btbAmbuView;
        private Button btbAmbuEdit;
        private Telerik.WinControls.UI.RadGridView RGVAmbu;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Telerik.WinControls.UI.RadGridView RGVUser;
        private Button btbXemUser;
        private Button btbEditUser;
        private Telerik.WinControls.UI.RadGridView RGVPatient;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btbXemPatient;
        private Button btbSuaPatient;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Button btbXemHospital;
        private Button btbEditHospital;
        private Telerik.WinControls.UI.RadGridView RGVHospital;
    }
}
