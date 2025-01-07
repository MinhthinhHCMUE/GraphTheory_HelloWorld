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
            this.Btb115 = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtbHostoHos = new Telerik.WinControls.UI.RadButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboAlgorithm.ComboBoxElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btb115)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtbHostoHos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu2)).BeginInit();
            this.radMenu2.SuspendLayout();
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
            this.lblAlgorNoti});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 1011);
            this.radStatusStrip1.Margin = new System.Windows.Forms.Padding(3360, 3360, 3360, 3360);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1912, 36);
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
            this.radMenu1.Location = new System.Drawing.Point(80, 231);
            this.radMenu1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            // Btb115
            // 
            this.Btb115.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btb115.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btb115.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Btb115.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Btb115.Image = global::WindowsFormsApp1.Properties.Resources.ezgif_com_resize;
            this.Btb115.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btb115.Location = new System.Drawing.Point(149, 421);
            this.Btb115.Margin = new System.Windows.Forms.Padding(149, 149, 149, 149);
            this.Btb115.Name = "Btb115";
            this.Btb115.Size = new System.Drawing.Size(658, 312);
            this.Btb115.TabIndex = 2;
            this.Btb115.Text = "Cấp cứu 115";
            this.Btb115.Click += new System.EventHandler(this.Btb115_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.BackGroundHCMUE;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Btb115, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtbHostoHos, 1, 1);
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
            // BtbHostoHos
            // 
            this.BtbHostoHos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtbHostoHos.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtbHostoHos.Image = global::WindowsFormsApp1.Properties.Resources.HospitalToHospitalGIf;
            this.BtbHostoHos.Location = new System.Drawing.Point(1087, 403);
            this.BtbHostoHos.Margin = new System.Windows.Forms.Padding(131, 131, 131, 131);
            this.BtbHostoHos.Name = "BtbHostoHos";
            this.BtbHostoHos.Size = new System.Drawing.Size(694, 348);
            this.BtbHostoHos.TabIndex = 3;
            this.BtbHostoHos.Text = "Chuyển tuyến";
            this.BtbHostoHos.Click += new System.EventHandler(this.btbChuyenTuyen_Click);
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
            this.radMenu2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radMenu2.Name = "radMenu2";
            this.radMenu2.Size = new System.Drawing.Size(1912, 36);
            this.radMenu2.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.Btb115)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtbHostoHos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu2)).EndInit();
            this.radMenu2.ResumeLayout(false);
            this.radMenu2.PerformLayout();
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
        private Telerik.WinControls.UI.RadButton Btb115;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadMenuButtonItem btbIntroduce;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem10;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem11;
        private Telerik.WinControls.UI.RadButton BtbHostoHos;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.RadLabelElement lblAlgorNoti;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem12;
        private Telerik.WinControls.UI.RadMenu radMenu2;
    }
}
