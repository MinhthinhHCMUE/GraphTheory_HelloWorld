using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApp1.Login_Signin;

namespace WindowsFormsApp1
{
    public partial class FrmSign : Telerik.WinControls.UI.RadForm
    {
        int Type = 3; // đăng ký
        public FrmSign()
        {
                InitializeComponent();
            string ico = System.IO.Path.Combine(Application.StartupPath, "loginico.ico");
            this.Icon = new Icon(ico);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }
        void Clear()
        {
            txtTaiKhoan.Text = "";
            txtEmail.Text = "";
            txtMatKhau.Text = "";
            txtXacnhan.Text = "";
            txtTaiKhoan.Focus();
        }
        private void btbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btbDangKy_Click(object sender, EventArgs e)
        {
            //check xem có đầy đủ information ko 
            if (txtEmail.Text == "" || txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtXacnhan.Text == "")
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin", "Thông báo");
                return;
            }
            if (txtMatKhau.Text != txtXacnhan.Text)
            {
                MessageBox.Show("Vui lòng điền chính xác mật khẩu", "Thông báo");
                txtMatKhau.Focus();
                return;
            }
            //tạo mã otp
            string taikhoan = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string email = txtEmail.Text;
            Random rd = new Random();
            string otp = rd.Next(1000, 9999).ToString();
            //mã hóa mật khẩu
            MD5 md = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(matkhau+otp);
            byte[] hashBytes = md.ComputeHash(inputBytes);
            //tạo và thêm dữ liệu vào database
            NguoiDung nd = new NguoiDung();
            nd.UserName = taikhoan;
            nd.Password = hashBytes; //pass đã đc mã hóa dưới dạng MD5
            nd.Email = email;
            nd.OTP = otp;
            nd.RandomKey = otp;
            nd.DateCreate = DateTime.Now;
            nd.OTPDateSend = DateTime.Now;
            nd.DateActive = null;
            nd.LevelID = 0; // là user mặc định.
            nd.Active = false;
            DatabaseQuanLy.Instance.NguoiDungs.InsertOnSubmit(nd);
            DatabaseQuanLy.Instance.SubmitChanges();
            MessageBox.Show("Tạo tài khoản thành công!", "Thông báo");
            //gửi email xác thực
            SendMail.sendMailTo(nd.Email, "Mã OTP xác thực là: " + nd.OTP);
            nd.OTPDateSend = DateTime.Now;
            DatabaseQuanLy.Instance.SubmitChanges();
            Frmxacthuc frm = new Frmxacthuc(nd.UserName,this.Type);
            frm.Show();
            this.Close();

        }

        private void FrmSign_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
            txtXacnhan.PasswordChar = '*';
        }

        private void CheckboxHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxHienThi.Checked) 
            {
                txtMatKhau.PasswordChar = '\0';
                txtXacnhan.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtXacnhan.PasswordChar = '*';
            }
        }
    }
}
