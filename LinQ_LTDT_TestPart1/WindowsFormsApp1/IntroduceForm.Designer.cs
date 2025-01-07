namespace WindowsFormsApp1
{
    partial class IntroduceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroduceForm));
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radSlideView1 = new Telerik.WinControls.UI.RadSlideView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.radSlideView1.Size = new System.Drawing.Size(1639, 711);
            this.radSlideView1.TabIndex = 0;
            // 
            // IntroduceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1639, 711);
            this.Controls.Add(this.radSlideView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "IntroduceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giới thiệu đề tài";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSlideView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Telerik.WinControls.UI.RadSlideView radSlideView1;
    }
}
