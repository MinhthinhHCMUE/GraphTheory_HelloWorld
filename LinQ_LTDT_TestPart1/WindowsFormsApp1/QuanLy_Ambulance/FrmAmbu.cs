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
        /// <summary>
        /// Load dữ liệu Ambu
        /// </summary>
        private void loadDuLieuAmbulance()
        {
            bindingSource.DataSource = DatabaseQuanLy.Instance.AmbulanceMissions.OrderBy(p => p.AmbulanceId).ToList();

            if (DatabaseQuanLy.Instance.AmbulanceMissions.Any())
                hienThiDuLieuAmbulance(0);
        }
        /// <summary>
        /// Hiển thị dữ liệu Ambu
        /// </summary>
        /// <param name="idrow">Dòng cần đc hiển thị ( nên là 0 )</param>

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

        /// <summary>
        /// Cập nhật lại DataGridView với database mới
        /// </summary>
        public void RefreshDataGridView()
        {
            bindingSource.DataSource = null;
            bindingSource.ResetBindings(false); //reset bidings
            bindingSource.DataSource = DatabaseQuanLy.Instance.AmbulanceMissions.OrderBy(p => p.AmbulanceId).ToList();
        }
   
        /// <summary>
        /// Reset lại lable sau khi mô phỏng đợt 2 kết thúc
        /// </summary>
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
        /// <summary>
        /// Cập nhật lable khi mô phỏng đợt 1 kết thúc
        /// </summary>
        public void UpdateLabel()
        {
            lblNotication.Text = "Có xe cứu thương cần được giải quyết! Tính năng khẩn cấp sẽ được bắt đầu sau 10 giây nếu không có phản hồi!";
            Font f = new Font("Segoe UI", 12, FontStyle.Bold);
            lblNotication.Font = f;
            lblNotication.ForeColor = Color.Red;
        }
        /// <summary>
        /// Thêm Xe cứu thương vào trong combo box sau khi mô phỏng đợt 1 kết thúc
        /// </summary>
        /// <param name="id">ID của xe cứu thương</param>
        /// <exception cref="Exception">Không tìm thấy xe</exception>
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
        /// <summary>
        /// Xóa xe cứu thương khỏi combo box
        /// </summary>
        /// <param name="id">Id của xe cứu thương</param>
        /// <exception cref="Exception">Không tìm thấy xe cứu thương để xóa</exception>
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
        private  void btbClick(object sender, EventArgs e)
        {
            MenuMain.MiniMize();
            MenuMain.frmlist.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuMain.MiniMize();
            MenuMain.frmlist.WindowState = FormWindowState.Maximized;
        }
    }
}
