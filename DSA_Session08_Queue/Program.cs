using System;

// Vũ Nguyễn Đức Trí - 2500115657
namespace DSA_Session08_Queue {
    // Tạo một class quản lý hàng đợi riêng biệt
    public class MyQueue
    {
        private int[] elements; // Mảng chứa dữ liệu
        private int front;      // Con trỏ đầu hàng
        private int rear;       // Con trỏ cuối hàng
        private int max;        // Kích thước tối đa

        // Constructor khởi tạo
        public MyQueue(int size)
        {
            elements = new int[size];
            front = -1;
            rear = -1;
            max = size;
        }

        // Hàm thêm phần tử vào hàng đợi
        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("LOI: Hang doi da day (Overflow)!");
                return;
            }

            // Nếu là phần tử đầu tiên được thêm vào
            if (front == -1)
            {
                front = 0;
            }

            rear++; // Tăng con trỏ cuối lên
            elements[rear] = item; // Nạp dữ liệu
            Console.WriteLine($"Da them [{item}] vao hang doi.");
        }

        // Hàm lấy phần tử ra khỏi hàng đợi
        public int Dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("LOI: Hang doi trong (Underflow)!");
                return -1;
            }

            int item = elements[front]; // Lấy giá trị ở đầu hàng
            front++; // Đẩy con trỏ đầu hàng lùi ra sau

            // Tối ưu: Nếu lấy hết phần tử, reset lại hàng đợi
            if (front > rear)
            {
                front = -1;
                rear = -1;
            }

            return item;
        }

        // Xem người đầu tiên mà không xóa
        public void Peek()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Hang doi đang trong rong.");
            }
            else
            {
                Console.WriteLine($"Phan tu đau hang hien tai la: {elements[front]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo hàng đợi có kích thước là 5
            MyQueue queue = new MyQueue(5);

            // Thêm các phần tử vào hàng đợi
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Xem phần tử đầu hàng
            queue.Peek();

            // Lấy phần tử ra khỏi hàng đợi
            Console.WriteLine($"Phan tu lay ra: {queue.Dequeue()}");
            Console.WriteLine($"Phan ta lay ra: {queue.Dequeue()}");

            // Xem lại phần tử đầu hàng sau khi lấy ra
            queue.Peek();

            // Thêm tiếp để kiểm tra
            queue.Enqueue(40);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue(); // Thử lấy ra khi hàng đợi trống
        }
    }
}