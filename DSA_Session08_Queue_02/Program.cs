using System;
namespace DSA_Session08_Queue_02
//Vũ Nguyễn Đức Trí - 2500115657
{
    public class CircularQueue
    {
        private int[] elements;
        private int front;
        private int rear;
        private int max;
        private int count; // Thêm biến count để dễ dàng kiểm tra mảng đầy/rỗng
        
        public CircularQueue(int size)
        {
            max = size;
            elements = new int[max];
            front = 0;   // front bắt đầu ở 0
            rear = -1;  // rear lùi lại 1 bước chờ phần tử đầu tiên
            count = 0;  // Số lượng hiện tại bằng 0
        }

        // Thêm vào hàng đợi vòng
        public void Enqueue(int item)
        {
            if (count == max)
            {
                Console.WriteLine($"LOI: Hang doi da day! Khong the them {item}.");
                return;
            }

            // Dùng Modulo để vòng rear lại đầu mảng nếu chạm đáy
            rear = (rear + 1) % max;
            elements[rear] = item;
            count++;
            Console.WriteLine($"[+] Da them: {item} (vao Index {rear})");
        }

        // Lấy ra từ hàng đợi vòng
        public int Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("LOI: Hang doi rong!");
                return -1;
            }

            int item = elements[front];
            // Dùng Modulo để vòng front lại đầu mảng nếu chạm đáy
            front = (front + 1) % max;
            count--;
            Console.WriteLine($"[-] Da lay ra: {item}");
            return item;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CircularQueue cq = new CircularQueue(3); // Mảng tối đa 3 phần tử

            cq.Enqueue(10);
            cq.Enqueue(20);
            cq.Enqueue(30);
            // Hiện tại mảng đã ĐẦY: [10, 20, 30]

            cq.Dequeue(); // Lấy 10 ra. Vị trí Index 0 đang trống.

            // Ở Queue tuyến tính bình thường, lệnh dưới sẽ lỗi.
            // Nhưng với Circular Queue, 40 sẽ được vòng lại điền vào Index 0!
            cq.Enqueue(40);
        }
    }
}