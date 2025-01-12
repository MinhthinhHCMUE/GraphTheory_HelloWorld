using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    internal class Astar
    {
        private int _vertices; // Số lượng đỉnh trong đồ thị
        private int[,] _adjMatrix; // Ma trận kề để biểu diễn các cạnh và trọng số
        private double[] _heuristics; // Mảng heuristic, ước tính khoảng cách từ mỗi đỉnh đến đích

        public Astar(int vertices, double[] heuristics)
        {
            _vertices = vertices;
            _adjMatrix = new int[vertices, vertices];
            _heuristics = heuristics;
        }

        public void AddEdge(int source, int destination, int weight)
        {
            _adjMatrix[source, destination] = weight;
            _adjMatrix[destination, source] = weight;
        }

        public List<int> FindPath(int start, int goal)
        {
            // Khởi tạo các danh sách và tập hợp cần thiết
            List<int> openSet = new List<int>(); // Tập hợp các nút đang chờ xét (nút mở)
            HashSet<int> closedSet = new HashSet<int>(); // Tập hợp các nút đã xét (nút đóng)
            int[] cameFrom = new int[_vertices]; // Lưu nút trước đó trên đường đi từ nút bắt đầu đến nút hiện tại
            double[] gScore = new double[_vertices]; // Lưu chi phí di chuyển thực tế từ nút bắt đầu đến nút hiện tại
            double[] fScore = new double[_vertices]; // Lưu tổng chi phí ước tính từ nút bắt đầu đến nút đích (fScore = gScore + heuristic)

            // Khởi tạo giá trị ban đầu
            for (int i = 0; i < _vertices; i++)
            {
                gScore[i] = double.PositiveInfinity; // Ban đầu, chi phí đến tất cả các nút là vô cùng
                fScore[i] = double.PositiveInfinity;
                cameFrom[i] = -1; // Chưa có nút trước đó cho bất kỳ nút nào
            }

            // Thêm nút bắt đầu vào openSet
            openSet.Add(start);
            gScore[start] = 0; // Chi phí từ nút bắt đầu đến chính nó là 0
            fScore[start] = _heuristics[start]; // fScore ban đầu của nút bắt đầu chỉ là heuristic

            // Lặp cho đến khi openSet rỗng (không còn nút nào để xét)
            while (openSet.Count > 0)
            {
                // Tìm nút có fScore nhỏ nhất trong openSet (nút có triển vọng nhất)
                int current = GetLowestFScoreNode(openSet, fScore);

                // Nếu nút hiện tại là đích, xây dựng và trả về đường đi
                if (current == goal)
                {
                    return ReconstructPath(cameFrom, current);
                }

                // Chuyển nút hiện tại từ openSet sang closedSet (đã xét xong nút này)
                openSet.Remove(current);
                closedSet.Add(current);

                // Xét các nút kề với nút hiện tại
                for (int neighbor = 0; neighbor < _vertices; neighbor++)
                {
                    // Nếu nút kề đã được xét, bỏ qua
                    if (closedSet.Contains(neighbor))
                    {
                        continue;
                    }

                    // Nếu không có cạnh nối giữa nút hiện tại và nút kề, bỏ qua
                    if (_adjMatrix[current, neighbor] == 0)
                    {
                        continue;
                    }

                    // Tính toán chi phí tạm thời từ nút bắt đầu đến nút kề qua nút hiện tại
                    double tentativeGScore = gScore[current] + _adjMatrix[current, neighbor];

                    // Nếu nút kề chưa có trong openSet, thêm vào
                    if (!openSet.Contains(neighbor))
                    {
                        openSet.Add(neighbor);
                    }
                    // Nếu chi phí tạm thời không tốt hơn chi phí hiện tại của nút kề, bỏ qua
                    else if (tentativeGScore >= gScore[neighbor])
                    {
                        continue;
                    }

                    // Cập nhật chi phí và nút trước đó cho nút kề (đã tìm thấy đường đi tốt hơn đến nút kề)
                    cameFrom[neighbor] = current;
                    gScore[neighbor] = tentativeGScore;
                    fScore[neighbor] = gScore[neighbor] + _heuristics[neighbor];
                }
            }

            // Không tìm thấy đường đi
            return null;
        }

        // Tìm nút có fScore nhỏ nhất trong openSet
        private int GetLowestFScoreNode(List<int> openSet, double[] fScore)
        {
            int lowestFScoreNode = openSet[0];
            double lowestFScore = fScore[lowestFScoreNode];

            for (int i = 1; i < openSet.Count; i++)
            {
                int node = openSet[i];
                if (fScore[node] < lowestFScore)
                {
                    lowestFScoreNode = node;
                    lowestFScore = fScore[node];
                }
            }

            return lowestFScoreNode;
        }

        // Xây dựng lại đường đi từ nút đích đến nút bắt đầu bằng cách lần ngược lại các nút trước đó
        private List<int> ReconstructPath(int[] cameFrom, int current)
        {
            List<int> path = new List<int>();
            path.Add(current); // Bắt đầu từ nút đích

            while (cameFrom[current] != -1) // Lần ngược lại đến nút bắt đầu
            {
                current = cameFrom[current];
                path.Insert(0, current); // Thêm nút vào đầu danh sách để có thứ tự đúng
            }

            return path;
        }

    }
}