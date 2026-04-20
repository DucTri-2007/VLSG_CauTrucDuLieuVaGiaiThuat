using System;
using System.Collections.Generic;
namespace DSA_Session08_Queue_01
//Vũ Nguyễn Đức Trí - 2500115657

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khởi tạo hàng đợi chứa tên khách hàng
            Queue<string> callQueue = new Queue<string>();

            Console.WriteLine("=== HE THONG TONG DAI CSKH ===");
            Console.WriteLine("- Nhap ten khach hang de dua vao hang doi.");
            Console.WriteLine("- De trong va nhan [ENTER] de nhan vien nhan cuoc goi.");
            Console.WriteLine("- Nhap 'exit' de dong he thong.\n");

            while (true)
            {
                Console.Write("Lenh (Ten KH / [Enter] / exit): ");
                string input = Console.ReadLine();

                // 1. Thoát chương trình
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Hệ thống đã tắt.");
                    break;
                }

                // 2. Nhấn Enter để Dequeue (Phục vụ khách)
                if (string.IsNullOrEmpty(input))
                {
                    if (callQueue.Count > 0)
                    {
                        string nextCustomer = callQueue.Dequeue();
                        Console.WriteLine(
                            $">>> Dang ket noi may... Xin chao anh/chi: {nextCustomer}!");
                    }
                    else
                    {
                        Console.WriteLine(">>> Tong dai dang ranh, " +
                            "khong co khach hang nao cho.");
                    }
                }
                // 3. Nhập tên để Enqueue (Khách vào hàng đợi)
                else
                {
                    callQueue.Enqueue(input);
                    Console.WriteLine("[+] Da them khach hang '{0}' vao hang doi." +
                        "(Dang cho: {1})", input, callQueue.Count);
                }
            }
        }
    }
}
