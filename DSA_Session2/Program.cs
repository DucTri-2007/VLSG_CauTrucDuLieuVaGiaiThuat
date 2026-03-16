using System;

namespace DSA_Session2
{
    class Program
    {
        //Hàm đệ qui giai thừa 
        static long GiaiThua(int n)
        {
            //1. Trường hợp cơ sở: 0! = 1 và 1! = 1
            if (n <= 1) return 1;
            //2. Bước đệ quy: n! = n * (n - 1)!
            return n * GiaiThua(n - 1);
        }

        static int Fibonacci(int n)
        {
            // Trường hợp cơ sở
            if (n == 0) return 0;
            if (n == 1) return 1;
            // Bước đệ qui: F(n) = F(n - 1) + F(n - 2)
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        // Hàm đệ quy tính tổng S(n)
        static int TinhTong(int n)
        {
            //1. Trường hợp cơ sở: Khi n = 1, tổng chính là 1
            if (n == 1) return 1;
            //2. Bước đẹ quy: S(n) = n + S(n - 1)
            return n + TinhTong(n - 1);
        }

        static long GiaiThuaVongLap(int n)
        {
            long KetQua = 1;
            for (int i = 1; i <= n; i++)
            {
                KetQua *= i; // Cập nhật trực tiếp trên 1 vùng nhớ duy nhất
            }
            return KetQua;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", n, GiaiThua(n));
            Console.WriteLine("Fibonacci({0}) = {1}", n, Fibonacci(n));

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhap n de tinh tong: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tong S ({n}) = {TinhTong(n)}");
            Console.WriteLine($"Giai thua cua {n} la {GiaiThuaVongLap(n)}");
        }
    }
}
