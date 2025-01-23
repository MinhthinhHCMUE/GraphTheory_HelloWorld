using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.IO;
using Telerik.WinControls.UI.SlideView;
using System.Linq;
namespace WindowsFormsApp1
{
    public partial class IntroduceForm : RadForm
    {
        /*
         Nhúng Slide PPT vào trong Form sử dụng telerik
         logic tương tự như Algorithm.Frm
         */
        public IntroduceForm()
        {
            InitializeComponent();
            string f = Path.Combine(Application.StartupPath, "HCMUEicon.ico");
            this.Icon = new Icon(f); 
            this.WindowState = FormWindowState.Maximized;
            BindingSource bs = new BindingSource();
            DataTable dt = new DataTable();
            dt.Columns.Add("Photo", typeof(Image));
            string imagePath = ".\\My Pictures";
            string[] imageFiles = Directory.GetFiles(imagePath, "*.png");
            foreach (string imageFile in imageFiles)
            {
                Image image = Image.FromFile(imageFile);
                dt.Rows.Add(image);
            }
            bs.DataSource = dt;
            LightVisualElement basicTemplate = new LightVisualElement();
            basicTemplate.ForeColor = Color.Black; // Hoặc Color.Blue, ...

            basicTemplate.Opacity = 1;
            basicTemplate.ImageLayout = ImageLayout.Zoom;
            this.radSlideView1.Mappings.Add(new Mapping(basicTemplate, LightVisualElement.ImageProperty, dt.Columns[0].ColumnName));
            this.radSlideView1.TemplateElement = basicTemplate;
            this.radSlideView1.BindingSource = bs;

        }
        void radRotator1_BeginRotate(object sender, BeginRotateEventArgs e)
        {
        }

        private void radImageItem1_Click(object sender, EventArgs e)
        {

        }
    }
}