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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class FrmStart : Telerik.WinControls.UI.RadForm
    {
        public FrmStart()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            DataTable dt = new DataTable();
            this.WindowState = FormWindowState.Maximized;
            dt.Columns.Add("Photo", typeof(Image));
            string imagePath = ".\\Huongdansudung";
            string[] imageFiles = Directory.GetFiles(imagePath, "*.png");
            Array.Sort(imageFiles, (a, b) =>
            {
                // Tách số từ tên file
                int numberA = int.Parse(Regex.Match(a, @"\d+").Value);
                int numberB = int.Parse(Regex.Match(b, @"\d+").Value);
                return numberA.CompareTo(numberB);
            });

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
        private void ClosingFrm(Object sender, FormClosingEventArgs e)
        {
            MenuMain.mn.WindowState = FormWindowState.Maximized;
            MenuMain.mn.BringToFront();

        }
    }
}
