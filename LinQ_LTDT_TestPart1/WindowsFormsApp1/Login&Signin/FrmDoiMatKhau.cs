using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using static System.Net.WebRequestMethods;
using WindowsFormsApp1.Login_Signin;
using System.Security.Cryptography;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FrmDoiMatKhau : Telerik.WinControls.UI.RadForm
    {
        private NguoiDung nd;
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        public FrmDoiMatKhau(NguoiDung nd)
        {
            string ico = Path.Combine(Application.StartupPath, "loginico.ico");
            this.Icon = new Icon(ico);
            InitializeComponent();
            txtPass.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
            this.nd = nd;
        }
        private void btbChange_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.IsEmpty() || txtConfirm.Text.IsEmpty()) 
            {
                MessageBox.Show("Vui lòng điền thông tin", "Thông báo", MessageBoxButtons.OK);
                txtPass.Focus();
            }
            if (txtPass.Text != txtPass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                txtPass.Focus();
            }
            if (txtPass.Text == txtPass.Text) 
            {
                MD5 md = MD5.Create();
                string matkhau = txtPass.Text;
                byte[] inputBytes = Encoding.ASCII.GetBytes(matkhau + this.nd.OTP );
                byte[] hashBytes = md.ComputeHash(inputBytes);
                //tạo và thêm dữ liệu vào database
                nd.Password = hashBytes; //pass đã đc mã hóa dưới dạng MD5
                DatabaseQuanLy.Instance.SubmitChanges();
                MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo");
                DatabaseQuanLy.Instance.SubmitChanges();
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close();
               
            }
        }

        private void cboxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShow.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtConfirm.PasswordChar = '\0';

            }
            else if(!cboxShow.Checked)
            {
                txtPass.PasswordChar = '*';
                txtConfirm.PasswordChar = '*';
            }
        }
    }
}
