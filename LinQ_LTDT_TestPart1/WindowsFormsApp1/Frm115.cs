using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.ComponentModel;
using iText.IO.Font.Otf.Lookuptype7;
using ServiceStack;
using WindowsFormsApp1.QuanLy_Ambulance;
namespace WindowsFormsApp1
{
    /*
     
     */
        public partial class Form1 : Telerik.WinControls.UI.RadForm
        {
        // ma trận
        private string accidentLocation; // biến lưu vị trí gây tai nạn.
        private Dijkstra dijkstra; // Khai báo biến dijkstra
        private List<int> hospitalNodes = new List<int>() { 0, 1, 6, 7, 9, 14, 15, 16, 17, 18, 19, 20, 26 }; //danh sách các đỉnh là bệnh viện
        private FormView currentFormView; // Biến để lưu FormView hiện tại
        private Astar astar;
        public static int testerindex;
        private string AlgorithmType = MenuMain.AlgrType;
        private DataClasses1DataContext db;
        //Ma trận của đề tài
        public static int[,] adjacencyMatrix = new int[,] {
            //đơn vị : mét - đồ thị vô hướng  a->b , b->a
    //        0   1   2   3   4    5   6   7   8    9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45
    /* 0 */ { 0,  0,  100,0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //bệnh viện phạm ngọc thạch
    /* 1 */ { 0,  0,  100,0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //bệnh viện ĐH Y Dược
    /* 2 */ {100,100,0,2000,2400,400,  0,  0,  0,   0,  0,1000, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,3500, 0, 0,100,0,400,0,999, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đường Hồng Bàng
    /* 3 */ { 0,  0,  2400,0,  0,   0, 0, 0,   0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,1200, 0,  0,  0,  0,  0, 0, 0, 0, 0, 0,999,399, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đường Hùng Vương
        //    0   1   2   3   4    5   6   7   8    9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45
    /* 4 */ { 0,  0,2400, 0,  0,   0,  0,  0,  0,   0, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0,2400, 0, 0,2000,1399, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đường An Dương Vương
    /* 5 */ { 0,  0,400,  0,  0,   0,  0,700,800,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0,0,399, 0, 0, 349, 0, 0, 0, 0, 0, 0, 0 }, //Đường Ngô Quyền
    /* 6 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 1400, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Bệnh viện răng hàm mặt
    /* 7 */ { 0,  0,  0,  0,  0,   700,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,349, 0, 0, 0, 0, 0, 0, 0 }, //Bệnh viện Chợ rẫy
    /* 8 */ { 0,  0,  0,  0,  0, 800,  0,  0,  0,1100,900, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,1300,3000, 0, 0,  0, 0, 0, 0, 0, 0, 0, 0,399,599,1499,0, 0, 0, 0, 0, 0, 0, 0 }, //Đường 3/2
    /* 9 */ { 0,  0,  0,  0,  0,   0,  0,  0, 1100,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 ,  0,  0,  0,  0,  0,  0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //Bệnh viện nhi đồng 1
    /*10 */ { 0,  0,  0,  0,  0,   0,  0,  0,900,   0,  0,1000, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  550,  0,  0,  0,  0, 0, 0,0, 0, 0, 0, 0, 0, 0,299, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Ngã 6 Nguyễn Tri Phương
    /*11 */ { 0,  0,  1000,  0,  0,   0,  0,  0,  0,   0,  1000, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đường Ngô gia tự
    /*12 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  100,  0,  0,  0,  0,  0,  0,  0,  0,  550,  0,  0,  0,  0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Ngã 7 lý thái tổ
    /*13 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,100,  0,1000,1500,0,  0,  0,  0,  0,1100, 0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0,549, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Đường điện biên phủ
    /*14 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  1000,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //Bệnh viện Bình Dân
    /*15 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  1500,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Bệnh viện mắt
    /*16 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  350,  0,  0,  0,  0,  0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Bệnh viện da liễu
    /*17 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  850,  0,  0,  0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Bệnh viện quận 10
    /*18 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  800,  0,  0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Bệnh viên quận 3
    /*19 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 1000/*25*/,  0, 0, 0,900, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //Bệnh viện quận 6
    /*20 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 450,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },// Bệnh viện quận 5
    /*21*/  { 0,  0,  0, 1200,0,   0,  0,  0,  0,   0,  0,  0,  0,1100, 0,  0,  350,  0,  0,  0, 0,  0,  0,  0,  0, 0,  0, 0, 0, 0, 0, 0, 0,799,549,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Đường Cách mạng tháng 8
    /*22 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  550,  0,  550,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Ngô Gia Tự nối Ngã 6 và Ngã 7
    /*23 */ { 0,  0,  0,  0,  0,   0,  0,  0,  1300,   0,  0,  0,  0,  0,  0,  0,  0,  850,  0,  0,  0,  0, 0,   0,  0,  0,  0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Đường Sư Vạn Hạnh
    /*24 */ { 0,  0,  0,  0,  0,   0,  0,  0,3000, 0,  0,  0,  0,  0,  0,  0,  0,  0, 800,  0,  0,  0,  0,  0,  0,  0,  800, 0, 0,0, 0, 0, 0, 0, 0, 0,0,1499,0, 0, 0, 0, 0, 0, 0, 0 }, // Đường Lý Chính Thắng
    /*25 */ { 0,  0,3500, 0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,1000, 0,  0,  0,  0,  0,  0,  0, 0, 0, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Đường Nguyễn Văn Luông
    /*26 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,800,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },  // Bệnh viện Tai Mũi Họng
    /*27 */ { 0,  0,  0,  0,2400,   0,1400,0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0,  1000, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },  // Đường Nguyễn Văn Cừ
    /*28 */ { 0,  0,100,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,450,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // Đường Ngô Quyền nối dài
    //        0   1   2   3   4    5   6   7   8    9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45
    /*29 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,499,  0,  0,  0,  0,  0,499,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đèn đỏ bệnh viện quận 6 - Nguyễn Văn Luông 1/9
    /*30 */ { 0,  0,399,  0,1999,  0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đèn đỏ hồng bàng - An dương vương 1/5 
    /*31 */ { 0,  0,  0,  0,1399,  0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,999,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đèn đỏ An Dương Vương - Nguyễn Văn Cừ 1/5
    /*32 */ { 0,  0,999,999,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đèn đỏ Hồng Bàng - Hùng Vương
    /*33 */ { 0,  0,  0,399,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,799,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đèn đỏ Hùng Vương - Cách mạng Tháng 8
    /*34 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,549,  0,  0,  0,  0,  0,  0,  0,549,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đèn đỏ Điện Biên  Phủ - Cách mạng Tháng 8
    /*35 */ { 0,  0,  0,  0,  0, 399,  0,  0,399,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đèn đỏ Ngô Quyền - 3/2
    /*36 */ { 0,  0,  0,  0,  0,   0,  0,  0,  599, 0,299,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đèn đỏ 3/2 - NGã 6 Nguyễn Tri Phương
    /*37 */ { 0,  0,  0,  0,  0,   0,  0,  0,1499,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,1499,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đèn đỏ 3/2 - Lý Chính Thắng
    /*38 */ { 0,  0,  0,  0,  0, 349,  0,349,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //Đèn đỏ Ngô Quyền -  Chợ rẫy
    /*39 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    /*40 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    /*41 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    /*42 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    /*43 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    /*45 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    /*44 */ { 0,  0,  0,  0,  0,   0,  0,  0,  0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};
        //Khai báo danh sách trafficLights
        internal static List<TrafficLight> trafficLights = new List<TrafficLight>()
        {
            new TrafficLight(29, 19, 25,500, new System.Drawing.Point(0, 0)),
            new TrafficLight(30, 2, 4, 400, new System.Drawing.Point(0,0)),
            new TrafficLight(31,4,27,1400,new System.Drawing.Point(0,0)),
            new TrafficLight(32,2,3,999,new System.Drawing.Point(0,0)),
            new TrafficLight(33,3,21,399,new System.Drawing.Point(0,0)),
            new TrafficLight(34,13,21,549,new System.Drawing.Point(0,0)),
            new TrafficLight(35,5,8,399,new System.Drawing.Point(0,0)),
            new TrafficLight(36,8,10,599,new System.Drawing.Point(0,0)),
            new TrafficLight(37,8,24,1499,new System.Drawing.Point(0,0)),
            new TrafficLight(38,5,7,349,new System.Drawing.Point(0,0)),
        };

        //danh sách các đỉnh ( đường và bệnh viện )
        public static List<string> listVertex = new List<string>()
{
        "Bệnh viện Phạm Ngọc Thạch", // 0
        "Bệnh viện Đại học Y Dược",     // 1
        "Đường Hồng Bàng",         // 2
        "Đường Hùng Vương",         // 3
        "Đường An Dương Vương",     // 4
        "Đường Ngô Quyền",         // 5
        "Bệnh viện Răng hàm mặt",   // 6
        "Bệnh viện Chợ rẫy",       // 7
        "Đường 3/2",               // 8
        "Bệnh viện Nhi đồng 1",     // 9
        "Ngã 6 Nguyễn Tri Phương", // 10
        "Đường Ngô gia tự",         // 11
        "Ngã 7 Lý Thái Tổ",         // 12
        "Đường Điện Biên Phủ",     // 13
        "Bệnh viện Bình Dân",       // 14
        "Bệnh viện Mắt",           // 15
        "Bệnh viện Da Liễu",       // 16
        "Bệnh viện Quận 10",       // 17
        "Bệnh viện Quận 3",         // 18
        "Bệnh viện Quận 6",         // 19
        "Bệnh viện Quận 5",         // 20
        "Đường Cách mạng tháng 8",   // 21
        "Ngô Gia Tự nối Ngã 6 và Ngã 7", // 22
        "Đường Sư Vạn Hạnh",       // 23
        "Đường Lý Chính Thắng",     // 24
        "Đường nguyễn văn Luông",   // 25
        "Bệnh viện Tai Mũi Họng",   // 26
        "Đường Nguyễn Văn Cừ",      //27
        "Đường Ngô Quyền nối dài", //28
    "Đèn đỏ bệnh viện quận 6 - Nguyễn Văn Luông", //29
    "Đèn đỏ hồng bàng - An dương vương",// 30
    "Đèn đỏ An Dương Vương - Nguyễn Văn Cừ", //31
    "Đèn đỏ Hồng Bàng - Hùng Vương", //32
    "Đèn đỏ Hùng Vương - Cách Mạng Tháng 8", //33
    "Đèn đỏ Điện Biên Phủ - Cách mạng tháng 8", //34
    "Đèn đỏ Ngô Quyền - 3/2" ,//35 
    "Đèn đỏ 3/2 - Ngã 6 Nguyễn Tri Phương", //36
    "Đèn đỏ 3/2 - Lý Chính Thắng", // 37
    "Đèn đỏ Ngô Quyền - Chợ rẫy", //38
};
        public static int GetStreetNamesCount()
        {
            return listVertex.Count;
        }
        //chuyên khoa của các bệnh viện ( ưu tiên tới )
        private Dictionary<string, string> diseaseHospitalMap = new Dictionary<string, string>()
    {
        {"Tim mạch", "Bệnh viện Phạm Ngọc Thạch"},
        {"Đa chấn thương mức độ trung bình", "Bệnh viện Đại học Y Dược"},
        {"Các chấn thương về vùng mặt", "Bệnh viện Răng hàm mặt"},
        {"Đa chấn thương mức độ nặng", "Bệnh viện Chợ rẫy"},
        {"Nhi khoa", "Bệnh viện Nhi đồng 1"},
        {"Tiêu hóa, tiết niệu", "Bệnh viện Bình Dân"},
        {"Mắt", "Bệnh viện Mắt"},
        {"Da liễu", "Bệnh viện Da Liễu"},
        {"Truyền nhiễm", "Bệnh viện Quận 10"},
        {"Sản - phụ khoa", "Bệnh viện Quận 3"},
        {"Nhi khoa - Quận 6", "Bệnh viện Quận 6"}, 
        {"Cấp cứu", "Bệnh viện Quận 5"}
    };
        //danh scah1 bệnh viện ứng với ID trong databse
        public static  Dictionary<string , int> HospitalId = new Dictionary<string, int>()
        {
         {"Bệnh viện Phạm Ngọc Thạch",120},
        {"Bệnh viện Đại học Y Dược",215},
        {"Bệnh viện Răng hàm mặt",263},
        {"Bệnh viện Chợ rẫy",201},
        {"Bệnh viện Nhi đồng 1",341},
        {"Bệnh viện Bình Dân",371},
        {"Bệnh viện Mắt",280},
        {"Bệnh viện Da Liễu",751},
        {"Bệnh viện Quận 10",571},
        {"Bệnh viện Quận 3",114},
       { "Bệnh viện Quận 6",211},
        {"Bệnh viện Quận 5",642},
        {"Bệnh viện Tai Mũi Họng",155}

        };
        //getter lấy tên các bệnh viện
        public static List<string> GetHospitalNames()
        {
            List<string> hospitalNames = new List<string>();
            foreach (string name in listVertex)
            {
                if (name.StartsWith("Bệnh viện")) // Kiểm tra xem có phải bệnh viện không
                {
                    hospitalNames.Add(name);
                }
            }
            return hospitalNames;
        }
        
        public Form1()
            {

            InitializeComponent();
            db = new DataClasses1DataContext();
            string img = Path.Combine(Application.StartupPath, "EmercengyBUtton.gif");

            EmercengyButton.Image = Image.FromFile(img);
            txtHint.Visible = false; //ẩn txthint đi, sẽ gọi lại ở event rê chuột gần BtbEmercengy
            this.FormElement.Border.ForeColor = System.Drawing.Color.White; //xóa viền
            dijkstra = new Dijkstra(listVertex.Count); //khởi tạo biến Dijkstra để phục vụ cho việc sử dụng dijkstra
            for (int i = 0; i < listVertex.Count; i++)
            {
                for (int j = 0; j < listVertex.Count; j++)
                {
                    if (adjacencyMatrix[i, j] != 0)
                    {
                        dijkstra.AddEdge(i, j, adjacencyMatrix[i, j]); // Thêm cạnh vào Dijkstra với trọng số từ ma trận
                    }
                }
            }
            double[] heuristics = new double[listVertex.Count]; // Khởi tạo mảng heuristics với kích thước bằng số lượng nút
            for (int i = 0; i < listVertex.Count; i++)
            {
                heuristics[i] = 0;  //do không có heuristics nên gán = 0
            }

            astar = new Astar(listVertex.Count, heuristics); // Khởi tạo astar với heuristic
            for (int i = 0; i < listVertex.Count; i++)
            {
                for (int j = 0; j < listVertex.Count; j++)
                {
                    if (adjacencyMatrix[i, j] != 0)
                    {
                        astar.AddEdge(i, j, adjacencyMatrix[i, j]); // Thêm cạnh vào Astar với trọng số từma trận
                    }
                }
            }
            this.cmbDiseaseType.Visible = false;
            EmercengyButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
            {
            // Cài đặt văn bản mặc định cho TextBox (txtStreetName)
            txtStreetName.Text = "Hãy chọn tên đường xe cứu thương đang ở";
            txtStreetName.ForeColor = System.Drawing.Color.Gray;
            cmbDiseaseType.Visible = false; 
            // Thêm các loại bệnh vào ComboBox
            // Thêm các loại bệnh từ diseaseHospitalMap
            foreach (string disease in diseaseHospitalMap.Keys)
            {
                cmbDiseaseType.Items.Add(disease);
            }

            cmbDiseaseType.Items.Insert(0, "Hãy chọn loại bệnh mà nạn nhân gặp phải"); //item mặc định hiển thị cho ng dùng
            cmbDiseaseType.SelectedIndex = 0; // Chọn item   mặc định
                                              // Gợi ý tên đường khi nhập 1 vài từ ngữ đầu của nó
                                              // Gợi ý tên đường
            AutoCompleteStringCollection streetAutoComplete = new AutoCompleteStringCollection();
            streetAutoComplete.AddRange(listVertex.ToArray());
            txtStreetName.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Hoặc thử SuggestAppend/Append
            txtStreetName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtStreetName.AutoCompleteCustomSource = streetAutoComplete;

        
            // Ẩn ComboBox chọn loại bệnh khi mới load ( nhập tên đường xong mới hiện )
            cmbDiseaseType.Visible = false;
            // Sự kiện khi TextBox được chọn -> bỏ cái text mặc định và để ng dùng nhập
            txtStreetName.Enter += (txtsender, esen) =>
                {
                    if (txtStreetName.Text == "Hãy chọn tên đường xe cứu thương đang ở")
                    {
                        txtStreetName.Text = "";
                        txtStreetName.ForeColor = System.Drawing.Color.Black;
                    }
                };

            // Sự kiện khi TextBox mất focus ( nếu ng dùng ko chịu nhập )
            txtStreetName.Leave += (txten, txte) =>
                {
                    if (string.IsNullOrWhiteSpace(txtStreetName.Text))
                    {
                        txtStreetName.Text = "Hãy chọn tên đường xe cứu thương đang ở";
                        txtStreetName.ForeColor = System.Drawing.Color.Gray;
                    }
                };     
            }
        
        //sự kiện khi ấn vào button bắt đầu
        private void btnRun_Click(object sender, EventArgs e)
        {
            string streetName = txtStreetName.Text;

            // Kiểm tra xem người dùng đã chọn tên đường chưa
            if (string.IsNullOrWhiteSpace(streetName) || streetName == "Hãy chọn tên đường xe cứu thương đang ở")
            {
                MessageBox.Show("Vui lòng chọn tên đường nơi xảy ra tai nạn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm bệnh viện gần nhất với vị trí tai nạn
            int nearestHospitalIndex = FindNearestHospital(streetName);
            string NameHos = listVertex[nearestHospitalIndex];
            int RanId = PickRandomAmbu(NameHos);
            AdjustmentDataAmbu(NameHos,RanId);
            // Kiểm tra xem có tìm thấy bệnh viện gần nhất không
        if (nearestHospitalIndex == -1)
            {
                MessageBox.Show("Không tìm thấy bệnh viện gần nhất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lưu vị trí tai nạn
            accidentLocation = streetName;

            // Khởi tạo FormView với đường đi từ bệnh viện gần nhất đến vị trí tai nạn
            //tìm đường đi đến vị trí bị tai nạn
            List<int> pathToAccident = FindShortestPath(NameHos, streetName);
            // Kiểm tra xem có tìm thấy đường đi đến vị trí tai nạn không
            if (pathToAccident.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đường đi đến vị trí tai nạn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           // Lấy chỉ số của con đường tai nạn
            int targetStreetIndex = pathToAccident.Count - 1;
            testerindex = targetStreetIndex;
            // Khởi tạo FormView và truyền dữ liệu
            if (currentFormView == null || currentFormView.IsDisposed)
            {   
                // Khởi tạo FormView và truyền dữ liệu
                currentFormView = new FormView(pathToAccident, 1, accidentLocation,targetStreetIndex,RanId);
                currentFormView.ReachedDestination += FormView_ReachedDestination; // Đăng ký event
                currentFormView.Show();
                this.Hide();
            }
            else
            {
                //nếu formview đã tồn tại
               // currentFormView.Show();
                this.Hide();

            }
        }
        private int PickRandomAmbu(string HospitalStart)
        {
            if (HospitalStart == null) { MessageBox.Show("Error PickrandomAmbu", "Thông báo", MessageBoxButtons.OK); }// ném ngooại lệ
            //lấy HospitalId từ string truyen62 vào
            int HospStartId = HospitalId[HospitalStart];
            List<string> danhsachId = db.Ambulances
                .Where(ambulance => ambulance.AmbulanceLocation == HospStartId)
                .Where(ambulance => ambulance.Đang_Hoạt_Động == false)
                .Select(ambulance => ambulance.AmbulanceId).ToList();
            Random random = new Random();
            int IndexAmbuId = random.Next(danhsachId.Count);
            int AmbuId_Random = danhsachId[IndexAmbuId].ToInt(); // convert về int
            return AmbuId_Random;
        }
        private void AdjustmentDataAmbu(string HospitalStart, int AmbuId)
        {        
            Ambulance ambu = db.Ambulances.FirstOrDefault(ab => ab.AmbulanceId == AmbuId.ToString());//lấy ra infor
            if (ambu != null)
            {
                ambu.Đang_Hoạt_Động = true;
            }
            db.SubmitChanges();
            AmbulanceMission ambumiss = new AmbulanceMission();
            ambumiss.AmbulanceId = ambu.AmbulanceId;
            ambumiss.AmbulanceName = ambu.AmbulanceName;
            ambumiss.MissionType = "115";
            db.AmbulanceMissions.InsertOnSubmit(ambumiss);
            db.SubmitChanges();
            FrmAmbu frmAmbu = Application.OpenForms.OfType<FrmAmbu>().FirstOrDefault();
            if (frmAmbu != null)
            {
                frmAmbu.RefreshDataGridView();
            }
        }
        //khi đóng form1 sẽ hiển thị lại MenuMain
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing|| e.CloseReason == CloseReason.None && currentFormView == null)
            //{
            //    // Kiểm tra xem FormView có đang tồn tại không
            //    if (currentFormView != null && !currentFormView.IsDisposed)
            //    {
            //        // Nếu FormView đang tồn tại, ngăn chặn việc đóng Form1
            //        e.Cancel = true;
            //    }
            //    else
            //    {
            //        //// Nếu FormView không tồn tại, cho phép đóng Form1 và hiển thị MenuMain
            //        //MenuMain menumain = Application.OpenForms.OfType<MenuMain>().FirstOrDefault();

            //        //if (menumain != null)
            //        //{
            //        //    menumain.Show();
            //        //    menumain.BringToFront();
            //        //}
            //        //else
            //        //{
            //        //    menumain = new MenuMain();
            //        //    menumain.Show();
            //        //}
            //    }
            //}
        }
        private void Emercengy_MouseHover(object sender, EventArgs e)
        {
            // Lấy vị trí con trỏ chuột
            System.Drawing.Point mousePosition = Cursor.Position;

            // Đặt vị trí cho TextBox (ví dụ: lệch xuống dưới và sang phải so với con trỏ chuột)
            txtHint.Location = new System.Drawing.Point(mousePosition.X + 10, mousePosition.Y + 20);

            // Thiết lập nội dung cho TextBox
            txtHint.Text = "Tình huống khẩn cấp!! Điều xe cứu thương tới bệnh viện gần nhất có thể!";

            // Hiển thị TextBox
            txtHint.Visible = true;
        }
        private void Emercengy_MouseLeave(object sender, EventArgs e)
        {
            // Ẩn TextBox
            txtHint.Visible = false;
        }
        //Hàm hiện lại những button,Combo box cần thiết cho mô phỏng đợt 2
        public void EnableDiseaseSelection(FormView formView)
        {
            currentFormView = formView; // Lưu FormView
            cmbDiseaseType.Visible = true; // Hiển thị ComboBox chọn loại bệnh
            txtStreetName.Enabled = false; // Khóa nhập tên đường
            EmercengyButton.Enabled = true; // Cho phép nhấn nút "Bắt đầu"
            EmercengyButton.Visible = true;
        }
        //tạo một event hco btbRun click ở đợt mô phỏng 2
        private void btbRunReached_Click(object sender , EventArgs e)
        {
            string diseaseType = cmbDiseaseType.SelectedItem?.ToString();

            // Kiểm tra xem người dùng đã chọn loại bệnh chưa
            if (string.IsNullOrEmpty(diseaseType) || diseaseType == "Hãy chọn loại bệnh mà nạn nhân gặp phải")
            {
                MessageBox.Show("Vui lòng chọn loại bệnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm bệnh viện chuyên khoa
            string targetHospital = diseaseHospitalMap.ContainsKey(diseaseType) ? diseaseHospitalMap[diseaseType] : null;
            if (targetHospital == null)
            {
                MessageBox.Show("Không tìm thấy bệnh viện chuyên khoa cho loại bệnh này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tính toán đường đi từ vị tr  í tai nạn đến bệnh viện chuyên khoa
            int startIndex = listVertex.IndexOf(accidentLocation);
            int endIndex = listVertex.IndexOf(targetHospital);
            List<int> pathToHospital = FindShortestPath(startIndex, endIndex);

            // Kiểm tra xem có tìm thấy đường đi đến bệnh viện chuyên khoa không
            if (pathToHospital.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đường đi đến bệnh viện chuyên khoa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật đường đi và bắt đầu lại animation trong FormView
            FormView formView = (FormView)sender; // Lấy FormView từ sender
            formView.UpdatePath(pathToHospital);
            formView.StartAnimation();
            Form1 frm1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (frm1 != null)
            {
                frm1.Close();
            }
            this.Hide(); // Ẩn Form115 sau khi bắt đầu di chuyển đến bệnh viện chuyên khoa
        }
        //khi xe cứu thương đến vị trí tai nạn thì gọi Event này
        private void FormView_ReachedDestination(object sender, EventArgs e)
        {
            this.Show(); // Hiển thị Form115
            this.BringToFront(); // Đưa Form115 lên trên cùng
            cmbDiseaseType.Visible = true; // Hiển thị ComboBox chọn loại bệnh
            txtStreetName.Enabled = false; // Khóa nhập tên đường

            // Xử lý sự kiện nút "Bắt đầu" sau khi người dùng chọn bệnh
            EmercengyButton.Click -= btnRun_Click;  // Gỡ sự kiện cũ
            EmercengyButton.Click += btbRunReached_Click; //thay thế bằng event mới
           
        }
        //sử lý sự kiện khi click vào nút khẩn cấp
        private void EmergencyButton_Click(object sender, EventArgs e)
        {
            string currentStreet = accidentLocation;
            int nearHospitalIndex = FindNearestHospital(currentStreet);
            //check lỗi...
            if (nearHospitalIndex == -1)
            {
                MessageBox.Show("Không tìm thấy bệnh viện gần nhất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<int> pathToHospital = FindShortestPath(currentStreet, listVertex[nearHospitalIndex]);
            // Kiểm tra xem có tìm thấy đường đi đến bệnh viện không
            //check lỗi...
            if (pathToHospital.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đường đi đến bệnh viện.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật đường đi trong FormView
            if (currentFormView != null && !currentFormView.IsDisposed)
            {
                currentFormView.UpdatePath(pathToHospital);
                currentFormView.StartAnimation(); 
                this.Hide(); 
            }
        }
        // Tìm bệnh viện gần nhất từ một địa điểm cho trước
        private int FindNearestHospital(string streetName)
        {
            // Tìm chỉ số của đường trong danh sách đỉnh
            int startIndex = listVertex.IndexOf(streetName);
            string algorithmType = this.AlgorithmType;

            // Khởi tạo biến lưu trữ chỉ số bệnh viện gần nhất và khoảng cách tối thiểu
            int nearestHospitalIndex = -1;
            double minDistance = double.MaxValue;

            // Duyệt qua danh sách các nút bệnh viện
            foreach (int hospitalIndex in hospitalNodes)
            {
                List<int> path = null;

                // Tìm đường đi ngắn nhất đến bệnh viện hiện tại bằng thuật toán A* hoặc Dijkstra
                if (algorithmType == "A*")
                {
                    path = astar.FindPath(startIndex, hospitalIndex);
                }
                else if (algorithmType == "Dijkstra")
                {
                    path = dijkstra.DijkstraWithPath(startIndex, hospitalIndex);
                }

                // Nếu tìm thấy đường đi
                if (path != null && path.Count > 0)
                {
                    double distance = 0;

                    // Tính tổng khoảng cách của đường đi
                    for (int i = 0; i < path.Count - 1; i++)
                    {
                        distance += adjacencyMatrix[path[i], path[i + 1]];
                    }

                    // Nếu khoảng cách đến bệnh viện hiện tại nhỏ hơn khoảng cách tối thiểu hiện tại
                    if (distance < minDistance)
                    {
                        // Cập nhật khoảng cách tối thiểu và chỉ số bệnh viện gần nhất
                        minDistance = distance;
                        nearestHospitalIndex = hospitalIndex;
                    }
                }
            }

            // Trả về chỉ số của bệnh viện gần nhất
            return nearestHospitalIndex;
        }
        private List<int> FindShortestPath(string startStreet, string endStreet)
        {
            // Tìm chỉ số của đường trong danh sách đỉnh
            int startIndex = listVertex.IndexOf(startStreet);
            int endIndex = listVertex.IndexOf(endStreet);
            string algorithmType = this.AlgorithmType;
            List<int> shortestPath = null; //khởi tạo path
            
            if (algorithmType == "A*")
            {
                shortestPath = astar.FindPath(startIndex, endIndex);
            }
            else if (algorithmType == "Dijkstra")
            {
                shortestPath = dijkstra.DijkstraWithPath(startIndex, endIndex);
            }

            return shortestPath;
        }
        //nạp chồng hàm với 2 para kiểu int
        private List<int> FindShortestPath(int startIndex, int endIndex)
        {
            List<int> shortestPath = null;
            string algorithmType = this.AlgorithmType;
            // Tìm đường đi ngắn nhất đến bệnh viện hiện tại bằng thuật toán A* hoặc Dijkstra
            if (algorithmType == "A*")
            {
                shortestPath = astar.FindPath(startIndex, endIndex);
            }
            else if (algorithmType == "Dijkstra")
            {
                shortestPath = dijkstra.DijkstraWithPath(startIndex, endIndex);
            }

            return shortestPath;
        }
    }
}

