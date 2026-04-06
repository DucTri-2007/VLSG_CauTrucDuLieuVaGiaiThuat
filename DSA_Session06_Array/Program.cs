using System;
namespace DSA_Session06_Array
//Author: Vũ Nguyễn Đức Trí - 2500115657
{
    class Program
    {
        // Biến toàn cục (Global) để lưu trữ mảng đang làm việc
        static int[] currentArray;
        static void Main(string[] args)
        {
            int choice; // Biến để lưu lựa chọn của người dùng
            do
            {
                Console.WriteLine("\n======================================");
                Console.WriteLine("    MODULE QUAN LY MANG (MIDTERM) ");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Tao mang so ngau nhien");
                Console.WriteLine("2. In mang hien tai");
                Console.WriteLine("3. Sap xep mang (Bubble Sort)");
                Console.WriteLine("4. Tim kiem nhi phan (Binary Search)");
                Console.WriteLine("0. Thoat phan mem");
                Console.WriteLine("======================================");
                Console.Write("Moi ban chon tinh nang (0-4): ");

                // Xử lý ngoại lệ nếu người dùng nhập chữ thay vì số
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Loi: Vui long nhap lai so nguyen!");
                    continue; // Quay lại đầu vòng lặp do-while
                }

                switch (choice)
                {
                    case 1:
                        GenerateRandomArray();
                        break;
                    case 2:
                        PrintArray();
                        break;
                    case 3:
                        BubbleSort();
                        break;
                    case 4:
                        ExecuteBinarySearch();
                        break;
                    case 0:
                        Console.WriteLine("Dong he thong. Chuc cac em diem cao!");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            } while (choice != 0);
        }

        // --- CÁC HÀM XỬ LÝ NGHIỆP VỤ ---

        static void GenerateRandomArray()
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Loi: Vui long nhap mot so nguyen duong!");
            }

            currentArray = new int[n];
            Random rand = new Random(); // Tạo đối tượng Random để sinh số ngẫu nhiên

            for (int i = 0; i < n; i++)
            {
                currentArray[i] = rand.Next(1, 100); // Tạo số ngẫu nhiên từ 1 đến 99
            }
            Console.WriteLine($"=> Da tao mang thanh cong voi {n} phan tu!");
        }
        // Hàm in mảng hiện tại
        static void PrintArray()
        {
            if (currentArray == null)
            {
                Console.WriteLine("Loi: Mang chua duoc khoi tao. Hay chon 1 chuc nang truoc!");
                return;
            }
            Console.Write("Du lieu mang: ");
            foreach (int num in currentArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Hàm sắp xếp mảng bằng thuật toán Bubble Sort
        static void BubbleSort()
        {
        if (currentArray == null)
        {
            Console.WriteLine("Loi: Mang rong!"); return;
        }

        int n = currentArray.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (currentArray[j] > currentArray[j + 1])
                {
                    // Hoán đổi
                    int temp = currentArray[j];
                    currentArray[j] = currentArray[j + 1];
                    currentArray[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("=> Da sap xep mang tang dan bang Bubble Sort!");
        }
        // Hàm thực hiện tìm kiếm nhị phân (Binary Search)
        static void ExecuteBinarySearch()
        {
            if (currentArray == null)
            {
                Console.WriteLine("Loi: Mang rong!"); return;
            }

            Console.Write("Nhap so can tim: ");
            int target;
            while (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.WriteLine("Loi: Vui long nhap mot so nguyen!");
            }

    // Thuật toán Binary Search
    int left = 0;
    int right = currentArray.Length - 1;
    int position = -1; // Biến lưu vị trí, -1 nghĩa là chưa tìm thấy

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (currentArray[mid] == target)
        {
            position = mid;
            break; // Đã tìm thấy, thoát vòng lặp
        }

        if (currentArray[mid] < target)
            left = mid + 1; // Bỏ qua nửa trái
        else
            right = mid - 1; // Bỏ qua nửa phải
    }

    if (position != -1)
    {
        Console.WriteLine($"=> Tuyet voi! Da tim thay so {target} "
            + $"tai vi tri Index = {position}.");
    }
    else
    {
        Console.WriteLine($"=> Khong tim thay so {target} trong mang."
            + "\n(Luu y: Mang phai duoc sap xep truoc khi tim nhi phan!)");
    }
}
    }
}