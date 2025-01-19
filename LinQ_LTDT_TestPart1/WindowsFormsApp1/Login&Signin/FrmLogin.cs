using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;  
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using System.Security.Cryptography;
using System.Data.Linq.Mapping;
namespace WindowsFormsApp1
{
    public partial class FrmLogin : Telerik.WinControls.UI.RadForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        

        private void btbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Focus();
        }
        private void btbLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string pass = txtPassword.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng điền thông tin!", "Thông báo", MessageBoxButtons.OK);
                Clear();
            }
            else
            {
                NguoiDung nd = DatabaseQuanLy.Instance.NguoiDungs.SingleOrDefault(p => p.UserName == user);
                if (nd != null)
                {
                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = Encoding.ASCII.GetBytes(pass + nd.RandomKey);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    if (nd.Password == hashBytes) {
                        if (nd.Active == true)
                        {
                            if (nd.LevelID == 1)
                            {
                                MessageBox.Show("Xin chào Admin!", "Thông báo", MessageBoxButtons.OK);
                                MenuMain.infor = nd.UserName;
                                MenuMain frm = new MenuMain();
                                frm.Show();
                                frm.BringToFront();
                                this.Hide();
                            }
                            if (nd.LevelID == 0)
                            {
                                MessageBox.Show("Xin chào " + nd.UserName + "!", "Thông báo", MessageBoxButtons.OK);
                                MenuMain.infor = nd.UserName;
                                MenuMain frm = new MenuMain();
                                frm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản chưa xác thực,vui lòng xác thực tài khoản", "Thông báo", MessageBoxButtons.OK);
                        }  
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập sai mật khẩu, Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai tài khoản hoặc chưa đăng ký!", "Thông báo", MessageBoxButtons.OK);
                    txtUserName.Focus();
                }
                
            }

        }
        private void lblResig_Click(object sender, EventArgs e)
        {
            new FrmSign().Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            checkboxShow.Location = new Point(182, 280);
          
        }

        private void checkboxShow_CheckedChanged(object sender, EventArgs e)
        {
            //dùng ký tự * để hiển thị cho mật khẩu
            if (checkboxShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
