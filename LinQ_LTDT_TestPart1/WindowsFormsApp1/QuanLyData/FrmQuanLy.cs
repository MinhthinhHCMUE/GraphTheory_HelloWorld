using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace WindowsFormsApp1.QuanLyData
{
    public partial class FrmQuanLy : Telerik.WinControls.UI.RadForm
    {
        public FrmQuanLy()
        {
            InitializeComponent();
        }
        private void btnAmbulance_Click(object sender, EventArgs e)
        {
            loadDuLieuAmbulance();
            RGVAmbu.ReadOnly = true;
        }
        private void btbHospital_Click(object sender, EventArgs e)
        {
            loadDuLieuHospital();
            RGVHospital.ReadOnly = true;
        }
        private void btbPatient_Click(object sender, EventArgs e)
        {
            loadDuLieuPatient();
            RGVPatient.ReadOnly = true;
        }
        private void btbUser_Click(object sender, EventArgs e)
        {
            loadDuLieuNguoiDung();
            RGVUser.ReadOnly = true;
        }
        private void btnAmbulanceEdit_Click(object sender, EventArgs e)
        {
            loadDuLieuAmbulance();
            RGVAmbu.ReadOnly = false;
        }
        private void btbHospitalEdit_Click(object sender, EventArgs e)
        {
            loadDuLieuHospital();
            RGVHospital.ReadOnly=false;
        }
        private void btbPatientEdit_Click(object sender, EventArgs e)
        {
            loadDuLieuPatient();
            RGVPatient.ReadOnly=false;
        }
        private void btbUserEdit_Click(object sender, EventArgs e)
        {
            loadDuLieuNguoiDung();
            RGVUser.ReadOnly=false;
        }
        private void loadDuLieuHospital()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                RGVHospital.DataSource = db.Hospitals.OrderBy(p => p.HospitalID); // Giả sử Hospital có cột HospitalID
                if (db.Hospitals.Any())
                    hienThiDuLieuHospital(0);
            }
        }
        private void loadDuLieuAmbulance()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                RGVAmbu.DataSource = db.Ambulances.OrderBy(p => p.AmbulanceId); // Giả sử Ambulance có cột AmbulanceID
                if (db.Ambulances.Any())
                    hienThiDuLieuAmbulance(0);
            }
        }
        private void loadDuLieuNguoiDung()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                RGVUser.DataSource = db.NguoiDungs.OrderBy(p => p.ID.ToString()); // Giả sử NguoiDung có cột UserID
                if (db.NguoiDungs.Any())
                    hienThiDuLieuNguoiDung(0);
            }
        }

        private void loadDuLieuPatient()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                RGVPatient.DataSource = db.Patients.OrderBy(p => p.PatientId.ToString()); // Giả sử Patient có cột PatientID
                if (db.Patients.Any())
                    hienThiDuLieuPatient(0);
            }
        }
        private void hienThiDuLieuAmbulance(int idrow)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                string ambulanceID = RGVAmbu.Rows[idrow].Cells[0].Value.ToString(); // Chuyển sang string
                Ambulance ambulance = db.Ambulances.SingleOrDefault(p => p.AmbulanceId == ambulanceID.ToString());

            }
        }

             private void hienThiDuLieuHospital(int idrow)
         {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                string HospitalId = RGVHospital.Rows[idrow].Cells[0].Value.ToString(); // Chuyển sang string
                Hospital Hospital = db.Hospitals.SingleOrDefault(p => p.HospitalID.ToString() == HospitalId.ToString());

            }
        }
        private void hienThiDuLieuNguoiDung(int idrow)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                string UserID = RGVUser.Rows[idrow].Cells[0].Value.ToString(); // Chuyển sang string
                NguoiDung nd = db.NguoiDungs.SingleOrDefault(p => p.ID.ToString() == UserID);

            }
        }
        private void hienThiDuLieuPatient(int idrow)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                string PatientId = RGVPatient.Rows[idrow].Cells[0].Value.ToString(); // Chuyển sang string
                Patient pt = db.Patients.SingleOrDefault(p => p.PatientId.ToString() == PatientId);

            }
        }
        private void RadNavigationChanged(Object sender , EventArgs e)
        {
            if (radPageViewPage1.IsContentVisible)
            {
                loadDuLieuAmbulance();
            }
            else if (radPageViewPage2.IsContentVisible) 
            { 
                loadDuLieuHospital();
            }
        }
        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            foreach (GridViewColumn col in RGVAmbu.MasterTemplate.Columns)
                col.TextAlignment = ContentAlignment.MiddleCenter;
               
        }
    }
}
