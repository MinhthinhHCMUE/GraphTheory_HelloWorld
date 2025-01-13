using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApp1
{

    internal class TrafficLight
    {
        public List<int> AdjacentNodes { get; set; } // Danh sách các đỉnh kề
        public int Index { get; set; } // Chỉ số của đèn đỏ trong ma trận kề
        public int VertexA { get; set;  } // Chỉ số của đỉnh A
        public int VertexB { get; set; } // Chỉ số của đỉnh B
        public int DistanceFromA { get; set; } // Khoảng cách từ A đến đèn đỏ
        public bool IsRed { get; set; } // Trạng thái của đèn (đỏ hoặc xanh)
        public bool Passed { get; set; } // Đánh dấu đèn đỏ đã vượt qua
        public Point Location { get; set; } // Tọa độ của đèn trên bản đồ

        public TrafficLight(int index, int vertexA, int vertexB, int distanceFromA, Point location)
        {
            Index = index;
            VertexA = vertexA;
            VertexB = vertexB;
            DistanceFromA = distanceFromA;
            IsRed = true; // Khởi tạo đèn đỏ ban đầu
            Location = location;
            AdjacentNodes = new List<int>() { vertexA, vertexB };// Khởi tạo danh sách các đỉnh kề với đèn giao thông này. 


        }

        public double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }

        public static Point CalculateTrafficLightLocation(int vertexA, int vertexB, int distanceFromA, int[,] adjacencyMatrix, Dictionary<int, GraphNode> nodePositions)
        {
            // Tính toán tọa độ của đèn giao thông dựa trên vị trí của 2 đỉnh kề (vertexA, vertexB) 
            // và khoảng cách từ đèn giao thông đến vertexA (distanceFromA).
            // adjacencyMatrix là ma trận kề của đồ thị.
            // nodePositions là từ điển lưu trữ vị trí của các đỉnh trên bản đồ.
            Point pointA = nodePositions[vertexA].Location;
            Point pointB = nodePositions[vertexB].Location;
            int totalDistance = adjacencyMatrix[vertexA, vertexB];
            double ratio = (double)distanceFromA / totalDistance;
            // Tính toán tọa độ x, y của đèn giao thông bằng cách nội suy tuyến tính
            int x = (int)(pointA.X + ratio * (pointB.X - pointA.X));
            int y = (int)(pointA.Y + ratio * (pointB.Y - pointA.Y));

            return new Point(x, y);
        }
        public void UpdateTrafficLightLocations(List<TrafficLight> trafficLights, int[,] adjacencyMatrix, Dictionary<int, GraphNode> nodePositions)
        {
            // Cập nhật tọa độ của tất cả các đèn giao thông trong danh sách trafficLights.
            foreach (var light in trafficLights)
            {
                Point calculatedLocation = CalculateTrafficLightLocation(light.VertexA, light.VertexB, light.DistanceFromA, adjacencyMatrix, nodePositions);

                // Cập nhật Location của TrafficLight
                light.Location = calculatedLocation;// Cập nhật tọa độ của đèn giao thông

                // Cập nhật lại tọa độ của đèn giao thông trong nodePositions (nếu có)
                if (nodePositions.ContainsKey(light.Index))
                {
                    nodePositions[light.Index].Location = calculatedLocation;
                }
            }
        }
        public double DecreaseSpeed(double distanceToLight, double currentSpeed, DateTime currentTime)
        {
            // Lấy tốc độ tối đa cho phép từ TimeAmbulanceMove
            double maxSpeed = TimeAmbulanceMove.GetSpeed(currentTime);

            double x = 7 * (1 - distanceToLight / 200); // Tính x bằng hàm tuyến tính / chọn số 7 (ngậu nhiên) làm hệ số giảm tốc, số khác cũng dc

            double newSpeed = maxSpeed - x;

            return Math.Max(13, newSpeed); // Đảm bảo tốc độ không nhỏ hơn 13km/h
        }

        public double IncreaseSpeed(double distanceFromLight, double currentSpeed, DateTime currentTime)
        {
            // Lấy tốc độ tối đa cho phép từ TimeAmbulanceMove
            double maxSpeed = TimeAmbulanceMove.GetSpeed(currentTime);

            double x = 7 * (distanceFromLight / 200); //Tính x bằng hàm tuến tính, logic tương tự DecreaseSpeed

            double newSpeed = 13 + x; // Tăng tốc độ từ 13km/h. cho nó nhất quán với logic
            return Math.Min(maxSpeed, newSpeed); // Đảm bảo tốc độ không vượt quá maxSpeed
        }
    }
}