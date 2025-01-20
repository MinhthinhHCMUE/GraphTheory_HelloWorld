using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
            string ico = System.IO.Path.Combine(Application.StartupPath, "adminico.ico");
            this.Icon = new Icon(ico);

        }
        private void btnAmbulance_Click(object sender, EventArgs e)
        {
            RGVAmbu.ReadOnly = true;
        }
        private void btbHospital_Click(object sender, EventArgs e)
        {
            RGVHospital.ReadOnly = true;
        }
        private void btbPatient_Click(object sender, EventArgs e)
        {
            RGVPatient.ReadOnly = true;
        }
        private void btbUser_Click(object sender, EventArgs e)
        {
            RGVUser.ReadOnly = true;
        }
        private void btnAmbulanceEdit_Click(object sender, EventArgs e)
        {
            RGVAmbu.ReadOnly = false;
        }
        private void btbHospitalEdit_Click(object sender, EventArgs e)
        {
            RGVHospital.ReadOnly=false;
        }
        private void btbPatientEdit_Click(object sender, EventArgs e)
        {
            RGVPatient.ReadOnly=false;
        }
        private void btbUserEdit_Click(object sender, EventArgs e)
        {
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
        private void SearchIDPatient(object sender , EventArgs e) 
        {
            string id = txtIDPatient.Text;
            if (id.IsEmpty())
            {
                loadDuLieuPatient();            
                this.RGVPatient.ReadOnly = true;
            }
            else 
            {
                Patient pt = DatabaseQuanLy.Instance.Patients.FirstOrDefault(p => p.PatientId.ToString() == id);
                if (pt == null)
                {
                    MessageBox.Show($"Không tìm thấy bệnh nhân với ID : {id}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RGVPatient.DataSource = DatabaseQuanLy.Instance.Patients.Where(p => p.PatientId.ToString() == id);
                    RGVPatient.Columns["Hospital"].IsVisible = false;
                }
            }
        }
        private void SearchIDAmbu(object sender, EventArgs e) 
        {
            string id = txtIDAmbu.Text;
            if (id.IsEmpty())
            {
                loadDuLieuAmbulance();
                this.RGVAmbu.ReadOnly = true;
            }
            else 
            {
                Ambulance ambu = DatabaseQuanLy.Instance.Ambulances.FirstOrDefault(p => p.AmbulanceId.ToString() == id);
                if (ambu == null)
                {
                    MessageBox.Show($"Không tìm thấy xe cứu thương với ID : {id}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RGVAmbu.DataSource = DatabaseQuanLy.Instance.Ambulances.Where(p => p.AmbulanceId.ToString() == id);
                    RGVAmbu.Columns["Hospital"].IsVisible = false;
                }
            }
        }
        private void SearchIDHospital(object sender, EventArgs e) 
        {
            string id = txtIDHos.Text;
            if (id.IsEmpty())
            {
                loadDuLieuHospital();
                this.RGVHospital.ReadOnly = true;
            }
            else 
            {
                Hospital hos = DatabaseQuanLy.Instance.Hospitals.FirstOrDefault(p => p.HospitalID.ToString() == id);
                if (hos == null)
                {
                    MessageBox.Show($"Không tìm thấy bệnh viện với ID : {id}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RGVHospital.DataSource = DatabaseQuanLy.Instance.Hospitals.Where(p => p.HospitalID.ToString() == id);
                    RGVHospital.Columns["Patients"].IsVisible = false;
                    RGVHospital.Columns["Ambulances"].IsVisible = false;
                }
            }
        }
        private void SearchIDUser(object sender, EventArgs e) 
        {
            string id = txtIDUser.Text;
            if (id.IsEmpty())
            {
                loadDuLieuNguoiDung();
                this.RGVUser.ReadOnly = true;
            }
            else 
            {
                NguoiDung nd = DatabaseQuanLy.Instance.NguoiDungs.FirstOrDefault(p => p.ID.ToString() == id);
                if (nd == null)
                {
                    MessageBox.Show($"Không tìm thấy người dùng với ID : {id}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RGVUser.DataSource = DatabaseQuanLy.Instance.NguoiDungs.Where(p => p.ID.ToString() == id);
                }
            }
            
        }
        private void  ClosingFrm(Object sender, FormClosedEventArgs e)
        {
            DatabaseQuanLy.Instance.SubmitChanges();
            MenuMain.mn.WindowState = FormWindowState.Maximized;
            MenuMain.mn.BringToFront();
            this.Dispose();
        }
        private void LoadLaiDataAmbu()
        {
            loadDuLieuAmbulance();
            this.RGVAmbu.ReadOnly = true;
            RGVAmbu.Columns["Hospital"].IsVisible = false;
        }
        private void LoadLaiDataNguoiDung()
        {
            loadDuLieuNguoiDung();
            this.RGVUser.ReadOnly = true;
        }
        private void LoadLaiDataHospital()
        {
            loadDuLieuHospital();
            this.RGVHospital.ReadOnly = true;
            RGVHospital.Columns["Patients"].IsVisible = false;
            RGVHospital.Columns["Ambulances"].IsVisible = false;
        }
        private void LoadLaiDataPatient()
        {
            loadDuLieuPatient();
            this.RGVPatient.ReadOnly = true;
            RGVPatient.Columns["Hospital"].IsVisible = false;
        }
        private void Submit(object sender , GridViewCellEventArgs e)
        {
            DatabaseQuanLy.Instance.SubmitChanges();
        }
        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            LoadLaiDataAmbu();
            LoadLaiDataHospital();
            LoadLaiDataNguoiDung();
            LoadLaiDataPatient();
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
