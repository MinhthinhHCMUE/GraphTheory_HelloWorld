using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Properties
{
    /*
     Class Implementation thuật toán Dijkstra
     */
    internal class Dijkstra
    {
        private int _vertices;  // Số đỉnh trong đồ thị
        private int[,] _adjMatrix; // Ma trận kề (adjacency matrix) lưu trọng số

        public Dijkstra(int vertices)
        {
            _vertices = vertices;
            _adjMatrix = new int[vertices, vertices];
        }

        // Thêm cạnh với trọng số
        public void AddEdge(int source, int destination, int weight)
        {
            _adjMatrix[source, destination] = weight;
            _adjMatrix[destination, source] = weight; // nếu đồ thị vô hướng
        }

        // Thuật toán Dijkstra với đường đi (cải tiến với PriorityQueue)
        public List<int> DijkstraWithPath(int start, int end)
        {
            int[] distances = new int[_vertices]; // Mảng lưu trữ khoảng cách ngắn nhất từ nút start đến các nút khác
            bool[] visited = new bool[_vertices]; // Mảng đánh dấu các nút đã được duyệt
            int[] previous = new int[_vertices]; // Mảng lưu trữ nút trước đó trên đường đi ngắn nhất
            PriorityQueue<Node> priorityQueue = new PriorityQueue<Node>(); // Hàng đợi ưu tiên để lưu các nút cần xét

            // Khởi tạo
            for (int i = 0; i < _vertices; i++)
            {
                distances[i] = int.MaxValue; // Ban đầu, khoảng cách đến tất cả các nút là vô cùng
                visited[i] = false; // Chưa có nút nào được duyệt
                previous[i] = -1;    // Chưa có nút trước đó cho bất kỳ nút nào
            }
            distances[start] = 0; // Khoảng cách từ nút bắt đầu đến chính nó là 0
            priorityQueue.Enqueue(new Node(start, 0)); // Thêm nút bắt đầu vào hàng đợi ưu tiên

            while (priorityQueue.Count > 0)
            {
                Node currentNode = priorityQueue.Dequeue(); // Lấy nút có khoảng cách nhỏ nhất từ hàng đợi ưu tiên
                int u = currentNode.Index;

                if (visited[u]) // Nếu nút đã được duyệt, bỏ qua
                {
                    continue;
                }
                visited[u] = true; // Đánh dấu nút đã được duyệt

                for (int v = 0; v < _vertices; v++)
                {
                    // Kiểm tra các nút kề với nút u
                    if (!visited[v] && _adjMatrix[u, v] > 0 && distances[u] != int.MaxValue)
                    {
                        // Tính tổng khoảng cách từ nút bắt đầu start đến nút v qua nút u
                        int newDistance = distances[u] + _adjMatrix[u, v];
                        // So sánh tổng khoảng cách với khoảng cách hiện tại
                        // Ưu tiên nút có đèn giao thông nếu khoảng cách bằng nhau
                        if (newDistance < distances[v] || (newDistance == distances[v] && IsTrafficLight(v)))
                        {
                            distances[v] = newDistance; // Cập nhật khoảng cách ngắn nhất đến nút v
                            previous[v] = u; // Cập nhật nút trước đó của nút v
                            priorityQueue.Enqueue(new Node(v, newDistance)); // Thêm nút v vào hàng đợi ưu tiên
                        }
                    }
                }
            }

            // Xây dựng đường đi
            List<int> path = new List<int>();
            int current = end;
            while (current != -1) // Lặp lại cho đến khi quay về nút bắt đầu
            {
                path.Insert(0, current); // Thêm nút hiện tại vào đầu danh sách đường đi
                current = previous[current]; // Di chuyển đến nút trước đó
            }
            return path;
        }


        private bool IsTrafficLight(int nodeIndex)
        {
            // Kiểm tra dựa trên chỉ số của nút hoặc thuộc tính của nút (nếu có)
            return nodeIndex >= 29 && nodeIndex <= 31; // Giả sử các nút từ 29 đến 31 là đèn giao thông
        }

        // Lớp Node để sử dụng trong PriorityQueue
        internal class Node : IComparable<Node>
        {
            public int Index { get; set; }
            public int Distance { get; set; }

            public Node(int index, int distance)
            {
                Index = index;
                Distance = distance;
            }

            public int CompareTo(Node other)
            {
                return Distance.CompareTo(other.Distance); // So sánh hai nút dựa trên khoảng cách
            }
        }
    }
}