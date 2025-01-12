using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    /*
     Class Implementation PriorityQueue ( Do .Net Framework 4.8 ko hỗ trợ sẵn thư viện PriorityQueue nên phải tự Implementation
     */
    /*
     # Class PriorityQueue 
     # Khai báo lớp với một tham số kiểu T
     # where T : IComparable<T> là một ràng buộc kiểu (constraint) yêu cầu kiểu T phải triển khai interface IComparable<T>. 
     # Điều này có nghĩa là các phần tử trong hàng đợi ưu tiên phải có thể so sánh được với nhau để xác định thứ tự ưu tiên.
     */
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> _heap;

        public PriorityQueue()
        {
            _heap = new List<T>();  // Khởi tạo danh sách rỗng để lưu trữ heap
        }

        public int Count
        {
            get { return _heap.Count; }  // Trả về số lượng phần tử trong hàng đợi
        }

        public void Enqueue(T item)
        {
            _heap.Add(item);  // Thêm phần tử vào cuối danh sách
            HeapifyUp(_heap.Count - 1);  // Duy trì tính chất heap bằng cách di chuyển phần tử mới lên
        }

        public T Dequeue()
        {
            if (_heap.Count == 0)
            {
                throw new InvalidOperationException("Priority queue hiện đang rỗng!!.");  // Ném ngoại lệ nếu hàng đợi rỗng
            }

            T root = _heap[0];  // Lấy phần tử gốc (phần tử có độ ưu tiên cao nhất)
            _heap[0] = _heap[_heap.Count - 1];  // Di chuyển phần tử cuối cùng lên vị trí gốc
            _heap.RemoveAt(_heap.Count - 1);  // Xóa phần tử cuối cùng
            HeapifyDown(0);  // Duy trì tính chất heap bằng cách di chuyển phần tử gốc xuống
            return root;  // Trả về phần tử gốc đã xóa
        }

        public T Peek()
        {
            if (_heap.Count == 0)
            {
                throw new InvalidOperationException("Priority queue hiện đang rỗng!!.");  // Ném ngoại lệ nếu hàng đợi rỗng
            }

            return _heap[0];  // Trả về phần tử gốc (không xóa)
        }

        private void HeapifyUp(int index)
        {
            int parentIndex = (index - 1) / 2;  // Tính toán chỉ số của phần tử cha
            while (index > 0 && _heap[index].CompareTo(_heap[parentIndex]) < 0)  // So sánh phần tử hiện tại với phần tử cha
            {
                Swap(index, parentIndex);  // Hoán đổi vị trí nếu phần tử hiện tại có độ ưu tiên cao hơn
                index = parentIndex;  // Di chuyển lên vị trí của phần tử cha
                parentIndex = (index - 1) / 2;  // Tính toán lại chỉ số của phần tử cha mới
            }
        }

        private void HeapifyDown(int index)
        {
            int leftChildIndex = 2 * index + 1;  // Tính toán chỉ số của phần tử con trái
            int rightChildIndex = 2 * index + 2;  // Tính toán chỉ số của phần tử con phải
            int smallestIndex = index;  // Giả sử phần tử hiện tại có chỉ số nhỏ nhất

            if (leftChildIndex < _heap.Count && _heap[leftChildIndex].CompareTo(_heap[smallestIndex]) < 0)  // So sánh với phần tử con trái
            {
                smallestIndex = leftChildIndex;  // Cập nhật chỉ số nhỏ nhất nếu phần tử con trái có độ ưu tiên cao hơn
            }

            if (rightChildIndex < _heap.Count && _heap[rightChildIndex].CompareTo(_heap[smallestIndex]) < 0)  // So sánh với phần tử con phải
            {
                smallestIndex = rightChildIndex;  // Cập nhật chỉ số nhỏ nhất nếu phần tử con phải có độ ưu tiên cao hơn
            }

            if (smallestIndex != index)  // Nếu phần tử hiện tại không phải là phần tử có độ ưu tiên cao nhất
            {
                Swap(index, smallestIndex);  // Hoán đổi vị trí với phần tử có độ ưu tiên cao nhất
                HeapifyDown(smallestIndex);  // Tiếp tục di chuyển xuống để duy trì tính chất heap
            }
        }

        private void Swap(int i, int j)
        {
            T temp = _heap[i];  // Hoán đổi vị trí hai phần tử trong danh sách
            _heap[i] = _heap[j];
            _heap[j] = temp;
        }
    }
}