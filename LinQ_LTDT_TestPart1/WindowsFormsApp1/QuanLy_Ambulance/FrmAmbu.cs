using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace WindowsFormsApp1.QuanLy_Ambulance
{
    public partial class FrmAmbu : Telerik.WinControls.UI.RadForm
    {
        private DataClasses1DataContext db;
        private BindingSource bindingSource = new BindingSource(); 
        public FrmAmbu()
        {
            InitializeComponent();
            timercheck.Start();
            db = new DataClasses1DataContext();
            RGVAmbu.DataSource = bindingSource;
        }
        private void loadDuLieuAmbulance()
        {
            bindingSource.DataSource = db.AmbulanceMissions.OrderBy(p => p.AmbulanceId.ToString()).ToList(); // Gán dữ liệu cho BindingSource

            if (db.AmbulanceMissions.Any())
                hienThiDuLieuAmbulance(0);
        }
     
        private void hienThiDuLieuAmbulance(int idrow)
        {
            string AmbulanceMissId = RGVAmbu.Rows[idrow].Cells[0].Value.ToString();
          
            AmbulanceMission ambulance = db.AmbulanceMissions.SingleOrDefault(p => p.AmbulanceId == AmbulanceMissId.ToString());
        }
        private void FrmAmbu_Load(object sender, EventArgs e)
        {

            loadDuLieuAmbulance();
            //foreach (DataGridViewColumn column in this.RGVAmbu.Columns)
            //{
            //    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //}
            RGVAmbu.Columns["AmbulanceId"].ReadOnly = true;
            RGVAmbu.Columns["AmbulanceName"].ReadOnly = true;
            RGVAmbu.Columns["MissionType"].ReadOnly = true;
            RGVAmbu.Columns["View"].ReadOnly = false;
        }
        public void RefreshDataGridView()
        {
            bindingSource.DataSource = null;
            loadDuLieuAmbulance(); 
            RGVAmbu.Refresh(); // Refresh DataGridView
        }

        private void timercheck_Tick(object sender, EventArgs e)
        {
            foreach (GridViewRowInfo row in RGVAmbu.Rows)
            {
          
          
            // Kiểm tra xem ô "View" (bit) có được tick hay không
                if (Convert.ToBoolean(row.Cells["View"].Value) == true)
                {
                    // Lấy AmbulanceId từ cột "AmbulanceId" của hàng
                    string ambulanceId = row.Cells["AmbulanceId"].Value.ToString();

                    // Tìm form tương ứng với AmbulanceId
                    foreach (Form form in Application.OpenForms)
                    {
                        Console.WriteLine(form.Name + " - Visible: " + form.Visible);

                        if (form is FormView formView && formView.Tag != null && formView.Tag.ToString() == ambulanceId)
                        {
                            formView.BringToFront();
                            formView.Visible = true ;

                            // Bỏ chọn "View" sau khi đã hiển thị form
                            row.Cells["View"].Value = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}
