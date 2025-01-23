﻿using ServiceStack;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI.Map.Bing;
using WindowsFormsApp1.QuanLy_Ambulance;

namespace WindowsFormsApp1
{
    public partial class FormView : Telerik.WinControls.UI.RadForm
    {
         /*
         Phần khởi tạo !!!!
         */
        //biến toàn cục
        private List<int> path; // đuờng đi, dc nhận từ Form115
        private int speedMultiplier = 1; // Khởi tạo giá trị mặc định
        private Bitmap bmp; // khởi tạo 1 bitmap tên bmp để phục vụ việc vẽ
        private Bitmap zoomedBmp; // Bitmap cho chế độ zoom
        private List<PointF> pathCoordinates; // Tọa độ các đỉnh mà xe cứu thương sẽ đi qua
        private int currentStep = 0; // currentStep : mặc định bằng 0 ( xuất phát từ đỉnh đầu tiên )
        private float t = 0; //xác định vị trí của xe cứu thương trên mỗi đoạn đường đại diện cho tỷ lệ thời gian đã trôi qua trên đoạn đường hiện tại, có giá trị từ 0 đến 1.
        private float totalTime = 25000; // khởi tạo tổng thời gian di chuyển 
        private DateTime startTime = DateTime.Now; // Lưu thời điểm bắt đầu mô phỏng.
        private DateTime customDateTime = DateTime.Now; //Lưu thời gian hiện tại trong mô phỏng, được cập nhật liên tục
        private DateTime segmentStartTime = DateTime.Now; // Lưu thời điểm bắt đầu của đoạn đường hiện tại.
        private DateTime simulationTime = DateTime.Now; //  Lưu thời gian mô phỏng cho việc tính toán vị trí của xe, được cập nhật liên tục 
        private PictureBox pictureBoxAmbulance; // Control hiển thị hình ảnh xe cứu thương trên bản đồ
        private Dictionary<int, GraphNode> nodePositions;
        private Image ambulanceImage; // ảnh xe cứu thương
        private Image hospitalImage; // ảnh bệnh viện
        private Image roadImage; // ảnh đường 
        private Image trafficLightImage; // ảnh đèn đỏ  
        private Rectangle zoomRect;//xác định vùng bản đồ sẽ được vẽ lên picturebox zoom
        private Point ambulanceLocation; // Lưu vị trí ban đầu của xe cứu thương
        private double currentSpeed = 0; // tốc độ hiện tại của xe cứu thương
        public Font boldFont = new Font("Open Sans", 10, FontStyle.Bold); //font chữ
        bool isFlashing = false; // biến kiểm tra xem đã đến lúc nhấp nháy đoạn đường đi hay chưa
        private float alpha = 1f; // Độ trong suốt ban đầu là 100%
        private bool isFadingOut = true; // Ban đầu là mờ dần
        public static List<int> hospitalNodes = new List<int>() { 0, 1, 6, 7, 9, 14, 15, 16, 17, 18, 19, 20, 26 }; //các đỉnh là bệnh viện
        private string accidentLocation; // Biến lưu vị trí tai nạn
        public delegate void ReachedDestinationEventHandler(object sender, EventArgs e);
        public event ReachedDestinationEventHandler ReachedDestination;
        private int targetStreetIndex; // Biến lưu trữ chỉ số con đường tai nạn
        private bool reachedAccidentLocation = false; // Biến theo dõi trạng thái
        private int vertecnt = Form1.GetStreetNamesCount();
        private Random random = new Random();
        private List<TrafficLight> trafficLights = Form1.trafficLights;
        private string PatienId;
        private string HosToId;
        /// <summary> Hàm dùng để khởi tạo Size của Form
        /// <para>
        ///
        /// </para>
        /// </summary>
        private void InitializeForm()
        {
            this.BringToFront();
            this.FormElement.Border.ForeColor = Color.White;
            this.Size = new Size(1900, 1500);
        }
        /// <summary> Hàm dùng để khởi tạo các thuộc tính của các picturebox
        /// <para>
        ///
        /// </para>
        /// </summary>
        private void InitializePictureBoxes()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBoxAmbulance = new PictureBox();
            pictureBoxAmbulance.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAmbulance.BackColor = Color.Transparent;
            pictureBoxAmbulance.Size = new Size(40, 40);
            pictureBox1.Controls.Add(pictureBoxAmbulance);

            // Sử dụng vòng lặp để thiết lập Width và Height cho PictureBox
            foreach (var pictureBox in new[] { pictureBox1, pictureBoxZoom })
            {
                pictureBox.Width = this.ClientSize.Width;
                pictureBox.Height = this.ClientSize.Height;
            }
            pictureBoxZoom.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Location = new Point(0, 0);
        }
        /// <summary> Hàm dùng để khởi tạo tọa độ các Node trên trục Oxy
        /// <para>
        ///
        /// </para>
        /// </summary>
        private void InitializeNodePositions()
        {
            nodePositions = new Dictionary<int, GraphNode>()
    {
       {0, new GraphNode(0, "Bệnh viện Phạm Ngọc Thạch", new Point(420, 580), NodeType.Hospital) },
    {1, new GraphNode(1, "Bệnh viện ĐH Y Dược", new Point(420, 660), NodeType.Hospital) },
    {2, new GraphNode(2, "Đường Hồng Bàng", new Point(550, 620), NodeType.Intersection) },
    {3, new GraphNode(3, "Đường Hùng Vương", new Point(1075, 425), NodeType.Intersection) },
    {4, new GraphNode(4, "Đường An Dương Vương", new Point(925, 640), NodeType.Intersection) },
    {5, new GraphNode(5, "Đường Ngô Quyền", new Point(550, 500), NodeType.Intersection) },
    {6, new GraphNode(6, "Bệnh viện Răng Hàm Mặt", new Point(1225, 600), NodeType.Hospital) },
    {7, new GraphNode(7, "Bệnh viện Chợ Rẫy", new Point(250, 515), NodeType.Hospital) },
    {8, new GraphNode(8, "Đường 3/2", new Point(550, 300), NodeType.Intersection) },
    {9, new GraphNode(9, "Bệnh viện Nhi Đồng 1", new Point(725, 250), NodeType.Hospital) },
    {10, new GraphNode(10, "Ngã 6 Nguyễn Tri Phương", new Point(750, 450), NodeType.Intersection) },
    {11, new GraphNode(11, "Đường Ngô Gia Tự", new Point(700, 500), NodeType.Intersection) },
    {12, new GraphNode(12, "Ngã 7 Lý Thái Tổ", new Point(925, 250), NodeType.Intersection) },
    {13, new GraphNode(13, "Đường Điện Biên Phủ", new Point(925, 200), NodeType.Intersection) },
    {14, new GraphNode(14, "Bệnh viện Bình Dân", new Point(1150, 100), NodeType.Hospital) },
    {15, new GraphNode(15, "Bệnh viện Mắt", new Point(1150, 150), NodeType.Hospital) },
    {16, new GraphNode(16, "Bệnh viện Da Liễu", new Point(1300, 200), NodeType.Hospital) },
    {17, new GraphNode(17, "Bệnh viện Quận 10", new Point(350, 150), NodeType.Hospital) },
    {18, new GraphNode(18, "Bệnh viện Quận 3", new Point(645, 95), NodeType.Hospital) },
    {19, new GraphNode(19, "Bệnh viện Quận 6", new Point(100, 680), NodeType.Hospital) },
    {20, new GraphNode(20, "Bệnh viện Quận 5", new Point(550, 800), NodeType.Hospital) },
    {21, new GraphNode(21, "Đường Cách Mạng Tháng 8", new Point(1200, 300), NodeType.Intersection) },
    {22, new GraphNode(22, "Ngã tư Ngô Gia Tự", new Point(815, 365), NodeType.Intersection) },
    {23, new GraphNode(23, "Đường Sư Vạn Hạnh", new Point(450, 225), NodeType.Intersection) },
    {24, new GraphNode(24, "Đường Lý Chính Thắng", new Point(725, 125), NodeType.Intersection) },
    {25, new GraphNode(25, "Đường Nguyễn Văn Luông", new Point(250, 625), NodeType.Intersection) },
    {26, new GraphNode(26, "Bệnh viện Tai Mũi Họng", new Point(825, 100), NodeType.Hospital) },
    {27, new GraphNode(27, "Đường Nguyễn Văn Cừ", new Point(1125, 750), NodeType.Intersection) },
    {28, new GraphNode(28, "Đường Ngô Quyền nối dài", new Point(550, 725), NodeType.Intersection) },
    {29, new GraphNode(29, "Đèn đỏ bệnh viện quận 6 - Nguyễn Văn Luông", new Point( /* tọa độ */ ), NodeType.TrafficLight) },
    {30, new GraphNode(30, "Đèn đỏ Hồng Bàng - An Dương Vương", new Point( /* tọa độ */ ), NodeType.TrafficLight) },
    {31, new GraphNode(31, "Đèn đỏ An Dương Vương - Nguyễn Văn Cừ", new Point( /* tọa độ */ ), NodeType.TrafficLight) },
    {32, new GraphNode(32, "Đèn đỏ Hồng Bàng - Hùng Vương", new Point( /* tọa độ */ ), NodeType.TrafficLight) },
    {33, new GraphNode(33, "Đèn đỏ Hùng Vương - Cách Mạng Tháng 8", new Point( /* tọa độ */ ), NodeType.TrafficLight) },
    {34, new GraphNode(34, "Đèn đỏ Điện Biên Phủ - Cách Mạng Tháng 8", new Point( /* tọa độ */ ), NodeType.TrafficLight) },
    {35, new GraphNode(35, "Đèn đỏ Ngô Quyền - 3/2", new Point( /* tọa độ */ ), NodeType.TrafficLight) },
    {36, new GraphNode(36, "Đèn đỏ 3/2 - Ngã 6 Nguyễn Tri Phương", new Point( /* tọa độ */ ), NodeType.TrafficLight) },
    {37, new GraphNode(37, "Đèn đỏ 3/2 - Lý Chính Thắng", new Point( /* tọa độ */ ), NodeType.TrafficLight) },
    {38, new GraphNode(38, "Đèn đỏ Ngô Quyền - Chợ Rẫy", new Point( /* tọa độ */ ), NodeType.TrafficLight) }
    };

            // Cập nhật vị trí đèn giao thông
            foreach (var light in Form1.trafficLights)
            {
                light.UpdateTrafficLightLocations(Form1.trafficLights, Form1.adjacencyMatrix, nodePositions);
            }
        }
        /// <summary> 
        /// Hàm này để khởi tạo danh sách đỉnh
        /// </summary>
        private void InitializePath()
        {
            pathCoordinates = new List<PointF>();
            foreach (int nodeIndex in path)
            {
                pathCoordinates.Add(nodePositions[nodeIndex].Location);
            }
        }
        /// <summary>
        /// Hàm này để khởi tạo các icon, các Bitmap và vị trí ban đầu của xe
        /// </summary>
        private void InitializeComponents()
        {
            string f = Path.Combine(Application.StartupPath, "logo-bo-y-te.ico");
            this.Icon = new Icon(f);
            zoomedBmp = new Bitmap(pictureBox1.Width * 2, pictureBox1.Height * 2);
            zoomRect = new Rectangle(0, 0, pictureBox1.Width / 2, pictureBox1.Height / 2);
            ambulanceLocation = pictureBoxAmbulance.Location;

            ambulanceImage = Image.FromFile("AmbulanceEmoji.png");
            hospitalImage = Image.FromFile("HospitalEmoji.png");
            roadImage = Image.FromFile("RoadImage.png");
            trafficLightImage = Image.FromFile("Trafficlight.png");

            // Sử dụng  để thêm item vào ComboBox
            ViewChose.Items.AddRange(new[] { "Toàn cảnh", "Zoom" });
            ViewChose.SelectedItem = "Toàn cảnh";
            pictureBoxAmbulance.Image = ambulanceImage;
            pictureBoxAmbulance.Visible = true;
            pictureBox1.Visible = true;

            segmentStartTime = customDateTime;

            lblNextRoute.Font = boldFont;
            lblSpeed.Font = boldFont;
        }
        /// <summary>
        /// Khởi tạo và bắt đầu các bộ đếm
        /// </summary>
        private void InitializeTimers()
        {
            timerUpdate.Start();
            timer2.Start();
            dTIME.Start();
            timer1.Start();
            TimerFlashing.Start();
        }
        /// <summary>
        /// Hàm khởi tạo 5 tham số dành cho Tính năng Chuyển tuyến
        /// </summary>
        /// <param name="path"> đường đi được tạo bởi thuật toán</param>
        /// <param name="speedMultiplier">tốc độ mặc định ban đầu của "độ trôi thời gian",nên là 1</param>
        /// <param name="pt">Bệnh nhân được chuyển viện</param>
        /// <param name="Hosid"> ID của bệnh viện đích</param>
        /// <param name="AmbuId">ID của xe cứu thương thực hiện nhiệm vụ</param>
        public FormView(List<int> path, int speedMultiplier, string pt,string Hosid,int AmbuId)
        {
            InitializeComponent();
            this.path = path; this.TopLevel = false;
            this.PatienId = pt;
            this.HosToId = Hosid;
            this.Tag = AmbuId;
            this.speedMultiplier = speedMultiplier;
            InitializeForm();
            InitializePictureBoxes();
            InitializeNodePositions();
            InitializePath();
            InitializeComponents();
            InitializeTimers();
            // Tính toán totalTime cho đoạn đường đầu tiên
            if (path.Count > 1)
            {
                float distance = Form1.adjacencyMatrix[path[0], path[1]];
                totalTime = TimeAmbulanceMove.CalculateTravelTime(distance, customDateTime) * speedMultiplier;
            }

            // Vẽ đồ thị và thiết lập vị trí ban đầu của xe cứu thương
            DrawGraph();
            pictureBox1.Image = bmp;
            if (path.Count > 0)
            {
                pictureBoxAmbulance.Location = nodePositions[path[0]].Location;
            }
        }
        /// <summary>
        /// hàm khởi tạo 5 tham số dành cho tính năng 115
        /// </summary>
        /// <param name="path"> đường đi được tạo bởi thuật toán</param>
        /// <param name="speedMultiplier">tốc độ mặc định ban đầu của "độ trôi thời gian",nên là 1</param>
        /// <param name="accidentLocation">Tên của con đường xảy ra tai nạn</param>
        /// <param name="targetStreetIndex">Vị trí tương ứng của con đường</param>
        /// <param name="randId">ID của xe cứu thương được chọn làm nhiệm vụ</param>
        public FormView(List<int> path, int speedMultiplier, string accidentLocation, int targetStreetIndex,int randId)
        {
            InitializeComponent();
            this.Visible = false;
            this.TopLevel = false;
            this.Tag = randId;
            this.path = path;
            this.speedMultiplier = speedMultiplier;
            this.accidentLocation = accidentLocation;
            this.targetStreetIndex = targetStreetIndex;
            InitializeForm();
            InitializePictureBoxes();
            InitializeNodePositions();
            InitializePath();
            InitializeComponents();
            InitializeTimers();

            // Tính toán totalTime cho đoạn đường đầu tiên
            if (path.Count > 1)
            {
                float distance = Form1.adjacencyMatrix[path[0], path[1]];
                totalTime = TimeAmbulanceMove.CalculateTravelTime(distance, customDateTime) * speedMultiplier;
            }

            // Vẽ đồ thị và thiết lập vị trí ban đầu của xe cứu thương
            DrawGraph();
            pictureBox1.Image = bmp;
            if (path.Count > 0)
            {
                pictureBoxAmbulance.Location = nodePositions[path[0]].Location;
            }
        }
        /// <summary>
        /// Hàm này được dùng để vẽ lại đồ thị lên trục OXY dành cho View "Toàn cảnh"
        /// </summary>
        private void DrawGraph()
        {
            // Khai báo và khởi tạo các biến
            List<int> hospitalNodes = new List<int>() { 0, 1, 6, 7, 9, 14, 15, 16, 17, 18, 19, 20, 26 }; //các đỉnh là bệnh viện
            hospitalImage = new Bitmap(hospitalImage, new Size(30, 30));//gán size cho ảnh bệnh viện
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic; //Tăng chất lượng hình ảnh ( cao nhất )
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit; //Cải thiện chất lượng hiển thị văn bản
            graphics.SmoothingMode = SmoothingMode.AntiAlias; //Bật chế độ khử răng cưa
            graphics.SmoothingMode = SmoothingMode.HighQuality; //Khử răng cưa mức cao
            graphics.CompositingQuality = CompositingQuality.HighQuality; 
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Tạo TextureBrush từ hình ảnh
            TextureBrush roadBrush = new TextureBrush(roadImage);
            int thickness = 3; // độ dày của đường  
            // Vẽ các cạnh
            for (int i = 0; i < vertecnt; i++)
            {
                for (int j = i + 1; j < vertecnt; j++)
                {
                    if (Form1.adjacencyMatrix[i, j] != 0)
                    {
                        // Tính toán điểm đầu và điểm cuối của cạnh
                        GraphNode startNode = nodePositions[i];
                        GraphNode endNode = nodePositions[j];

                        // Tính toán độ dài và góc của cạnh
                        /*
                         Math.Atan2 :  tính arctang của tỷ số (endPoint.Y - startPoint.Y) / (endPoint.X - startPoint.X), 
                         trả về góc (tính bằng radian) giữa đường thẳng nối hai điểm và trục hoành.
                         */
                        // Xác định độ dài của cạnh để vẽ đường thẳng với độ dài chính xác.
                        double length = Math.Sqrt(Math.Pow(endNode.Location.X - startNode.Location.X, 2) + Math.Pow(endNode.Location.Y - startNode.Location.Y, 2));
                        // Xác định góc của cạnh so với trục hoành để xoay Graphics object trước khi vẽ, đảm bảo đường thẳng được vẽ đúng hướng.
                        double angle = Math.Atan2(endNode.Location.Y - startNode.Location.Y, endNode.Location.X - startNode.Location.X); 

                        Pen roadPen = new Pen(roadBrush, thickness)
                        {
                            Alignment = PenAlignment.Center,  // Căn chỉnh nét vẽ vào trong
                            EndCap = LineCap.Round,          // Làm tròn đầu cạnh
                            StartCap = LineCap.Round         // Làm tròn cuối cạnh
                        };

                        // Xoay Graphics object
                        /*
                         Thay vì phải tính toán tọa độ của các điểm trên đường thẳng theo góc, 
                        ta chỉ cần vẽ một đường thẳng từ gốc tọa độ mới đến điểm endPoint sau khi đã xoay Graphics object.
                         */
                        graphics.TranslateTransform(startNode.Location.X, startNode.Location.Y);//chuyển gốc tọa độ của Graphics object đến điểm startPoint
                        graphics.RotateTransform((float)(angle * 180 / Math.PI));//Xoay Graphics object một góc angle (đã được chuyển đổi từ radian sang độ).

                        // Vẽ đường viền màu đen
                        Pen borderPen = new Pen(Color.Black, 2); // Độ dày đường viền là 3
                        graphics.DrawLine(borderPen, 0, 0, (float)length, 0);
                        borderPen.Dispose();
                        //vẽ đường đi
                        if (isFlashing && path.Contains(i) && path.Contains(j))
                        {
                            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            Color flashColor = Color.FromArgb((int)(alpha * 255), Color.Red); // Tạo màu với độ trong suốt
                            graphics.DrawLine(new Pen(flashColor, thickness), 0, 0, (float)length, 0);
                        }
                        else
                        {
                            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            graphics.DrawLine(roadPen, 0, 0, (float)length, 0);
                        }
                        roadPen.Dispose();

                        // Reset transform
                        graphics.ResetTransform();
                    }
                }
            }
            // Vẽ các nút và tên đường
            for (int i = 0; i < nodePositions.Count; i++)
            {
                // Vẽ các đỉnh bình thường ( không phải bệnh viện )
                if (!hospitalNodes.Contains(i))
                {
                    graphics.FillEllipse(Brushes.Red, nodePositions[i].Location.X - 5, nodePositions[i].Location.Y - 5, 10, 10);
                }

                // Vẽ tên đường
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center // căn giữa
                };
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit; // bật khử răng cưa
                //nếu đỉnh đó là bệnh viện
                if (nodePositions[i].Type == NodeType.Hospital)
                {
                    // Điều chỉnh vị trí của chữ cho các nút là bệnh viện ( để ko bị dính vào nhau )
                    int offsetX = 20; // Khoảng cách theo chiều ngang so với hình ảnh
                    int offsetY = 5;  // Khoảng cách theo chiều dọc so với hình ảnh
                    graphics.DrawString(nodePositions[i].Name, boldFont, Brushes.Black,
                           nodePositions[i].Location.X + offsetX,
                           nodePositions[i].Location.Y + offsetY,
                           stringFormat);
                }
                else if (nodePositions[i].Type == NodeType.TrafficLight)
                {

                }
                else
                {
                    // Vẽ tên đường như cũ cho các nút không phải là bệnh viện
                    graphics.DrawString(nodePositions[i].Name, boldFont, Brushes.Black,
                       nodePositions[i].Location.X + 10,
                       nodePositions[i].Location.Y,
                       stringFormat);
                }
            }
            // Vẽ biểu tượng bệnh viện
            for (int i = 0; i < nodePositions.Count; i++)
            {
                if (hospitalNodes.Contains(i))
                {
                    graphics.DrawImage(hospitalImage, nodePositions[i].Location.X - hospitalImage.Width / 2,
                                                     nodePositions[i].Location.Y - hospitalImage.Height / 2);
                }
            }
            foreach (var light in Form1.trafficLights)
            {
                if (nodePositions.ContainsKey(light.Index))
                {
                    Point lightLocation = nodePositions[light.Index].Location; // Lấy Location từ GraphNode
                    graphics.DrawImage(trafficLightImage, lightLocation.X - 15, lightLocation.Y - 15/*dịch vị trí ở đây :))*/, 30, 30);
                }
            }
            pictureBox1.Image = bmp; //hiển thị lên form
        }
        /// <summary>
        /// Hàm này vẽ lại đồ thị xung quanh xe cứu thương nhưng được phóng to lên cho người dùng quan sát
        /// </summary>
        /// <param name="graphics">Đồ thị ban đầu được vẽ</param>
        private void DrawGraphZoom(Graphics graphics)
        {
            List<int> hospitalNodes = new List<int>() { 0, 1, 6, 7, 9, 14, 15, 16, 17, 18, 19, 20, 26 }; // danh sách đỉnh là bệnh viện
            Image hospitalImage = Image.FromFile("HospitalEmoji.png");
            hospitalImage = new Bitmap(hospitalImage, new Size(30, 30));
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Tạo TextureBrush
            TextureBrush roadBrush = new TextureBrush(roadImage);
            int thickness = 5; // điều chỉnh dộ đày của đường
            // Tính toán lại tọa độ các nút cho chế độ zoom ( phóng to gấp đôi)
            Dictionary<int, Point> zoomedNodePositions = new Dictionary<int, Point>();
            foreach (var kvp in nodePositions)
            {
                zoomedNodePositions[kvp.Key] = new Point(
                    (int)(kvp.Value.Location.X * 2),
                    (int)(kvp.Value.Location.Y * 2)
                );
            }

            // Vẽ các cạnh
            for (int i = 0; i < vertecnt   /*Form1.adjacencyMatrix.GetLength(0)*/; i++)
            {
                for (int j = i + 1; j < vertecnt; j++)
                {
                    if (Form1.adjacencyMatrix[i, j] != 0)
                    {
                        // Tính toán điểm đầu và điểm cuối của cạnh (sử dụng zoomedNodePositions)
                        Point startPoint = zoomedNodePositions[i];
                        Point endPoint = zoomedNodePositions[j];

                        // Tính toán độ dài và góc của cạnh
                        //Math.Atan2 tính argtan...
                        double length = Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
                        double angle = Math.Atan2(endPoint.Y - startPoint.Y, endPoint.X - startPoint.X);
                        // tạo ra một đối tượng Pen mới để vẽ đường thẳng, với các thuộc tính được thiết lập để tạo ra nét vẽ đẹp mắt hơn.
                        Pen roadPen = new Pen(roadBrush, thickness)
                        {
                            Alignment = PenAlignment.Inset,
                            EndCap = LineCap.Round,
                            StartCap = LineCap.Round
                        };

                        // Xoay Graphics object
                        graphics.TranslateTransform(startPoint.X, startPoint.Y);
                        graphics.RotateTransform((float)(angle * 180 / Math.PI));

                        // Vẽ đường viền màu đen

                        // Vẽ đường viền màu đen
                        Pen borderPen = new Pen(Color.Black, 2);
                        graphics.DrawLine(borderPen, 0, 0, (float)length, 0);
                        borderPen.Dispose();

                        // Vẽ đường đi bình thường
                        graphics.DrawLine(roadPen, 0, 0, (float)length, 0);

                        roadPen.Dispose();

                        // Reset transform
                        graphics.ResetTransform();
                    }
                }
            }

            // Vẽ các nút và tên đường (sử dụng zoomedNodePositions)
            for (int i = 0; i < zoomedNodePositions.Count; i++)
            {
                // Vẽ nút bình thường
                if (!hospitalNodes.Contains(i))
                {
                    graphics.FillEllipse(Brushes.Red, zoomedNodePositions[i].X - 5, zoomedNodePositions[i].Y - 5, 10, 10);
                }

                // Vẽ tên đường
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center
                };
                graphics.TextRenderingHint
         = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                if (Form1.listVertex[i].StartsWith("Bệnh viện"))
                {
                    // Điều chỉnh vị trí của chữ cho các nút là bệnh viện
                    int offsetX = 20; // Khoảng cách theo chiều ngang so với hình ảnh
                    int offsetY = 5;  // Khoảng cách theo chiều dọc so với hình ảnh
                    graphics.DrawString(Form1.listVertex[i], boldFont, Brushes.Black,
                                      zoomedNodePositions[i].X + offsetX, zoomedNodePositions[i].Y + offsetY, stringFormat);
                }
                else
                {
                    // Vẽ tên đường như cũ cho các nút không phải là bệnh viện
                    graphics.DrawString(Form1.listVertex[i], boldFont, Brushes.Black,
                                      zoomedNodePositions[i].X + 10, zoomedNodePositions[i].Y, stringFormat);
                }
            }
            // Vẽ biểu tượng bệnh viện (sử dụng zoomedNodePositions)
            for (int i = 0; i < zoomedNodePositions.Count; i++)
            {
                if (hospitalNodes.Contains(i))
                {
                    graphics.DrawImage(hospitalImage, zoomedNodePositions[i].X - hospitalImage.Width / 2,
                                                     zoomedNodePositions[i].Y - hospitalImage.Height / 2);
                }
            }
        }
        /// <summary>
        /// Hàm này dùng để cập nhật lại thời gian di chuyển cho cung đường tiếp theo
        /// </summary>
        private void UpdateSegmentTime()
        {
            if (currentStep < path.Count - 1)
            {
                try
                {
                    // Lấy trọng số từ ma trận kề (đơn vị mét)
                    float distance = Form1.adjacencyMatrix[path[currentStep], path[currentStep + 1]];

                    // Lấy thời gian hiện tại
                    DateTime currentTime = DateTime.Now;

                    // Tính toán thời gian di chuyển bằng cách sử dụng cả khoảng cách và thời gian hiện tại
                    totalTime = TimeAmbulanceMove.CalculateTravelTime(distance, currentTime);

                    // Nhân totalTime với speedMultiplier
                    totalTime *= speedMultiplier;
                }
                //bắt lỗi
                catch (IndexOutOfRangeException)
                {
                    totalTime = 0;
                }
            }
        }
        /// <summary>
        /// Event cập nhật cho timer dTime
        /// </summary>
        private void dTIME_Tick(object sender, EventArgs e)
        {
            customDateTime = customDateTime.AddMilliseconds(dTIME.Interval * speedMultiplier);
        }
        /// <summary>
        /// Event cập cho timer timer2 , dùng để hiển thị thời gian trong ngày lên lblTime
        /// </summary>
        private void timer2_Tick(object sender, EventArgs e)
        {
            simulationTime = simulationTime.AddMilliseconds(timer2.Interval * speedMultiplier);
            string Dtime = simulationTime.ToString("dd/MM/yyyy HH:mm:ss");
            lblTime.Text = Dtime;
        }
        /// <summary>
        /// Event này cập nhật lại đồ thị khi người dùng tùy chỉnh giữa zoom và toàn cảnh
        /// </summary>
        private void ViewChose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ViewChose.SelectedItem.ToString() == "Zoom")
            {
                pictureBoxZoom.Visible = true;
                pictureBox1.Visible = false; // Ẩn pictureBox1
                pictureBoxAmbulance.Visible = true; // Ẩn xe trong pictureBox1
                pictureBoxAmbulance.Size = new Size(80, 80); // Ví dụ: tăng gấp đôi kích thước

                zoomedBmp = new Bitmap(pictureBoxZoom.Width, pictureBoxZoom.Height);
                using (Graphics g = Graphics.FromImage(zoomedBmp))
                {
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.ScaleTransform(2f, 2f); // Ví dụ: phóng to gấp đôi
                    DrawGraphZoom(g); // Gọi hàm DrawGraphZoom()
                }

                pictureBoxZoom.Image = zoomedBmp; // Hiển thị zoomedBmp trên pictureBoxZoom
                timer2.Start(); // Bắt đầu timer2
            }
            else
            {
                pictureBoxAmbulance.Visible = true; // Hiện xe trong pictureBox1
                pictureBoxAmbulance.Size = new Size(40, 40); // Ví dụ: tăng gấp đôi kích thước

                pictureBox1.Image = bmp; // Hiển thị lại bmp gốc
                pictureBoxZoom.Visible = false; // Ẩn pictureBoxZoom
                pictureBox1.Visible = true; // Hiển thị lại pictureBox1

                timer1.Start(); // Bắt đầu timer1
            }
        }

        /**
  Hàm timer1_Tick được gọi mỗi khi timer1 tick (theo interval đã thiết lập).
  Hàm này xử lý logic di chuyển của xe cứu thương trên bản đồ, 
  bao gồm cập nhật vị trí, tốc độ, thông tin đường đi và chế độ xem.  
  Các bước thực hiện:
  1. Kiểm tra xem xe đã đến đích chưa (currentStep < pathCoordinates.Count - 1).
  2. Nếu chưa đến đích:
     - Nếu t <= 1 (xe vẫn đang di chuyển trên đoạn đường hiện tại):
     - Nếu t >= 1 (xe đã đến cuối đoạn đường hiệ n tại):
  3. Nếu đã đến đích:
     - Dừng timer1, timer2 và dTIME.
     - Hiển thị thông báo "Xe đã tới bệnh viện".
   Ngoài ra nó còn chứa logic gọi lại form115 khi mô phỏng đợt 1 xong. Và có logic thay đổi tốc độ khi di chuyển gần tới đèn đỏ
 */

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine($"{this.Tag} is active");
            this.targetStreetIndex = Form1.testerindex;
            if (currentStep < pathCoordinates.Count - 1)
            {

                // Tính toán thời gian trôi qua
                customDateTime = customDateTime.AddMilliseconds(timer1.Interval * speedMultiplier); // cập nhật customDateTime vớispeedMultiplier 
                //TimeSpan là một kiểu dữ liệu trong .NET Framework đại diện cho một khoảng thời gian
                TimeSpan elapsedTime = customDateTime - segmentStartTime;// tính toán thời gian trôi qua
                elapsedTime = TimeSpan.FromMilliseconds(elapsedTime.TotalMilliseconds * speedMultiplier);
                /*
                 giá trị t là tương quan giữa vị trí xe cứu thương và đoạn đường
                t thuộc [0,1]. Trong đó : 0 đang ở vị trí đầu tiên , 1 là đã đi đến cuối đường
                đoạn giá trị ở giữa tượng trưng cho vị trí tương đối trên đoạn đường
                 */
                t = (float)(elapsedTime.TotalMilliseconds / (totalTime * 1000));
                int currentNode = path[currentStep];
                int nextNode = path[currentStep + 1];

                TrafficLight lightToCheck = null;

                // Kiểm tra xem currentNode hoặc nextNode có phải là đèn đỏ không
                if (nodePositions[currentNode].Type == NodeType.TrafficLight)
                {
                    lightToCheck = trafficLights.Find(l => l.Index == currentNode);
                }
                else if (nodePositions[nextNode].Type == NodeType.TrafficLight)
                {
                    lightToCheck = trafficLights.Find(l => l.Index == nextNode);
                }

                // Nếu tìm thấy đèn đỏ, kiểm tra khoảng cách và điều chỉnh tốc độ
                if (lightToCheck != null)
                {
                    double distanceToNextNode = Form1.adjacencyMatrix[path[currentStep], path[currentStep + 1]];
                    double distanceToLight = distanceToNextNode * (1 - t); // Khoảng cách từ xe đến đèn đỏ

                    if (nodePositions[currentNode].Type == NodeType.TrafficLight)
                    {
                        if (currentStep > 0) // Kiểm tra xem có đỉnh trước đó không
                        {
                            double distanceToPreviousNode = Form1.adjacencyMatrix[path[currentStep - 1], path[currentStep]];
                            distanceToLight = distanceToPreviousNode * t;
                            // Tăng tốc độ khi đi qua đèn đỏ, nhưng không vượt quá tốc độ tối đa
                            currentSpeed = lightToCheck.IncreaseSpeed(distanceToLight, currentSpeed, customDateTime);

                            // random tốc độ cho nó mượt :))
                            double speedChange = random.NextDouble() * 2 - 1;
                            currentSpeed += speedChange;
                            currentSpeed = Math.Max(13, Math.Min(currentSpeed, TimeAmbulanceMove.CurrentSpeed));
                        }
                        else
                        {
                            double speedChange = random.NextDouble() * 2 - 1; // Tạo số ngẫu nhiên trong khoảng -1 đến 1
                            currentSpeed += speedChange; // Thay đổi tốc độ

                            // Giới hạn tốc độ trong khoảng cho phép
                            currentSpeed = Math.Max(13, Math.Min(currentSpeed, TimeAmbulanceMove.CurrentSpeed));
                        }
                    }
                    else if (nodePositions[nextNode].Type == NodeType.TrafficLight)
                    {
                        // Giảm tốc độ nếu nextNode là đèn đỏ và đang đến gần
                        if (distanceToLight < 200)
                        {
                            currentSpeed = lightToCheck.DecreaseSpeed(distanceToLight, currentSpeed, customDateTime);
                        }
                        else if(distanceToLight > 200)
                        {
                            double speedChange = random.NextDouble() * 2 - 1; // Tạo số ngẫu nhiên trong khoảng -1 đến 1
                            currentSpeed += speedChange; // Thay đổi tốc độ

                            // Giới hạn tốc độ trong khoảng cho phép
                            currentSpeed = Math.Max(13, Math.Min(currentSpeed, TimeAmbulanceMove.CurrentSpeed));

                        }
                    }
                }
                else
                {
                    // Nếu không có đèn đỏ gần, duy trì tốc độ hiện tại
                    // Nếu không có đèn đỏ gần, điều chỉnh tốc độ ngẫu nhiên
                    double speedChange = random.NextDouble() * 2 - 1; // Tạo số ngẫu nhiên trong khoảng -1 đến 1
                    currentSpeed += speedChange; // Thay đổi tốc độ

                    // Giới hạn tốc độ trong khoảng cho phép
                    currentSpeed = Math.Max(18, Math.Min(currentSpeed, TimeAmbulanceMove.CurrentSpeed));
                }
                //khi xe chưa đến đích
                if (t <= 1) // Kiểm tra t trước khi cập nhật vị trí
                {
                    // Lấy tọa độ bắt đầu và kết thúc của đoạn đường hiện tại
                    PointF start = pathCoordinates[currentStep];
                    PointF end = pathCoordinates[currentStep + 1];
                    // Tính toán vị trí mới của xe
                    float x = start.X + (end.X - start.X) * t;
                    float y = start.Y + (end.Y - start.Y) * t;
                    // Cập nhật vị trí của xe
                    pictureBoxAmbulance.Location = new Point((int)x, (int)y);

                }
                //khi xe đến cuối đường r
                if (t >= 1)
                {
                    currentStep++; // Chuyển sang điểm tiếp theo
                    t = 0; // Reset t về 0  để bắt đầu 1 đoạn đường mới
                    if (currentStep < path.Count - 1)
                    {
                        // Tính toán lại totalTime cho các đoạn đường còn lại
                        totalTime = 0;
                        float distance = Form1.adjacencyMatrix[path[currentStep], path[currentStep + 1]];
                        totalTime = TimeAmbulanceMove.CalculateTravelTime(distance, customDateTime) * speedMultiplier;
                        segmentStartTime = customDateTime;
                    }   
                }
                //hiển thị thông tin cho lplSpeed
                if (currentStep < path.Count - 2)
                {
                    double distance = Form1.adjacencyMatrix[path[currentStep], path[currentStep + 1]];
                    Font boldFont = new Font("Segoe UI", 13, FontStyle.Bold);
                    lblSpeed.Font = boldFont;
                    //currentSpeed = TimeAmbulanceMove.CurrentSpeed;
                    lblSpeed.Text = $"Tốc độ của xe hiện tại: {currentSpeed:F2} km/h";
                    lblSpeed.Refresh(); // Cập nhật label tốc độ
                }
                // Hiển thị thông tin cung đường tiếp theo + khoảng cách cần tới đuờng đó
                if (currentStep < path.Count - 2)
                {
                    string nextStreetName = Form1.listVertex[path[currentStep + 1]];
                    double initialNextDistance = Form1.adjacencyMatrix[path[currentStep], path[currentStep + 1]];
                    double nextDistance = initialNextDistance * (1 - t);
                    Font boldFont = new Font("Segoe UI", 13, FontStyle.Bold);
                    lblNextRoute.Font = boldFont;
                    lblNextRoute.Text = $"Cung đường tiếp theo: {nextStreetName} (còn {nextDistance:F0} mét)";
                    string currStreetName = Form1.listVertex[path[currentStep]];
                }
                //khi chỉ còn 1 đoạn đường tới bệnh viện :
                else
                {
                    //  currentSpeed = TimeAmbulanceMove.CurrentSpeed;
                    Font boldFont = new Font("Segoe UI", 13, FontStyle.Bold);
                    lblSpeed.Font = boldFont;
                    lblSpeed.Text = $"Tốc độ của xe hiện tại: {currentSpeed:F2} km/h";
                    // Tính toán khoảng cách đến bệnh viện 
                    if (currentStep < path.Count - 1)
                    {
                        double hospitalDistance = Form1.adjacencyMatrix[path[currentStep], path[currentStep + 1]];
                        double finalDistance = hospitalDistance * (1 - t);
                        lblNextRoute.Font = boldFont;
                        lblNextRoute.Text = $"Đang đến đích !! còn : {finalDistance:F0} mét";
                    }
                    else
                    {
                        lblNextRoute.Text = "Xe cứu thương đã đến đích!!";
                    }
                }
                lblNextRoute.Refresh(); // Cập nhật label cung đường
                /*
                Đoạn if này xử lý logic hiển thị bản đồ ở chế độ phóng to (zoom). Khi người dùng chọn chế độ "Zoom"
                */
                if (ViewChose.SelectedItem.ToString() == "Zoom")
                {
                    UpdateAmbulanceLocation_ZoomMode();
                }
                else

                {
                    pictureBox1.Invalidate();
                }
            }
            else
            { // Xe đã đến đích (có thể là con đường tai nạn hoặc bệnh viện chuyên khoa)

                // Dừng timer
                StopAnimation();
                if (currentStep == path.Count - 1 && reachedAccidentLocation == true && !FrmHostoHos.CheckFrm2) 
                {
                    // Xe đã đến đích cuối cùng (bệnh viện) trong chế độ "Cấp cứu 115"
                    // Dừng animation
                    // Hiển thị thời gian di chuyển
                    TimeSpan travelTime = customDateTime - startTime;
                    //string hospitalname = form1.listvertex[path[path.count - 1]];
                    //string message = $"xe đã tới {hospitalname}\nthời gian di chuyển: {traveltime.tostring(@"mm\:ss")}";
                    //messagebox.show(message, "thông báo", messageboxbuttons.ok, messageboxicon.information);
                    ResetSimulationData();
                    FreeDataAmbu();
                    FreeSourceForm115();
                    FrmListView.FreePage(this);
                    this.Close();
                }
                if (currentStep == path.Count - 1 && FrmHostoHos.CheckFrm2)
                {
                    // Xe đã đến đích cuối cùng 

                    // Hiển thị thời gian di chuyển
                    TimeSpan travelTime = customDateTime - startTime;
                    //string hospitalName = Form1.listVertex[path[path.Count - 1]];
                    //string message = $"Xe {this.Tag.ToString()} đã tới {hospitalName}\n" +
                    //                 $"Thời gian di chuyển: {travelTime.ToString(@"mm\:ss")}";
                    //MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset các biến mô phỏng
                    ResetSimulationData();
                    FreeDataAmbu();
                    FinishHostoHos();
                    FrmListView.FreePage(this);
                    this.Close();

                }
                if (reachedAccidentLocation == false && FrmHostoHos.CheckFrm2 == false)
                {
                    this.targetStreetIndex = Form1.testerindex;
                    if (currentStep == targetStreetIndex)
                    {  // Xe đã đến đích tạm thời (con đường tai nạn)         
                       // Hiển thị MessageBox
                        string streetName = "";
                        if (path != null && path.Count > 0)
                        {
                            // Truy cập các phần tử của path
                            streetName = Form1.listVertex[path[currentStep]];
                        }
                        else if (path == null)
                        {
                            // Xử lý trường hợp path là null hoặc rỗng
                            MessageBox.Show("Không tìm thấy đường đi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        ReachedDestination?.Invoke(this, EventArgs.Empty);
                        reachedAccidentLocation = true;
                        MenuMain.Ambu.UpdateLabel();
                        MenuMain.Ambu.AddAmbuToCmbox(this.Tag.ToString());
                        // Hiển thị lại Form1 với ComboBox chọn loại bệnh
                        Form1 frm1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                        if (frm1.Tag.ToString() == this.Tag.ToString())
                        {
                            FrmListView.AddForm115(this, frm1);
                        }
                    }
                  
                }
            }
        }
        /// <summary>
        /// Hàm này cập nhật vị trí của xe cứu thương ở chế độ zoom
        /// </summary>
        void UpdateAmbulanceLocation_ZoomMode()
        {
            // Cập nhật zoomedBmp
            zoomedBmp = new Bitmap(pictureBoxZoom.Width, pictureBoxZoom.Height);
            using (Graphics g = Graphics.FromImage(zoomedBmp))
            {
                //cải thiện chất lượng hình ảnh
                g.SmoothingMode = SmoothingMode.AntiAlias; // bật khử răng cưa
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;//giúp tạo ra hình ảnh mượt mà và sắc nét hơn khi thay đổi kích thước.
                                                                           // Tính toán zoomRect với kích thước bằng 1/4 kích thước pictureBox1
                int zoomWidth = pictureBox1.Width / 4;
                int zoomHeight = pictureBox1.Height / 4;
                // Tính toán tọa độ góc trên bên trái của zoomRect sao cho xe cứu thương nằm ở giữa pictureBoxZoom
                int zoomX = pictureBoxAmbulance.Location.X - zoomWidth / 2;
                int zoomY = pictureBoxAmbulance.Location.Y - zoomHeight / 2;
                // Giới hạn zoomRect để không vượt quá giới hạn của bmp
                zoomX = Math.Max(0, zoomX);
                zoomY = Math.Max(0, zoomY);

                // Đảm bảo zoomWidth không vượt quá giới hạn bên phải của bmp
                zoomWidth = Math.Min(bmp.Width - zoomX, zoomWidth);

                // Đảm bảo zoomHeight không vượt quá giới hạn dưới của bmp
                zoomHeight = Math.Min(bmp.Height - zoomY, zoomHeight);

                // Tạo zoomRect với tọa độ (zoomX, zoomY), chiều rộng zoomWidth và chiều cao zoomHeight
                zoomRect = new Rectangle(zoomX, zoomY, zoomWidth, zoomHeight);

                // Giới hạn zoomRect để không vượt quá giới hạn của bmp
                zoomRect.X = Math.Max(0, zoomRect.X);
                zoomRect.Y = Math.Max(0, zoomRect.Y);
                zoomRect.Width = Math.Min(bmp.Width - zoomRect.X, zoomRect.Width);
                zoomRect.Height = Math.Min(bmp.Height - zoomRect.Y, zoomRect.Height);
                g.DrawImage(bmp, pictureBoxZoom.ClientRectangle, zoomRect, GraphicsUnit.Pixel); // tạo hiệu ứng phóng to vùng bản đồ được chọn.

                // Tính toán vị trí mới của xe cứu thương trên pictureBoxZoom
                float zoomRatioX = (float)pictureBoxZoom.Width / zoomRect.Width;
                float zoomRatioY = (float)pictureBoxZoom.Height / zoomRect.Height;
                Point newAmbulanceLocation = new Point(
                  (int)((pictureBoxAmbulance.Location.X - zoomRect.X) * zoomRatioX) - pictureBoxAmbulance.Width / 2,
                  (int)((pictureBoxAmbulance.Location.Y - zoomRect.Y) * zoomRatioY) - pictureBoxAmbulance.Height / 2
                );

                // Vẽ xe cứu thương lên zoomedBm
                g.DrawImage(pictureBoxAmbulance.Image, new Rectangle(newAmbulanceLocation.X, newAmbulanceLocation.Y, pictureBoxAmbulance.Width, pictureBoxAmbulance.Height));
            }
            // Cập nhật pictureBoxZoom
            pictureBoxZoom.Image = zoomedBmp;
            pictureBoxZoom.Invalidate();
        }
        /// <summary>
        /// Hàm này Reset toàn bộ các biến của Form nhằm mục đích giải phóng tài nguyên
        /// </summary>
        private void ResetSimulationData()
        {
            path = new List<int>();
            pathCoordinates.Clear();
            currentStep = 0;
            t = 0;
            reachedAccidentLocation = false;
            totalTime = 0;
            startTime = DateTime.Now;
            customDateTime = DateTime.Now;
            segmentStartTime = DateTime.Now;
            simulationTime = DateTime.Now;
        }
        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
        /// <summary>
        /// Event này sẽ kiểm tra xem ng dùng có chọn tính năng hiển thị đường không và cập nhật lại
        /// </summary>
        private void timerFlash_Tick(object sender, EventArgs e)
        {
            if (isFadingOut)
            {
                alpha -= 0.1f; // Giảm độ trong suốt
                if (alpha <= 0f)
                {
                    alpha = 0f;
                    isFadingOut = false; // Chuyển sang giai đoạn hiện dần
                }
            }
            else
            {
                alpha += 0.1f; // Tăng độ trong suốt
                if (alpha >= 1f)
                {
                    alpha = 1f;
                    isFadingOut = true; // Chuyển sang giai đoạn mờ dần
                }
            }
            // Vẽ lại đồ thị cho chế độ toàn cảnh
            DrawGraph();
            pictureBox1.Image = bmp; // Cập nhật pictureBox1

        }
        /// <summary>
        /// Hàm này có chức năng kiểm tra xem checkbox có được check hay không để hiển thị đường đi
        /// </summary>
        private void flashingCheck_ToggleStateChanged(object sender, EventArgs args)
        {
   
            if (checkBox1.Checked)
            {
                isFlashing = true;
            }
            else
            {
                isFlashing = false;
            }

            // Gọi lại  vẽ đồ thị để cập nhật hiệu ứng nhấp nháy
            DrawGraph();

        }
        /// <summary>
        /// Hàm này cập nhạt lại đường đi, phục vụ cho tính năng cấp cứu 115
        /// </summary>
        /// <param name="newPath">Đường đi mới</param>
        public void UpdatePath(List<int> newPath)
        {
            path = newPath;
            pathCoordinates.Clear(); // Xóa đường đi cũ
            foreach (int nodeIndex in path)
            {
                pathCoordinates.Add(nodePositions[nodeIndex].Location);
            }

            currentStep = 0; // Reset currentStep
            t = 0; // Reset t
            segmentStartTime = customDateTime; // Reset segmentStartTime
            UpdateSegmentTime(); // Cập nhật totalTime
        }
        /// <summary>
        /// Hàm này bắt đầu lại các bộ đếm thời gian
        /// </summary>
        public void StartAnimation()
        {
            timer1.Start(); 
            timer2.Start(); 
            dTIME.Start();
            TimerFlashing.Start();
        }
        /// <summary>
        /// Hàm này tạm dừng các bộ đếm thời gian
        /// </summary>
        public void StopAnimation()
        {
            timer1.Stop();
            timer2.Stop();
            dTIME.Stop();
            TimerFlashing.Stop();
        }
        /// <summary>
        /// Kích hoạt tính năng pause mô phỏng khi ấn nút space
        /// </summary>
        private void PasueAnimation(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.G)
            {
                if (timer1.Enabled) // Kiểm tra nếu animation đang chạy
                {

                    StopAnimation();
                }
                else
                {
                    StartAnimation(); // Khởi động lại animation
                }
            }
        }
        /// <summary>
        /// Thay đổi "độ trôi thời gian" khi người dùng kéo thanh trackbar
        /// </summary>
        private void TimeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            speedMultiplier = (int)trackbar.Value;
            // Tính toán lại thời gian đã trôi qua
            TimeSpan elapsedTime = customDateTime - segmentStartTime;

            // Cập nhật tổng thời gian di chuyển
            UpdateSegmentTime();

            // Tính toán lại tỷ lệ thời gian
            t = (float)(elapsedTime.TotalMilliseconds / (totalTime * 1000));

            // Cập nhật vị trí xe
            timer1_Tick(sender, e);
        }
        /// <summary> Xóa data sau khi xe cứu thương đã hoàn thành nhiệm vụ
        /// <para>
        /// Hàm này được dùng để xóa database dựa trên tag của formview sau khi finish mission
        /// </para>
        /// </summary>
        private void FreeDataAmbu()
        {
            string id = this.Tag.ToString();
            AmbulanceMission ambumiss = DatabaseQuanLy.Instance.AmbulanceMissions.Where(p => p.AmbulanceId == id).SingleOrDefault();
            if(ambumiss == null)
            {
                MessageBox.Show("Lỗi ko có data ambu" , "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Ambulance ambu = DatabaseQuanLy.Instance.Ambulances.Where(p => p.AmbulanceId == id).SingleOrDefault();
            if (ambu == null)
            {
                MessageBox.Show("Lỗi ko có data ambu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ambu != null)
            {
                ambu.Đang_Hoạt_Động = false;
                DatabaseQuanLy.Instance.SubmitChanges();
            }
            if (ambumiss != null) {
                DatabaseQuanLy.Instance.AmbulanceMissions.DeleteOnSubmit(ambumiss);
                DatabaseQuanLy.Instance.SubmitChanges();
                MenuMain.Ambu.RefreshDataGridView();
            }
        }
        /// <summary> Hàm này dùng để cập nhật data của Patient sau khi tới bệnh viện dc chuyển tuyến
        /// <para>
        ///
        /// </para>
        /// </summary>
        private void FinishHostoHos()
        {
            Patient pt = DatabaseQuanLy.Instance.Patients.Where(p => p.PatientId.ToString() == PatienId).SingleOrDefault();
            if (pt == null)
            {
                MessageBox.Show("FormView ko tim thay pt!!!", "Thông báo", MessageBoxButtons.OK);
                return;//ném ngoại lệ
            }
            else
            {
                pt.Status = "Đang điều trị";
                int hosid = HosToId.ToInt();
                pt.HospitalID = hosid;
                DatabaseQuanLy.Instance.SubmitChanges();
            }
        }
        /// <summary> Xóa data sau khi xe cứu thương đã hoàn thành nhiệm vụ
        /// <para>
        /// Hàm này được dùng để chỉnh sửa database trong gridview ở MenuMain nhằm mục đích hiển thị đường đi hieện tại
        /// </para>
        /// </summary>
        private void UpdateDataLocation(string location)
        {
            string id = this.Tag.ToString();
            AmbulanceMission ambumiss = DatabaseQuanLy.Instance.AmbulanceMissions.Where(p => p.AmbulanceId == id).SingleOrDefault();
         
            if (ambumiss != null)
            {
                ambumiss.Vị_Trí_Hiện_Tại = location;
                DatabaseQuanLy.Instance.SubmitChanges();
                MenuMain.Ambu.RefreshDataGridView();
            }
        }
        /// <summary>
        /// Hàm này cập nhật cơ sở dữ liệu ở Menu, hiển thị đường đi hiện tại của xe
        /// </summary>

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            string Curr = lblNextRoute.Text;
            UpdateDataLocation(Curr);
        }
        /// <summary>
        /// Hàm giải phóng toàn bộ tài nguyên của Form115
        /// </summary>
        private void FreeSourceForm115()
        {
            Form1 frm1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if(frm1.Tag.ToString() == this.Tag.ToString())
            {
                frm1.Close();
            }

        }
        /// <summary>
        /// Quay lại Menu
        /// </summary>
        private void btbBack_Click(object sender, EventArgs e)
        {
            MenuMain.frmlist.WindowState = FormWindowState.Minimized;
            MenuMain.mn.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StopAnimation();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartAnimation();
        }
    }
}
