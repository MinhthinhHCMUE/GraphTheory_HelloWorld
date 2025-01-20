using Org.BouncyCastle.Tls.Crypto.Impl.BC;
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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static WindowsFormsApp1.Program;

namespace WindowsFormsApp1.QuanLy_Ambulance
{
    public partial class FrmAmbu : Telerik.WinControls.UI.RadForm
    {
        private BindingSource bindingSource = new BindingSource(); 
        public FrmAmbu()
        {
            InitializeComponent();
            timercheck.Start();
            RGVAmbu.DataSource = bindingSource;
        }
        private void loadDuLieuAmbulance()
        {
            bindingSource.DataSource = DatabaseQuanLy.Instance.AmbulanceMissions.OrderBy(p => p.AmbulanceId).ToList();

            if (DatabaseQuanLy.Instance.AmbulanceMissions.Any())
                hienThiDuLieuAmbulance(0);
        }
     
        private void hienThiDuLieuAmbulance(int idrow)
        {
            string AmbulanceMissId = RGVAmbu.Rows[idrow].Cells[0].Value.ToString();

            AmbulanceMission ambulance = DatabaseQuanLy.Instance.AmbulanceMissions.SingleOrDefault(p => p.AmbulanceId == AmbulanceMissId);
        }
        private void FrmAmbu_Load(object sender, EventArgs e)
        {
            loadDuLieuAmbulance();
            //RGVAmbu.Columns["AmbulanceId"].ReadOnly = true;
            //RGVAmbu.Columns["AmbulanceName"].ReadOnly = true;
            //RGVAmbu.Columns["MissionType"].ReadOnly = true;
            //RGVAmbu.Columns["View"].ReadOnly = false;
        }
        public void RefreshDataGridView()
        {
            bindingSource.DataSource = null;
            bindingSource.ResetBindings(false); //reset bidings
            bindingSource.DataSource = DatabaseQuanLy.Instance.AmbulanceMissions.OrderBy(p => p.AmbulanceId).ToList();
        }
        public void UpdateLabel()
        {
            lblNotication.Text = "Có xe cứu thương cần được giải quyết! Tính năng khẩn cấp sẽ được bắt đầu sau 10 giây nếu không có phản hồi!";
            Font f = new Font("Segoe UI", 12, FontStyle.Bold);
            lblNotication.Font = f;
            lblNotication.ForeColor = Color.Red;
        }
        public void ResetLabel()
        {
            if(cmbListAmbu.Items.Count == 0)
            {
                lblNotication.Text = "Đang chờ tín hiệu từ xe cứu thương!";
                Font f = new Font("Segoe UI", 12, FontStyle.Bold);
                lblNotication.Font = f;
                lblNotication.ForeColor = Color.Black;
                button1.Enabled = false;
            }
        }
        public void AddAmbuToCmbox(string id)
        {
            AmbulanceMission ambu = DatabaseQuanLy.Instance.AmbulanceMissions.SingleOrDefault(p => p.AmbulanceId == id);
            if(ambu == null)
            {
                throw new Exception("Sai sót ở AddAmbuTocmbox");
            }
            else
            {
                cmbListAmbu.Items.Add("                                           " + ambu.AmbulanceName);
                cmbListAmbu.SelectedIndex = 0;
                button1.Enabled = true;
            }
        }
        public void RemoveAmbuFormCmbox(string id)
        {
            AmbulanceMission ambu = DatabaseQuanLy.Instance.AmbulanceMissions.SingleOrDefault(p => p.AmbulanceId == id);
            if (ambu == null)
            {
                throw new Exception("Sai sót ở RemoveAmbuFormCmbox");
            }
            else
            {
                cmbListAmbu.Items.Remove("                                           " + ambu.AmbulanceName);
            }
        }
        private void timercheck_Tick(object sender, EventArgs e)
        {
            foreach (GridViewRowInfo row in RGVAmbu.Rows)
            {

                /*
                 Hiện tại đã đưa Formview vào page -> target to focus formview when user click on tickbox in radgridview
                 */
                // Kiểm tra xem ô "View" (bit) có được tick hay không
                //if (Convert.ToBoolean(row.Cells["View"].Value) == true)
                //{
                //    // Lấy AmbulanceId từ cột "AmbulanceId" của hàng
                //    string ambulanceId = row.Cells["AmbulanceId"].Value.ToString();

                //    // Tìm form tương ứng với AmbulanceId
                //    this.Invoke((MethodInvoker)delegate
                //    {
                //        foreach (Form form in Application.OpenForms)
                //        {
                //            Console.WriteLine(form.Name + " - Visible: " + form.Visible);
                //            if (form is FormView)
                //            {
                //                Console.WriteLine(form.Tag);
                //            }
                //            if (form is FormView formView && formView.Tag != null && formView.Tag.ToString() == ambulanceId)

                //            {
                //                // formView.BringToFront();
                //                //formView.Visible = true;
                //                break;
                //            }
                //        }
                //    });
            }
        }
        private  void btbClick(object sender, EventArgs e)
        {
            MenuMain.MiniMize();
            MenuMain.frmlist.WindowState = FormWindowState.Maximized;
        }
       
    }
}
