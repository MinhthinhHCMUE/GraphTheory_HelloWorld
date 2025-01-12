using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace WindowsFormsApp1.QuanLyData
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
           
        }
        private void loadDuLieuAmbulance()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                dgvData.DataSource = db.Ambulances.OrderBy(p => p.AmbulanceId); // Giả sử Ambulance có cột AmbulanceID
                if (db.Ambulances.Any())
                    hienThiDuLieuAmbulance(0);
            }
        }
        private void btnAmbulance_Click(object sender, EventArgs e)
        {
            loadDuLieuAmbulance();
        }
        //private void loadDuLieuHospital()
        //{
        //    using (DataClasses1DataContext db = new DataClasses1DataContext())
        //    {
        //        dgvData.DataSource = db.Hospitals.OrderBy(p => p.HospitalID); // Giả sử Hospital có cột HospitalID
        //        if (db.Hospitals.Any())
        //            hienThiDuLieuHospital(0);
        //    }
        //}

        //private void loadDuLieuNguoiDung()
        //{
        //    using (DataClasses1DataContext db = new DataClasses1DataContext())
        //    {
        //        dgvData.DataSource = db.NguoiDungs.OrderBy(p => p.UserID); // Giả sử NguoiDung có cột UserID
        //        if (db.NguoiDungs.Any())
        //            hienThiDuLieuNguoiDung(0);
        //    }
        //}

        //private void loadDuLieuPatient()
        //{
        //    using (DataClasses1DataContext db = new DataClasses1DataContext())
        //    {
        //        dgvData.DataSource = db.Patients.OrderBy(p => p.PatientID); // Giả sử Patient có cột PatientID
        //        if (db.Patients.Any())
        //            hienThiDuLieuPatient(0);
        //    }
        //}
        private void hienThiDuLieuAmbulance(int idrow)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                string ambulanceID = dgvData.Rows[idrow].Cells[0].Value.ToString(); // Chuyển sang string
                Ambulance ambulance = db.Ambulances.SingleOrDefault(p => p.AmbulanceId == ambulanceID.ToString());
                
            }
        }
    }
}
