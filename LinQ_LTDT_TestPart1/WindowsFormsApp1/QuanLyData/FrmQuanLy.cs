using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.FormElement.Border.ForeColor = Color.White;
            this.WindowState = FormWindowState.Maximized;
            string ico = Path.Combine(Application.StartupPath, "HCMUEicon.ico");
            this.Icon = new Icon(ico);
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
            RGVHospital.DataSource = DatabaseQuanLy.Instance.Hospitals.OrderBy(p => p.HospitalID);
            if (DatabaseQuanLy.Instance.Hospitals.Any())
                hienThiDuLieuHospital(0);
        }

        private void loadDuLieuAmbulance()
        {
            RGVAmbu.DataSource = DatabaseQuanLy.Instance.Ambulances.OrderBy(p => p.AmbulanceId);
            if (DatabaseQuanLy.Instance.Ambulances.Any())
                hienThiDuLieuAmbulance(0);
        }

        private void loadDuLieuNguoiDung()
        {
            RGVUser.DataSource = DatabaseQuanLy.Instance.NguoiDungs.OrderBy(p => p.ID.ToString());
            if (DatabaseQuanLy.Instance.NguoiDungs.Any())
                hienThiDuLieuNguoiDung(0);
        }

        private void loadDuLieuPatient()
        {
            RGVPatient.DataSource = DatabaseQuanLy.Instance.Patients.OrderBy(p => p.PatientId.ToString());
            if (DatabaseQuanLy.Instance.Patients.Any())
                hienThiDuLieuPatient(0);
        }

        private void hienThiDuLieuAmbulance(int idrow)
        {
            string ambulanceID = RGVAmbu.Rows[idrow].Cells[0].Value.ToString();
            Ambulance ambulance = DatabaseQuanLy.Instance.Ambulances.SingleOrDefault(p => p.AmbulanceId == ambulanceID.ToString());
        }

        private void hienThiDuLieuHospital(int idrow)
        {
            string HospitalId = RGVHospital.Rows[idrow].Cells[0].Value.ToString();
            Hospital Hospital = DatabaseQuanLy.Instance.Hospitals.SingleOrDefault(p => p.HospitalID.ToString() == HospitalId.ToString());
        }

        private void hienThiDuLieuNguoiDung(int idrow)
        {
            string UserID = RGVUser.Rows[idrow].Cells[0].Value.ToString();
            NguoiDung nd = DatabaseQuanLy.Instance.NguoiDungs.SingleOrDefault(p => p.ID.ToString() == UserID);
        }
        private void hienThiDuLieuPatient(int idrow)
        {
            string PatientId = RGVPatient.Rows[idrow].Cells[0].Value.ToString();
            Patient pt = DatabaseQuanLy.Instance.Patients.SingleOrDefault(p => p.PatientId.ToString() == PatientId);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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
            foreach (GridViewColumn col in RGVHospital.MasterTemplate.Columns)
                col.TextAlignment = ContentAlignment.MiddleCenter;
            foreach (GridViewColumn col in RGVPatient.MasterTemplate.Columns)
                col.TextAlignment = ContentAlignment.MiddleCenter;
            foreach (GridViewColumn col in RGVUser.MasterTemplate.Columns)
                col.TextAlignment = ContentAlignment.MiddleCenter;
        }
    }
}
