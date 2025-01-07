using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    /*
     CÁI NÀY CHƯA XONG!!!!!!!!
     */
    public partial class FrmHostoHos : Telerik.WinControls.UI.RadForm
    {
        private Dijkstra dijkstra; //triển khai thuật toán Dijkstra
        private List<string> hospitalNames; //danh sách chứa các string là tên bệnh  viện
        private FormView currentFormView; // Khai báo biến currentFormView
        private Astar astar;//Triển khai thuật toán A*
        private int streetcnt = Form1.GetStreetNamesCount(); //Lấy số lượng trong listVertex
        public static bool CheckFrm2; //biến static để quản lý tính năng chuyển tuyến
        public FrmHostoHos(List<string> hospitalNames)
        {
            InitializeComponent();
            Console.WriteLine("Form2 co duoc khoi tao!!!");
            string f = Path.Combine(Application.StartupPath, "logo-bo-y-te.ico");
            this.Icon = new Icon(f);
            this.hospitalNames = hospitalNames;
            // Khởi tạo dijkstra và thêm cạnh vào đồ thị
            dijkstra = new Dijkstra(streetcnt);
            for (int i = 0; i < streetcnt; i++)
            {
                for (int j = 0; j < streetcnt; j++)
                {
                    if (Form1.adjacencyMatrix[i, j] != 0)
                    {
                        dijkstra.AddEdge(i, j, Form1.adjacencyMatrix[i, j]);
                    }
                }
            }
            double[] heuristics = new double[streetcnt]; // Khởi tạo mảng heuristics với kích thước bằng số lượng nút
            for (int i = 0; i < streetcnt; i++)
            {
                heuristics[i] = 0;
            }

            astar = new Astar(streetcnt, heuristics); // Khởi tạo astar với heuristic
            for (int i = 0; i < streetcnt; i++)
            {
                for (int j = 0; j < streetcnt; j++)
                {
                    if (Form1.adjacencyMatrix[i, j] != 0)
                    {
                        astar.AddEdge(i, j, Form1.adjacencyMatrix[i, j]); // Thêm cạnh vào Astar với trọng số từ adjacencyMatrix
                    }
                }
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tìm Form1 đang mở

            if (e.CloseReason == CloseReason.UserClosing)
            {
                MenuMain menumain = Application.OpenForms.OfType<MenuMain>().FirstOrDefault();

                if (menumain != null)
                {
                    // Nếu đã tồn tại, chỉ cần hiển thị lại
                    menumain.Show();
                    menumain.BringToFront(); // Đưa form lên đầu
                }
                else
                {
                    // Nếu chưa tồn tại, tạo mới và hiển thị
                    menumain = new MenuMain();
                    menumain.Show();
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Cài đặt ComboBox bệnh viện
            cmbFromHospital.Items.Add("Chuyển từ bệnh viện");
            cmbToHospital.Items.Add("Sang bệnh viện");

            cmbFromHospital.Items.AddRange(hospitalNames.ToArray());
            cmbToHospital.Items.AddRange(hospitalNames.ToArray());

            cmbFromHospital.SelectedIndex = 0;
            cmbToHospital.SelectedIndex = 0;
            this.Size = new System.Drawing.Size(1000, 365);
        }

        // Sự kiện khi người dùng quay lại (đóng Form2)
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuMain menumain = Application.OpenForms.OfType<MenuMain>().FirstOrDefault();

            if (menumain != null)
            {
                // Nếu đã tồn tại, chỉ cần hiển thị lại
                menumain.Show();
                menumain.BringToFront(); // Đưa form lên đầu
            }
            else
            {
                // Nếu chưa tồn tại, tạo mới và hiển thị
                menumain = new MenuMain();
                menumain.Show();
            }
        }   
       
       
        // Sự kiện khi người dùng chạy chức năng trong Form2
        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin bệnh viện bắt đầu và kết thúc
                string startHospital = cmbFromHospital.SelectedItem?.ToString();
                string endHospital = cmbToHospital.SelectedItem?.ToString();

                // Tìm chỉ số của bệnh viện trong danh sách streetNames
                int startIndex = Form1.listVertex.IndexOf(startHospital);
                int endIndex = Form1.listVertex.IndexOf(endHospital);

                // Kiểm tra xem có tìm thấy bệnh viện không
                if (startIndex == -1 || endIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn bệnh viện bắt đầu và kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tìm đường đi ngắn nhất
                List<int> path = FindShortesPath(startIndex, endIndex);
                CheckFrm2 = true;
                // Khởi tạo FormView và truyền dữ liệu
                if (path.Count > 0)
                {
                    // Khởi tạo FormView nếu chưa tồn tại
                    if (currentFormView == null || currentFormView.IsDisposed)
                    {
                        currentFormView = new FormView(path, 1); // 1 là speedMultiplier
                    }
                    else
                    {
                        // Nếu FormView đã tồn tại, cập nhật đường đi mới
                        currentFormView.UpdatePath(path);
                    }

                    currentFormView.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đường đi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFromHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedHospital = cmbFromHospital.SelectedItem?.ToString();

            if (selectedHospital != null && selectedHospital != "Chuyển từ bệnh viện")
            {
                    if (cmbToHospital.DataSource == null || !((List<string>)cmbToHospital.DataSource)[0].Equals(selectedHospital))
                {
                    // Tạo danh sách chỉ chứa tên bệnh viện
                    List<string> hospitalNamesOnly = new List<string>();
                    foreach (string name in Form1.listVertex)
                    {
                        if (name.StartsWith("Bệnh viện"))
                        {
                            hospitalNamesOnly.Add(name);
                        }
                    }

                    // Loại bỏ bệnh viện đã chọn khỏi danh sách
                    hospitalNamesOnly.Remove(selectedHospital);
                    cmbToHospital.Enabled = true;

                    // Cập nhật DataSource cho cmbToHospital
                    cmbToHospital.DataSource = hospitalNamesOnly;

                    if (hospitalNamesOnly.Count > 0)
                    {
                        cmbToHospital.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                cmbFromHospital.SelectedIndex = 0;
                cmbToHospital.Enabled = false; // Vô hiệu hóa cmbToHospital nếu cmbFromHospital chưa được chọn
            }
        }
        private List<int> FindShortesPath(int startIndex, int endIndex)
        {
            string algorithmType = MenuMain.AlgrType;

            if (algorithmType == "A*")
            {
                return astar.FindPath(startIndex, endIndex);
            }
            else if (algorithmType == "Dijkstra")
            {
                return dijkstra.DijkstraWithPath(startIndex, endIndex);
            }

            return null; 
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      