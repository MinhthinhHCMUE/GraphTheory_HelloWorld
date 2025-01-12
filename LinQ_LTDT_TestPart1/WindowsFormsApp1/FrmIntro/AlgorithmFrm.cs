using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.SlideView;
using Telerik.WinControls.UI;
using System.Linq;

namespace WindowsFormsApp1
{
    /*
     Form Để hiển thị các slideppt Giới thiệu cho 2 thuật toán Dijkstra và A*
     Sử dụng SlideView của telerik. Bằng cách sử dụng 1 cái dataTable Import ảnh vào và trình chiếu
     */
    public partial class AlgorithmFrm : Telerik.WinControls.UI.RadForm
    {
        public AlgorithmFrm()
        {
   
            InitializeComponent();
            this.FormElement.Border.ForeColor = Color.White;
            this.WindowState = FormWindowState.Maximized;

            BindingSource bs = new BindingSource();
            DataTable dt = new DataTable();
            dt.Columns.Add("Photo", typeof(Image));
            string imagePath = ".\\FrmAlgorithm"; // lấy ảnh từ thư mục FrmAlgorithm
            string[] imageFiles = Directory.GetFiles(imagePath, "*.png"); //Duyệt qua tất cả ảnh có đuôi png
            foreach (string imageFile in imageFiles)
            {
                Image image = Image.FromFile(imageFile);
                dt.Rows.Add(image);
            }
            bs.DataSource = dt;
            LightVisualElement basicTemplate = new LightVisualElement();
            basicTemplate.ForeColor = Color.Black; // Hoặc Color.Blue, ...

            basicTemplate.Opacity = 1;
            basicTemplate.ImageLayout = ImageLayout.Stretch;

            this.radSlideView1.Mappings.Add(new Mapping(basicTemplate, LightVisualElement.ImageProperty, dt.Columns[0].ColumnName));
            this.radSlideView1.TemplateElement = basicTemplate; //chỉnh template cho đẹp :))
            this.radSlideView1.BindingSource = bs; // gán Source cho radSlideView

        }
        private void AlgorithmFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tìm MenuMain đang mở
            MenuMain frm = Application.OpenForms.OfType<MenuMain>().FirstOrDefault();
            if (frm != null)
            {
                frm.Show(); // Hiển thị Form1
                frm.BringToFront(); // Đưa Form1 lên trên cùng
            }
        }
    }
}
