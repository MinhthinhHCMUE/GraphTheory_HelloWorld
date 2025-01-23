namespace WindowsFormsApp1
{
    partial class AlgorithmFrm
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
            Telerik.WinControls.ThemeSource themeSource1 = new Telerik.WinControls.ThemeSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlgorithmFrm));
            this.radSlideView1 = new Telerik.WinControls.UI.RadSlideView();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            this.radThemeManager2 = new Telerik.WinControls.RadThemeManager();
            ((System.ComponentModel.ISupportInitialize)(this.radSlideView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radSlideView1
            // 
            this.radSlideView1.AccessibleDescription = "A slide view control.";
            this.radSlideView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSlideView1.Location = new System.Drawing.Point(0, 0);
            this.radSlideView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radSlideView1.Name = "radSlideView1";
            // 
            // 
            // 
            this.radSlideView1.RootElement.UseDefaultDisabledPaint = false;
            this.radSlideView1.Size = new System.Drawing.Size(952, 507);
            this.radSlideView1.TabIndex = 0;
            this.radSlideView1.ThemeName = "ControlDefault";
            // 
            // radThemeManager1
            // 
            themeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource;
            themeSource1.ThemeLocation = "visualSt";
            this.radThemeManager1.LoadedThemes.AddRange(new Telerik.WinControls.ThemeSource[] {
            themeSource1});
            // 
            // AlgorithmFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 507);
            this.Controls.Add(this.radSlideView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlgorithmFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giới thiệu thuật toán";
            this.ThemeName = "VisualStudio2022Dark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlgorithmFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.radSlideView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSlideView radSlideView1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.RadThemeManager radThemeManager2;
    }
}
