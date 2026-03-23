using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // 1. Khởi tạo mảng 1 triệu phần tử (đã sắp xếp)
        int n = 1_000_000;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = i * 2; // Mảng số chẵn tăng dần
        }

        int x = arr[n - 1]; // Tìm phần tử cuối (worst case)

        Stopwatch sw = new Stopwatch();

        // 2. Linear Search
        sw.Start();
        int idx1 = LinearSearch(arr, x);
        sw.Stop();
        Console.WriteLine($"[Linear] Index: {idx1}, Time: {sw.Elapsed.TotalMilliseconds} ms");

        // 3. Binary Search
        sw.Restart();
        int idx2 = BinarySearch(arr, x);
        sw.Stop();
        Console.WriteLine($"[Binary] Index: {idx2}, Time: {sw.Elapsed.TotalMilliseconds} ms");
    }

    // Linear Search
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    // Binary Search
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}
