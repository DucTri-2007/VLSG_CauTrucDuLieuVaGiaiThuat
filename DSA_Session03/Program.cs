using System;
using System.Diagnostics;

//Author: Vu Nguyen Duc Tri - 2500115657
class Program
{
    static void Main()
    {
        int[] arr = new int[1000000];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i; // mảng đã sắp xếp
        }

        int target = 999999;

        Stopwatch sw = new Stopwatch();

        // Linear Search
        sw.Start();
        int idx1 = LinearSearch(arr, target);
        sw.Stop();
        Console.WriteLine($"[Linear] Index: {idx1}, Time: {sw.Elapsed.TotalMilliseconds} ms");

        // Reset timer
        sw.Reset();

        // Binary Search
        sw.Start();
        int idx2 = BinarySearch(arr, target);
        sw.Stop();
        Console.WriteLine($"[Binary] Index: {idx2}, Time: {sw.Elapsed.TotalMilliseconds} ms");
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

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