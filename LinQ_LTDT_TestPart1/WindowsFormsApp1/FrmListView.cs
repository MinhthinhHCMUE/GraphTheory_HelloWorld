using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace WindowsFormsApp1
{
    public partial class FrmListView : Telerik.WinControls.UI.RadForm
    {
        /*
        Một Instance duy nhất của FrmListView đc tạo ở FrmLogin và quản lý toàn bộ FormView phát sinh trong hệ thống

         */
        public FrmListView()
        {
            InitializeComponent();
        }
        /// <summary>.
        /// <para>
        /// Hàm này được dùng để tạo 1 page mới để nhúng FormView vào
        /// </para>
        /// </summary>
        public static void AddFormView(FormView formView)
        {
                string fromViewTag = formView.Tag.ToString();
            Ambulance amb = DatabaseQuanLy.Instance.Ambulances.Where(p => p.AmbulanceId.ToString() == fromViewTag).FirstOrDefault();
            if (amb == null)
            {
                MessageBox.Show("FrmListView ko thêm đượcc trang với Tag mới", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string PageName = amb.AmbulanceName;
                TabPage tab = new TabPage(PageName);
            tab.Tag = fromViewTag;
            // Sử dụng biến static frmListView từ FrmLogin
            MenuMain.frmlist.Tabcon1.TabPages.Add(tab); // Thêm TabPage vào TabControl

            // Thêm formView vào TabPage
            tab.Controls.Add(formView);

            // Thiết lập các thuộc tính cho formView
            formView.TopLevel = false;
            formView.FormBorderStyle = FormBorderStyle.None;
            formView.Dock = DockStyle.Fill;

            // Hiển thị formView
            formView.Show();
        }
        public static void FreePage(FormView frmView)
        {
            string fromViewTag = frmView.Tag.ToString();
          
            TabPage tabPageToDelete = MenuMain.frmlist.Tabcon1.TabPages.Cast< TabPage>().FirstOrDefault(p => p.Tag.ToString() == fromViewTag); // Hoặc lấy TabPage từ index
            MenuMain.frmlist.Tabcon1.TabPages.Remove(tabPageToDelete);   
                
        }
        public static void AddForm115(FormView formView, Form1 frm115)
        {
            string fromViewTag = formView.Tag.ToString();
            Ambulance amb = DatabaseQuanLy.Instance.Ambulances.Where(p => p.AmbulanceId.ToString() == fromViewTag).FirstOrDefault();
            if (amb == null)
            {
                MessageBox.Show("FrmListView ko thêm đượcc trang với Tag mới", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string PageName = amb.AmbulanceName;
            TabPage tab = MenuMain.frmlist.Tabcon1.TabPages.Cast<TabPage>()
                                                          .FirstOrDefault(t => t.Text == PageName);
            if (tab != null && tab.Text == PageName)
            {
               

                frm115.EnableDiseaseSelection();
                frm115.Show();
                frm115.BringToFront();
                //tab.Controls.Add(frm115);
            }
        }
    }
}
