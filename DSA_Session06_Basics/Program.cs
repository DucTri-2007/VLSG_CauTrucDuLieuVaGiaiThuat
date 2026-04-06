using System;
namespace DSA_Session06_Basics
//Author: Vũ Nguyễn Đức Trí - 2500115657
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            // Sử dụng vòng lặp do-while để hiển thị menu và xử lý lựa chọn của người dùng
            // Vòng lặp sẽ tiếp tục cho đến khi người dùng chọn thoát (choice == 0)
            do
            {
                Console.WriteLine("\n=== MENU QUAN LY ===");
                Console.WriteLine("1. Chuc nang A");
                Console.WriteLine("2. Chuc nang B");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Moi ban chon (0-2): ");

                // Toán tử điều kiện (ternary operator) để kiểm tra và gán giá trị cho biến choice
                choice = int.TryParse(Console.ReadLine(), out choice) 
                         ? choice 
                         : -1; // Nếu nhập không hợp lệ, gán giá trị -1 để xử lý trong switch

                // Sử dụng switch-case để xử lý các lựa chọn của người dùng
                // Cấu trúc switch-case giúp mã nguồn rõ ràng và dễ bảo trì hơn so với nhiều câu lệnh if-else
                // Mỗi case tương ứng với một lựa chọn của người dùng,
                // và default xử lý các trường hợp không hợp lệ
                // break được sử dụng để ngăn chặn việc thực thi tiếp tục vào
                // các case khác sau khi đã thực hiện xong case hiện tại
                // Nếu không có break, chương trình sẽ tiếp tục thực thi các case tiếp theo
                // cho đến khi gặp break hoặc kết thúc switch
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Dang chay chuc nang A...");
                        break;
                    case 2:
                        Console.WriteLine("Dang chay chuc nang B...");
                        break;
                    case 0:
                        Console.WriteLine("Tam biet!");
                        break;
                    default:
                        Console.WriteLine("Luc chon khong hop le. Vui long nhap lai!");
                        break;
                }
            } while (choice != 0); // Kết thúc vòng lặp khi người dùng chọn thoát (choice == 0)
        }
    }
}
