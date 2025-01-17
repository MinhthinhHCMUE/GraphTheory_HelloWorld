using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace WindowsFormsApp1.Login_Signin
{
    public partial class Frmxacthuc : Telerik.WinControls.UI.RadForm
    {
        string taikhoan;
        public Frmxacthuc()
        {
            InitializeComponent();
        }
        public Frmxacthuc(string _taikhoan)
        {
            InitializeComponent();
            taikhoan = _taikhoan;

        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            NguoiDung nd = db.NguoiDungs.SingleOrDefault(p=>p.UserName == taikhoan);
            if (nd != null)
            {
                if (nd.OTP.ToString() == txtOTP.Text) 
                {
                    DateTime otpdatesend = (DateTime)nd.OTPDateSend;
                    if ((DateTime.Now - otpdatesend).TotalMinutes <= 5) 
                    {
                        nd.DateActive = DateTime.Now;
                        nd.Active = true;
                        db.SubmitChanges();
                        MessageBox.Show("Đã kích hoạt thành công tài khoản", "Thông báo");
                        FrmLogin frm = new FrmLogin();
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mã OTP đã hết hiệu lực. Vui lòng nhập lại mã OTP mới", "Thông báo");
                        btnGuiLai_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Mã OTP không chính xác. Vui lòng nhập lại", "Thông báo");
                    return;
                }
            }
        }

        private void btnGuiLai_Click(object sender, EventArgs e)
        {
            //gửi email xác thực
            DataClasses1DataContext db = new DataClasses1DataContext();
            NguoiDung nd = db.NguoiDungs.SingleOrDefault(p => p.UserName == taikhoan);
            if (nd != null)
            {
                Random rd = new Random();
                nd.OTP = rd.Next(1000, 9999).ToString();// mã OTp trong 1000 -> 9999
                SendMail.sendMailTo(nd.Email, "Mã OTP xác thực là: " + nd.OTP);
                nd.OTPDateSend = DateTime.Now;  //Kiem soat thoi gian 5 phut hieu luc
                db.SubmitChanges();
                MessageBox.Show("Đã gửi email", "Thông báo");
            }
        }

        private void btbExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            lblTaiKhoan.Text = taikhoan.ToString();
        }
    }
}
