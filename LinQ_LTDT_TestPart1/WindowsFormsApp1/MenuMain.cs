using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApp1.QuanLy_Ambulance;
using WindowsFormsApp1.QuanLyData;
namespace WindowsFormsApp1
{
    /*
     MENU của đề tài !!!!
     */
    public partial class MenuMain : Telerik.WinControls.UI.RadForm
    {
        public static string AlgrType = "Dijkstra";
        public static string infor = "";
        public static FrmListView frmlist;
        public static FrmAmbu Ambu;
        public MenuMain()
        {

            InitializeComponent();
            string f = Path.Combine(Application.StartupPath, "logo-bo-y-te.ico");
            this.Icon = new Icon(f);
            this.FormElement.Border.ForeColor = Color.White;
            NgayVaGio.Start(); //bắt đầu bộ đếm ngày tháng năm giờ
            //gán giá trị cho các Menubutton và event cho nó
            radMenuButtonItem10.Text = "Sơ bộ về Dijkstra và A*";
            radMenuButtonItem11.Text = "Minh họa thuật toán";
            radMenuButtonItem10.Click += DisplayFrmIntroduce;
            radMenuButtonItem11.Click += DisplayFrmAlgorithm;

        }
        //cập nhật ngày và giờ liên tục
        private void NgayVaGio_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string Dtime = dateTime.ToString("dd/MM/yyyy HH:mm:ss");
            Font lblFont = new Font("Segoe UI", 11, FontStyle.Bold);
            radLabelElement1.Font = lblFont;
            radLabelElement1.Text = Dtime;
        }
        //sự kiện để gọi form ALgorithm
        private void DisplayFrmIntroduce(object sender, EventArgs e)
        {
            this.Hide();
            AlgorithmFrm frm = new AlgorithmFrm();
            frm.ShowDialog();
        }
        //sự kiện để gọi form minh họa thuật toán
        private void DisplayFrmAlgorithm(object sender, EventArgs args)
        {
            this.Hide();
            AStarAndDijktraFrm frm = new AStarAndDijktraFrm();
            frm.ShowDialog();
        }
        //Sự kiện gọi form115 cho button
        private void Btb115_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
        //điều chỉnh size các button
        private void MenuMain_Load(object sender, EventArgs e)
        {
            Ambu = new FrmAmbu();
            Ambu.TopLevel = false;
            Ambu.FormBorderStyle = FormBorderStyle.None;
            Ambu.Dock = DockStyle.Fill; 
            pnlFrm.Controls.Add(Ambu); // Thêm Form Ambu vào panel
            Ambu.Show();
            frmlist = new FrmListView();
            frmlist.Show();
            this.BringToFront();
        }
        //gọi frm Introduce ( slide ppt giới thiệu đề tài nhóm)
        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {   
            IntroduceForm frm = new IntroduceForm();
            frm.ShowDialog();
        }
        //sự kiện gọi FrmHostohos
        private void btbChuyenTuyen_Click(object sender, EventArgs e)
        {
            FrmHostoHos frm = new FrmHostoHos(Form1.GetHospitalNames());
            frm.ShowDialog();
        }
        //khi ng dùng chọn dijkstra ( mặc định ) thì AlgrType = Dijkstra
        private void ButtonDijkstraSelec(object sender, EventArgs e)
        {
            AlgrType = "Dijkstra";
            lblAlgorNoti.Text = "Thuật toán đang được sử dụng : Dijkstra";
            MessageBox.Show("Bạn đã chọn thuật toán Dijkstra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
           //khi ng dùng chọn dijkstra ( mặc định ) thì AlgrType = Astar
        private void ButtonAstarsSelec(object sender, EventArgs e)
        {
            AlgrType = "A*";
            lblAlgorNoti.Text = "Thuật toán đang được sử dụng : A*";
            MessageBox.Show("Bạn đã chọn thuật toán A*", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmQuanly_click(object sender, EventArgs e)
        {
            string user = infor;
            DataClasses1DataContext db = new DataClasses1DataContext();
            NguoiDung nd = db.NguoiDungs.SingleOrDefault(p => p.UserName == user);
            if(nd.LevelID == 0)
            {
                MessageBox.Show("Bạn không phải Admin!", "Thông báo", MessageBoxButtons.OK);
            }
            else if(nd.LevelID == 1)
            {
                MessageBox.Show("Xin chào Admin!", "Thông báo", MessageBoxButtons.OK);
                FrmQuanLy frm = new FrmQuanLy();
                frm.Show();
                this.Hide();
            }
        }
    }
}
