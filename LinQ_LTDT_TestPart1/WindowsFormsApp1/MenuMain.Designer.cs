namespace WindowsFormsApp1
{
    partial class MenuMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMain));
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.NgayVaGio = new System.Windows.Forms.Timer(this.components);
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.lblAlgorNoti = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radMenuButtonItem3 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuButtonItem1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem2 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuButtonItem5 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem6 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.ComboAlgorithm = new Telerik.WinControls.UI.RadMenuComboItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuButtonItem4 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadDropDownMenu();
            this.radMenuButtonItem7 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btbIntroduce = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem9 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuButtonItem10 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuButtonItem11 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuButtonItem8 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem12 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenu2 = new Telerik.WinControls.UI.RadMenu();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btb115 = new System.Windows.Forms.Button();
            this.btbHostoHos = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFrm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboAlgorithm.ComboBoxElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu2)).BeginInit();
            this.radMenu2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // NgayVaGio
            // 
            this.NgayVaGio.Tick += new System.EventHandler(this.NgayVaGio_Tick);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.commandBarSeparator1,
            this.lblAlgorNoti,
            this.commandBarSeparator2,
            this.radButtonElement1});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 1004);
            this.radStatusStrip1.Margin = new System.Windows.Forms.Padding(25030, 25030, 25030, 25030);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1912, 43);
            this.radStatusStrip1.TabIndex = 3;
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "radLabelElement1";
            this.radLabelElement1.TextWrap = true;
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // lblAlgorNoti
            // 
            this.lblAlgorNoti.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAlgorNoti.Name = "lblAlgorNoti";
            this.radStatusStrip1.SetSpring(this.lblAlgorNoti, false);
            this.lblAlgorNoti.Text = "Thuật toán đang được sử dụng : Dijkstra";
            this.lblAlgorNoti.TextWrap = true;
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator2, false);
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.BackColor = System.Drawing.Color.Red;
            this.radButtonElement1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.RippleAnimationColor = System.Drawing.Color.Red;
            this.radButtonElement1.ShowBorder = false;
            this.radStatusStrip1.SetSpring(this.radButtonElement1, false);
            this.radButtonElement1.Text = "Quản lý dữ liệu ( chỉ dành cho Admin! )";
            this.radButtonElement1.Click += new System.EventHandler(this.FrmQuanly_click);
            // 
            // radMenuButtonItem3
            // 
            // 
            // 
            // 
            this.radMenuButtonItem3.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem3.Name = "radMenuButtonItem3";
            this.radMenuButtonItem3.Text = "radMenuButtonItem3";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "radMenuItem2";
            // 
            // radMenuButtonItem1
            // 
            this.radMenuButtonItem1.BorderHighlightColor = System.Drawing.Color.Black;
            this.radMenuButtonItem1.BorderHighlightThickness = 2;
            // 
            // 
            // 
            this.radMenuButtonItem1.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem1.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.radMenuButtonItem1.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            this.radMenuButtonItem1.Name = "radMenuButtonItem1";
            this.radMenuButtonItem1.Text = "Giới thiệu đề tài";
            this.radMenuButtonItem1.UseCompatibleTextRendering = false;
            this.radMenuButtonItem1.Click += new System.EventHandler(this.radMenuButtonItem1_Click);
            // 
            // radMenuButtonItem2
            // 
            // 
            // 
            // 
            this.radMenuButtonItem2.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem2.Name = "radMenuButtonItem2";
            this.radMenuButtonItem2.Text = "Hướng dẫn sử dụng";
            this.radMenuButtonItem2.UseCompatibleTextRendering = false;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuButtonItem5,
            this.radMenuButtonItem6});
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Giới thiệu và minh họa thuật toán";
            this.radMenuItem3.UseCompatibleTextRendering = false;
            // 
            // radMenuButtonItem5
            // 
            // 
            // 
            // 
            this.radMenuButtonItem5.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem5.Name = "radMenuButtonItem5";
            this.radMenuButtonItem5.Text = "radMenuButtonItem5";
            this.radMenuButtonItem5.UseCompatibleTextRendering = false;
            // 
            // radMenuButtonItem6
            // 
            // 
            // 
            // 
            this.radMenuButtonItem6.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem6.Name = "radMenuButtonItem6";
            this.radMenuButtonItem6.Text = "radMenuButtonItem6";
            this.radMenuButtonItem6.UseCompatibleTextRendering = false;
            // 
            // ComboAlgorithm
            // 
            // 
            // 
            // 
            this.ComboAlgorithm.ComboBoxElement.DropDownHeight = 260;
            this.ComboAlgorithm.ComboBoxElement.ItemHeight = 48;
            this.ComboAlgorithm.ComboBoxElement.MaxLength = 65535;
            this.ComboAlgorithm.CustomFontStyle = System.Drawing.FontStyle.Regular;
            this.ComboAlgorithm.Name = "ComboAlgorithm";
            this.ComboAlgorithm.Text = "Chọn thuật toán";
            this.ComboAlgorithm.UseCompatibleTextRendering = false;
            this.ComboAlgorithm.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ComboAlgorithm});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Chọn thuật toán tìm đuờng đi";
            this.radMenuItem1.UseCompatibleTextRendering = false;
            // 
            // radMenuButtonItem4
            // 
            // 
            // 
            // 
            this.radMenuButtonItem4.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem4.Name = "radMenuButtonItem4";
            this.radMenuButtonItem4.Text = "radMenuButtonItem4";
            this.radMenuButtonItem4.UseCompatibleTextRendering = false;
            // 
            // radMenu1
            // 
            this.radMenu1.AnimationEnabled = false;
            this.radMenu1.AnimationFrames = 4;
            this.radMenu1.AnimationType = Telerik.WinControls.UI.PopupAnimationTypes.None;
            this.radMenu1.AutoSize = true;
            this.radMenu1.DropDownAnimationDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.radMenu1.DropShadow = true;
            this.radMenu1.EasingType = Telerik.WinControls.RadEasingType.Linear;
            this.radMenu1.EnableAeroEffects = false;
            this.radMenu1.FadeAnimationFrames = 10;
            this.radMenu1.FadeAnimationSpeed = 10;
            this.radMenu1.FadeAnimationType = Telerik.WinControls.UI.FadeAnimationType.FadeIn;
            this.radMenu1.FitToScreenMode = ((Telerik.WinControls.UI.FitToScreenModes)((Telerik.WinControls.UI.FitToScreenModes.FitWidth | Telerik.WinControls.UI.FitToScreenModes.FitHeight)));
            this.radMenu1.HorizontalAlignmentCorrectionMode = Telerik.WinControls.UI.AlignmentCorrectionMode.Smooth;
            this.radMenu1.LastShowDpiScaleFactor = new System.Drawing.SizeF(1.25F, 1.25F);
            this.radMenu1.Location = new System.Drawing.Point(624, 1839);
            this.radMenu1.Margin = new System.Windows.Forms.Padding(48, 48, 48, 48);
            this.radMenu1.Maximum = new System.Drawing.Size(0, 0);
            this.radMenu1.Minimum = new System.Drawing.Size(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Opacity = 1F;
            this.radMenu1.ProcessKeyboard = false;
            this.radMenu1.RollOverItemSelection = true;
            this.radMenu1.Size = new System.Drawing.Size(27, 2);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.VerticalAlignmentCorrectionMode = Telerik.WinControls.UI.AlignmentCorrectionMode.SnapToOuterEdges;
            this.radMenu1.Visible = false;
            // 
            // radMenuButtonItem7
            // 
            // 
            // 
            // 
            this.radMenuButtonItem7.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem7.Name = "radMenuButtonItem7";
            this.radMenuButtonItem7.Text = "radMenuButtonItem7";
            this.radMenuButtonItem7.UseCompatibleTextRendering = false;
            // 
            // btbIntroduce
            // 
            // 
            // 
            // 
            this.btbIntroduce.ButtonElement.ShowBorder = false;
            this.btbIntroduce.Name = "btbIntroduce";
            this.btbIntroduce.Text = "Giới thiệu đề tài";
            this.btbIntroduce.Click += new System.EventHandler(this.radMenuButtonItem1_Click);
            // 
            // radMenuButtonItem9
            // 
            // 
            // 
            // 
            this.radMenuButtonItem9.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem9.Name = "radMenuButtonItem9";
            this.radMenuButtonItem9.Text = "Hướng dẫn sử dụng";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuButtonItem10,
            this.radMenuSeparatorItem1,
            this.radMenuButtonItem11});
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Giới thiệu thuật toán";
            // 
            // radMenuButtonItem10
            // 
            // 
            // 
            // 
            this.radMenuButtonItem10.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem10.Name = "radMenuButtonItem10";
            this.radMenuButtonItem10.Text = "radMenuButtonItem10";
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuButtonItem11
            // 
            // 
            // 
            // 
            this.radMenuButtonItem11.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem11.Name = "radMenuButtonItem11";
            this.radMenuButtonItem11.Text = "radMenuButtonItem11";
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuButtonItem8,
            this.radMenuButtonItem12});
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Chọn thuật toán cho đề tài";
            // 
            // radMenuButtonItem8
            // 
            // 
            // 
            // 
            this.radMenuButtonItem8.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem8.Name = "radMenuButtonItem8";
            this.radMenuButtonItem8.Text = "Dijsktra Algorithm";
            this.radMenuButtonItem8.Click += new System.EventHandler(this.ButtonDijkstraSelec);
            // 
            // radMenuButtonItem12
            // 
            // 
            // 
            // 
            this.radMenuButtonItem12.ButtonElement.ShowBorder = false;
            this.radMenuButtonItem12.Name = "radMenuButtonItem12";
            this.radMenuButtonItem12.Text = "A* Algorithm";
            this.radMenuButtonItem12.Click += new System.EventHandler(this.ButtonAstarsSelec);
            // 
            // radMenu2
            // 
            this.radMenu2.Controls.Add(this.radMenu1);
            this.radMenu2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btbIntroduce,
            this.radMenuButtonItem9,
            this.radMenuItem4,
            this.radMenuItem5});
            this.radMenu2.Location = new System.Drawing.Point(0, 0);
            this.radMenu2.Margin = new System.Windows.Forms.Padding(38, 38, 38, 38);
            this.radMenu2.Name = "radMenu2";
            this.radMenu2.Size = new System.Drawing.Size(1912, 36);
            this.radMenu2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.88912F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.11088F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.839F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.161F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1912, 1047);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btb115, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btbHostoHos, 0, 1);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 275);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.16556F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.83444F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(488, 604);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btb115
            // 
            this.btb115.BackColor = System.Drawing.SystemColors.Control;
            this.btb115.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btb115.Image = global::WindowsFormsApp1.Properties.Resources.resize288;
            this.btb115.Location = new System.Drawing.Point(50, 50);
            this.btb115.Margin = new System.Windows.Forms.Padding(50);
            this.btb115.Name = "btb115";
            this.btb115.Size = new System.Drawing.Size(388, 203);
            this.btb115.TabIndex = 0;
            this.btb115.Text = "button1";
            this.btb115.UseVisualStyleBackColor = true;
            this.btb115.Click += new System.EventHandler(this.Btb115_Click);
            // 
            // btbHostoHos
            // 
            this.btbHostoHos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbHostoHos.Image = global::WindowsFormsApp1.Properties.Resources.resize288HOs;
            this.btbHostoHos.Location = new System.Drawing.Point(50, 353);
            this.btbHostoHos.Margin = new System.Windows.Forms.Padding(50);
            this.btbHostoHos.Name = "btbHostoHos";
            this.btbHostoHos.Size = new System.Drawing.Size(388, 201);
            this.btbHostoHos.TabIndex = 1;
            this.btbHostoHos.Text = "button2";
            this.btbHostoHos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.46742F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.532578F));
            this.tableLayoutPanel3.Controls.Add(this.pnlFrm, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(497, 275);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1412, 604);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // pnlFrm
            // 
            this.pnlFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrm.Location = new System.Drawing.Point(3, 3);
            this.pnlFrm.Name = "pnlFrm";
            this.pnlFrm.Size = new System.Drawing.Size(1342, 598);
            this.pnlFrm.TabIndex = 0;
            // 
            // MenuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1912, 1047);
            this.Controls.Add(this.radMenu2);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm tìm đường cho xe cứu thương";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboAlgorithm.ComboBoxElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu2)).EndInit();
            this.radMenu2.ResumeLayout(false);
            this.radMenu2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.Timer NgayVaGio;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem5;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem6;
        private Telerik.WinControls.UI.RadMenuComboItem ComboAlgorithm;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem4;
        private Telerik.WinControls.UI.RadDropDownMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadMenuButtonItem btbIntroduce;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem10;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem11;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.RadLabelElement lblAlgorNoti;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem12;
        private Telerik.WinControls.UI.RadMenu radMenu2;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btb115;
        private System.Windows.Forms.Button btbHostoHos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel pnlFrm;
    }
}
