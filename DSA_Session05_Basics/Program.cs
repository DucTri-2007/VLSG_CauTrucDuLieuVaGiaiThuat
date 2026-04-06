using System;
namespace DSA_Session05_Basics
//Author: Vũ Nguyễn Đức Trí - 2500115657
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 1: Hoán đổi 2 số không dùng biến tạm (Toán học)
            //Gợi ý: Dùng phép cộng và trừ
            //người dùng có thể nhập 2 số từ bàn phím và sau đó thực hiện hoán đổi
            Console.WriteLine("Bai 1: Hoan doi 2 so khong dung bien tam");
            Console.Write("Nhap so a: ");
            //Đọc chuỗi nhập vào từ bàn phím và lưu vào biến inputA
            string inputA = Console.ReadLine();
            //Sử dụng int.TryParse để chuyển đổi chuỗi nhập vào thành số nguyên,
            //nếu không hợp lệ thì yêu cầu người dùng nhập lại.
            int a;
            while (!int.TryParse(inputA, out a))
            {
                Console.Write("So a khong hop le. Vui long nhap lai: ");
                inputA = Console.ReadLine();
            }
            Console.Write("Nhap so b: ");
            //Đọc chuỗi nhập vào từ bàn phím và lưu biến inputB
            string inputB = Console.ReadLine();
            //Sử dụng int.TryParse để chuyển đổi chuỗi nhập vào thành số nguyên,
            //nếu không hợp lệ thì yêu cầu người dùng nhập lại.
            int b;
            while (!int.TryParse(inputB, out b)) 
            {
                Console.Write("So b khong hop le. Vui lam nhap lai: ");
                inputB = Console.ReadLine();
            }
            a = a + b; //Cộng a và b, kết quả lưu vào a
            b = a - b; //Lấy giá trị mới của a trừ đi b,
            //Kết quả lưu vào b (b giờ là giá trị ban đầu của a)
            a = a - b; //Lấy giá trị mới của a trừ đi b,
            //Kết quả lưu vào a (a giờ là giá trị ban đầu của b)
            Console.WriteLine($"a = {a}, b = {b}");

            Console.WriteLine("====================");
            Console.WriteLine("Bai 2: Ve hinh vuong dau sao (n x n)");
            //người dùng có thể nhập kích thước n từ bàn phím
            //và sau dó in ra hình vuông tương ứng
            Console.Write("Nhap kich thuoc n cua hinh vuong: ");
            string inputN = Console.ReadLine();
            int n; //Sử dụng int.TryParse để chuyển đổi chuỗi nhập vào một số nguyên,
            //nếu không hợp lệ thì yêu cầu người dùng nhập lại.
            //n > 0
            while (!int.TryParse(inputN, out n) || n <= 0) 
            {
                Console.Write("Kich thuoc n khong hop le. Vui long nhap lai: ");
                inputN = Console.ReadLine();
            }
            //Dùng 2 vòng lặp for để in ra hình vuông dấu sao
            for (int i = 0; i < n; i++)
            { //Duyệt hàng
                for (int j = 0; j < n; j++) 
                { //Duyệt cột
                    Console.Write("*");
                }
                Console.WriteLine(); //Xuống dòng sau mỗi hàng
            }

            Console.WriteLine("====================");
            Console.WriteLine("Bai 3: In bang cuu chuong (2 den 9)");
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine($"--- BANG CUU CHUONG {i} ---");
                for (int j = 1; j <= 10; j++) 
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            } 
        }
    }
}
