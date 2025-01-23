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

namespace WindowsFormsApp1
{
    public partial class AStarAndDijktraFrm : Telerik.WinControls.UI.RadForm
    {
        public AStarAndDijktraFrm()
        {
            InitializeComponent();
            string f = Path.Combine(".\\VideoAlgor" , "VideoAlgor.mp4");
                axWindowsMediaPlayer1.URL = f; 
        }

        private void AStarAndDijktraFrm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void AStarAndDijktraFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tìm Form1 đang mở
            MenuMain.mn.WindowState = FormWindowState.Maximized;
            MenuMain.mn.BringToFront();
            MenuMain.mn.Activate();
        }
    }
}
