using Org.BouncyCastle.Pqc.Crypto.Lms;
using ServiceStack;
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
using Telerik.WinControls.UI;
using WindowsFormsApp1.Properties;
using WindowsFormsApp1.QuanLy_Ambulance;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace WindowsFormsApp1
{
    /*
     CÁI NÀY CHƯA XONG!!!!!!!!

     */
    public partial class FrmHostoHos : Telerik.WinControls.UI.RadForm
    {
        private Dijkstra dijkstra; //triển khai thuật toán Dijkstra
        private FormView currentFormView; // Khai báo biến currentFormView
        private Astar astar;//Triển khai thuật toán A*
        private int streetcnt = Form1.GetStreetNamesCount(); //Lấy số lượng trong listVertex
        public static bool CheckFrm2; //biến static để quản lý tính năng chuyển tuyến
        private List<string> HospitalName = Form1.GetHospitalNames(); // lấy danh sách bệnh viện từ Form115
        private BindingSource bindingSource = new BindingSource(); // tạo BidingSource để nối CSDL
        private Dictionary<string, int> HospitalId = Form1.HospitalId; // danh sách bệnh viện và ID bệnh viện tương ứng
        /// <summary>
        /// Load dữ liệu bệnh nhân
        /// </summary>
        private void LoadDataPatient()
        {
            bindingSource.DataSource = DatabaseQuanLy.Instance.Patients.OrderBy(p => p.PatientId).ToList();
            if (DatabaseQuanLy.Instance.Patients.Any())
                HienthiDataPatient(0);
        }
        /// <summary>
        /// Hiển thị dữ liệu bệnh nhân
        /// </summary>
        /// <param name="idrow">Hàng cần được hiển thị , nên là 0 ( hàng đầu tiên )</param>
        private void HienthiDataPatient(int idrow)
        {
            string ptid = RGVPatient.Rows[idrow].Cells[0].Value.ToString();
            Patient pt = DatabaseQuanLy.Instance.Patients.SingleOrDefault(p => p.PatientId.ToString() == ptid.ToString());
        }
        /// <summary>
        /// Hàm khởi tạo thuật toán
        /// </summary>
        private void constructorAlgor()
        {
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
        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        public FrmHostoHos()
        {
            InitializeComponent();
            this.FormElement.Border.ForeColor = Color.White;
            RGVPatient.DataSource = bindingSource;
            LoadDataPatient();
            constructorAlgor();
            RGVPatient.Columns["Hospital"].IsVisible = false;
            string f = Path.Combine(Application.StartupPath, "logo-bo-y-te.ico");
            this.Icon = new Icon(f);

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tìm Form1 đang mở
            MenuMain.frmlist.WindowState = FormWindowState.Minimized;
            MenuMain.mn.WindowState = FormWindowState.Maximized;
            MenuMain.mn.BringToFront();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Cài đặt ComboBox bệnh viện
            cmbToHos.Items.Add("Chuyển đến bệnh viện");

            cmbToHos.Items.AddRange(HospitalName.ToArray());

            cmbToHos.SelectedIndex = 0;
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
        /// <summary>
        /// Hàm chọn xe cứu thương
        /// </summary>
        /// <returns>Xe cứu thương được làm nhiệm vụ</returns>
        private int PickRandomAmbu()
        {

            string HospitalStart = cmbHosPatient.Text;
            if (HospitalStart == null) { MessageBox.Show("Error PickrandomAmbu", "Thông báo", MessageBoxButtons.OK); }// ném ngooại lệ
            int HosStartId = HospitalId[HospitalStart];
            //lọc ra list Id những ambulance có thể hoạt động dc từ databasee
            List<string> danhsachId = DatabaseQuanLy.Instance.Ambulances
                .Where(ambulance => ambulance.AmbulanceLocation == HosStartId)
                .Where(ambulance => ambulance.Đang_Hoạt_Động == false)
                .Select(ambulance => ambulance.AmbulanceId).ToList();
            Random random = new Random();
            int IndexAmbuId = random.Next(danhsachId.Count);
            int AmbuId_Random = danhsachId[IndexAmbuId].ToInt(); // convert về int
            return AmbuId_Random;
        }
        /// <summary>
        /// THêm xe cứu thương làm nhiệm vụ vào database
        /// </summary>
        /// <param name="AmbuId">ID của xe</param>
        private void AdjustmentDataAmbu(int AmbuId)
        {
            Ambulance ambu = DatabaseQuanLy.Instance.Ambulances.FirstOrDefault(ab => ab.AmbulanceId == AmbuId.ToString());//lấy ra infor
            if (ambu != null)
            {
                ambu.Đang_Hoạt_Động = true;
            }
            DatabaseQuanLy.Instance.SubmitChanges();
            AmbulanceMission ambumiss = new AmbulanceMission();//khởi tạo 1 object AmbulanceMission để đưa vào database
            ambumiss.AmbulanceId = ambu.AmbulanceId;
            ambumiss.AmbulanceName = ambu.AmbulanceName;
            ambumiss.MissionType = "Chuyển tuyến";//mission type = 115 vì Đây là tính năng 115
            DatabaseQuanLy.Instance.AmbulanceMissions.InsertOnSubmit(ambumiss);
            DatabaseQuanLy.Instance.SubmitChanges();
            this.Tag = ambu.AmbulanceId.ToString();
            FrmAmbu frmAmbu = Application.OpenForms.OfType<FrmAmbu>().FirstOrDefault();
            if (frmAmbu != null)
            {
                frmAmbu.RefreshDataGridView();
            }
        }
        /// <summary>
        /// Điều chỉnh data của bệnh nhân
        /// </summary>
        private void AdjustmentDataPatient() 
        {
            string Ptid = txtID.Text;
            Patient pt = DatabaseQuanLy.Instance.Patients.FirstOrDefault(p => p.PatientId.ToString() == Ptid);
            if (pt != null)
            {
                pt.Status = "Đang được chuyển viện";
            }
            DatabaseQuanLy.Instance.SubmitChanges();
        }
        /// <summary>
        /// Tìm ID của bệnh viện
        /// </summary>
        /// <returns>1 string là ID của bệnh viện</returns>
        private string FindHosID()
        {
            string nameHos = cmbToHos.Text;
            Hospital hos = DatabaseQuanLy.Instance.Hospitals.Where(p=> p.HospitalName == nameHos).FirstOrDefault();
            if (hos == null)
            {
                MessageBox.Show("FrmHostoHos không tìm được ID của bệnh viện đến", "Thông báo", MessageBoxButtons.OK);//ném ngoại lệ test bug
                return "";
            }
            else
            {
                return hos.HospitalID.ToString();
            }
        }
        /// <summary>
        /// Sự kiện khi người dùng ấn vào nút Run
        /// </summary>
        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                int randomAmbu = PickRandomAmbu();
                AdjustmentDataAmbu(randomAmbu);
                // Lấy thông tin bệnh viện bắt đầu và kết thúc
                string startHospital = cmbHosPatient.Text;
                string endHospital = cmbToHos.Text;

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
                        string HosToId = FindHosID();
                        AdjustmentDataPatient();
                        currentFormView = new FormView(path,  1, txtID.Text.ToString(),HosToId,randomAmbu); // 1 là speedMultiplier
                        FrmListView.AddFormView(currentFormView);
                    }
                    //thêm phần FrmListView

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
        /// <summary>
        /// Lọc bệnh viện của bệnh nhân ra khỏi combobox 2
        /// </summary>
        private void cmbToHosRemoveItem()
        {
            string hosPatient = cmbHosPatient.Text;
            List<string> hosCmb = HospitalName;
            hosCmb.Remove(hosPatient); // lọc bệnhviên của cái trên ra
            cmbToHos.DataSource = hosCmb;
        }
        /// <summary>
        /// Hàm tìm đường đi
        /// </summary>
        /// <param name="startIndex">Index đỉnh A</param>
        /// <param name="endIndex">Index đỉnh B</param>
        /// <returns>Danh sách đỉnh trong đường đi</returns>
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
        /// <summary>
        /// Tìm kiếm ID của bệnh nhân
        /// </summary>
        private void btbSearch_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Bạn chưa nhập ID", "Thông báo", MessageBoxButtons.OK);
                txtID.Focus();
            }
            else
            {
                Patient pt = DatabaseQuanLy.Instance.Patients.FirstOrDefault(p => p.PatientId.ToString() == id);//lấy ra infor
                if (pt == null)
                {
                    MessageBox.Show($"Không tìm thấy bệnh nhân với ID : {txtID.Text}!", "Thông báo", MessageBoxButtons.OK);
                    txtID.Focus();
                }
                else
                {
                     RGVPatient.DataSource = DatabaseQuanLy.Instance.Patients.Where(p => p.PatientId.ToString() == id);
                    RGVPatient.Columns["Hospital"].IsVisible = false;
                }

            }
        }
        /// <summary>
        /// Tìm kiếm theo tên bệnh nhân
        /// </summary>
        private void SearchByName(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (string.IsNullOrEmpty(name)) 
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân!", "Thông báo", MessageBoxButtons.OK);
                txtName.Focus();
            }
            else
            {
                //sử dụng hàm so sánh 2 chuỗi ko quan tâm dấu cách, viết hoa
                Patient pt = DatabaseQuanLy.Instance.Patients.FirstOrDefault(p => string.Compare(p.PatientName,name,true)==0);
                if(pt == null)
                {
                    MessageBox.Show($"Không tìm thấy tên bệnh nhân {name}!", "Thông báo", MessageBoxButtons.OK);
                    txtName.Focus();
                }
                else
                {
                    RGVPatient.DataSource = DatabaseQuanLy.Instance.Patients.Where((p => string.Compare(p.PatientName, name, true) == 0));
                    RGVPatient.Columns["Hospital"].IsVisible = false;
                }
            }
        }
        /// <summary>
        /// Lọc ra bệnh nhân theo ID
        /// </summary>
        private void ClickById()
        {
                string patientId = RGVPatient.Rows[0].Cells[0].Value.ToString();
                Patient pt = DatabaseQuanLy.Instance.Patients.FirstOrDefault(p => p.PatientId.ToString() == patientId);
            
                Hospital Hos = DatabaseQuanLy.Instance.Hospitals.FirstOrDefault(p => p.HospitalID.ToString() == pt.HospitalID.ToString());
                if (Hos == null)
                {
                    MessageBox.Show("Không có bệnh viện tương ứng", "Thông báo", MessageBoxButtons.OK);//ném ngooại lệ
                    return;
                }
                lblPatient.Text = $"Bệnh nhân: {pt.PatientName} / ID : {pt.PatientId}";
                cmbHosPatient.Text = $"{Hos.HospitalName}";
                 cmbToHos.Enabled = true;  
        }
        /// <summary>
        /// Chọn bệnh nhân để chuyển viện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btbSelecPatient(object sender, EventArgs e)
        {
            if(RGVPatient.Rows.Count == 0)
            {
                MessageBox.Show("Không có bệnh nhân nào tương ứng!, vui lòng nhập ID của bệnh nhân", "Thông báo", MessageBoxButtons.OK);
                txtID.Focus();
            }
            if(RGVPatient.Rows.Count > 1)
            {
                if (txtID.Text.IsEmpty()) 
                {
                    MessageBox.Show("Chỉ được chọn 1 bệnh nhân, vui lòng nhập ID!", "Thông báo", MessageBoxButtons.OK);
                    txtID.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng tìm kiếm theo ID để tìm kiếm bệnh nhân!", "Thông báo", MessageBoxButtons.OK);
                    btbSearch.Focus();
                }
            }
            if(RGVPatient.Rows.Count == 1)
            {
                ClickById();
                cmbToHosRemoveItem();
            }
        }
    }
}