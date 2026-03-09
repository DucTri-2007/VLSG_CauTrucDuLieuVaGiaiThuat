using System;

namespace DSA_Lesson1
{
    class SinhVien
    {
        public string HoTen { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //---- BÀI TẬP 1: HIỂU VỀ THAM CHIẾU (REFERENCE)
            Console.WriteLine("=== Bai Tap 1: Tham chieu ===");

            SinhVien sv1 = new SinhVien { HoTen = "Vu Nguyen Duc Tri" };

            // sv2 trỏ vào cùng địa chỉ với sv1
            SinhVien sv2 = sv1;

            sv2.HoTen = "Nguyen Ngoc Tien";

            Console.WriteLine($"Ten cua sv1 sau khi thay doi qua sv2: {sv1.HoTen}");

            //---- BÀI TẬP 2: HOÁN ĐỔI GIÁ TRỊ VỚI 'ref'
            Console.WriteLine("\n=== Bai Tap 2: Hoan doi (Swap) ===");

            int a = 10;
            int b = 20;

            Swap(ref a, ref b);

            Console.WriteLine($"Sau khi Swap: a = {a}, b = {b}");

            // ---- BÀI TẬP 3: THAO TÁC MẢNG
            Console.WriteLine("\n=== Bai tap 3: Thao tac mang ===");

            int[] numbers = { 1, 2, 3, 4, 5 };

            PrintArray(numbers);
        }

        // Giải thích bài 2
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // Giải thích bài 3
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("Cac phan tu trong mang:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}