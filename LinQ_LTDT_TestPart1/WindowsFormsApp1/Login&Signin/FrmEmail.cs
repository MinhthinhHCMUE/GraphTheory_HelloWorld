using Org.BouncyCastle.Crypto.Agreement.JPake;
using ServiceStack;
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
using WindowsFormsApp1.Login_Signin;

namespace WindowsFormsApp1
{
    public partial class FrmEmail : Telerik.WinControls.UI.RadForm
    {
        int Type = 0; // mặc định là quên mật khẩu
        public FrmEmail()
        {
            InitializeComponent();
        }
        public FrmEmail(int a) // tính năng quên mật khẩu / xác thực
        {
            this.Type = a;
            this.ActiveControl = null;
            string ico = Path.Combine(Application.StartupPath, "loginico.ico");
            this.Icon = new Icon(ico);
            InitializeComponent();
            if (a == 0) 
            {
                txtEmail.Enter += (txtsender, esen) =>
                {
                    if (txtEmail.Text == "Hãy nhập email để lấy lại mật khẩu")
                    {
                        txtEmail.Text = "";
                        txtEmail.ForeColor = System.Drawing.Color.Black;
                    }
                };

                // Sự kiện khi TextBox mất focus ( nếu ng dùng ko chịu nhập )
                txtEmail.Leave += (txten, txte) =>
                {
                    if (string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        txtEmail.Text = "Hãy nhập email để lấy lại mật khẩu";
                        txtEmail.ForeColor = System.Drawing.Color.Gray;
                    }
                };
            }
            if (a == 1) 
            {
                txtEmail.Enter += (txtsender, esen) =>
                {
                    if (txtEmail.Text == "Hãy nhập email để xác thực tài khoản")
                    {
                        txtEmail.Text = "";
                        txtEmail.ForeColor = System.Drawing.Color.Black;
                    }
                };

                // Sự kiện khi TextBox mất focus ( nếu ng dùng ko chịu nhập )
                txtEmail.Leave += (txten, txte) =>
                {
                    if (string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        txtEmail.Text = "Hãy nhập email để xác thực tài khoản";
                        txtEmail.ForeColor = System.Drawing.Color.Gray;
                    }
                };
            }
        }
        private void btbGo_Click(object sender, EventArgs e)
        {
            string mail = txtEmail.Text;
            if (mail.IsEmpty()) 
            {
                MessageBox.Show("Vui lòng điền email", "Thông báo", MessageBoxButtons.OK);
                txtEmail.Focus();
            }
            else
            {
                NguoiDung nd  = DatabaseQuanLy.Instance.NguoiDungs.FirstOrDefault(p=> p.Email == txtEmail.Text);
                if(nd == null)
                {
                    MessageBox.Show($"Không có tài khoản nào khớp với Email : {mail}", "Thông báo", MessageBoxButtons.OK);
                    txtEmail.Focus();
                }
                if(nd !=null && nd.Active == true && this.Type !=0 )
                {
                    MessageBox.Show($"Tài khoản : {nd.UserName} với Email : {nd.Email} đã được xác thực rồi!", "Thông báo", MessageBoxButtons.OK);
                    FrmLogin frm = new FrmLogin();
                    frm.Show();
                    this.Close();
                }
                if (nd!=null && this.Type == 0)
                {
                    Random rd = new Random();
                    string otp = rd.Next(1000, 9999).ToString();
                    nd.OTP = otp;
                    nd.OTP = otp;
                    nd.RandomKey = otp;
                    nd.DateCreate = DateTime.Now;
                    nd.OTPDateSend = DateTime.Now;
                    SendMail.sendMailTo(nd.Email, "Mã OTP xác thực là: " + nd.OTP);
                    nd.OTPDateSend = DateTime.Now;
                    DatabaseQuanLy.Instance.SubmitChanges();
                    Frmxacthuc frm = new Frmxacthuc(nd.UserName, this.Type);
                    this.Close();
                    frm.ShowDialog();
                }
            }
        }

        private void btbBack_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
