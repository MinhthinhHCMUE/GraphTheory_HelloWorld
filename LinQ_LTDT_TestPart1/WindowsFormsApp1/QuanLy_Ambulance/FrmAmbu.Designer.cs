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
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // timercheck
            // 
            this.timercheck.Tick += new System.EventHandler(this.timercheck_Tick);
            // 
            // RGVAmbu
            // 
            this.RGVAmbu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGVAmbu.Location = new System.Drawing.Point(0, 0);
            this.RGVAmbu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // 
            // 
            this.RGVAmbu.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.RGVAmbu.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.RGVAmbu.Name = "RGVAmbu";
            this.RGVAmbu.Size = new System.Drawing.Size(1562, 762);
            this.RGVAmbu.TabIndex = 0;
            // 
            // FrmAmbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1562, 762);
            this.Controls.Add(this.RGVAmbu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAmbu";
            this.Text = "FrmAmbu";
            this.Load += new System.EventHandler(this.FrmAmbu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGVAmbu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timercheck;
        private Telerik.WinControls.UI.RadGridView RGVAmbu;
    }
}
