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
        
        private void checkboxShow_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (checkboxShow.Checked) {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
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
                DataClasses1DataContext db = new DataClasses1DataContext();
                NguoiDung nd = db.NguoiDungs.SingleOrDefault(p => p.UserName == user);
                if (nd != null)
                {
                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = Encoding.ASCII.GetBytes(pass + nd.RandomKey);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    if (nd.Password == hashBytes) { 
                        if(nd.LevelID == 1)
                        {
                            MessageBox.Show("Xin chào Admin!", "Thông báo", MessageBoxButtons.OK);
                            MenuMain.infor = nd.UserName;
                        }
                        if(nd.LevelID == 0)
                        {
                            MessageBox.Show("Xin chào " + nd.UserName + "!", "Thông báo", MessageBoxButtons.OK);
                            MenuMain.infor = nd.UserName;
                        }
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Thông tin không tồn tại!", "Thông báo", MessageBoxButtons.OK);
                Clear();
            }

        }

        private void lblResig_Click(object sender, EventArgs e)
        {
            new FrmSign().Show();
            this.Hide();
        }
    }
}
