using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinForms.Documents.FormatProviders.Html.Parsing.Dom;
using System.Drawing;

namespace WindowsFormsApp1
/*
 class tượng trưng cho đỉnh cảu đồ thị
 */
{
    public class GraphNode
    {
        public int Index { get; set; } //vị trí
        public string Name { get; set; } //tên
        public Point Location { get; set; } //vị trí trong trục oxy
        public NodeType Type { get; set; } //loại Node
        public GraphNode(int index, string name, Point location, NodeType type) //hàm khởi tạo
        {
            Index = index;
            Name = name;
            Location = location;
            Type = type;
        }
    }
    //tạo enum có 3 loại node : hos , Đường , Đèn đỏ
    public enum NodeType
    {
        Hospital,
        Intersection,
        TrafficLight
    }
}
