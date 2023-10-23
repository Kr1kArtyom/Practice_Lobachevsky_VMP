using System;

class Program
{
    static void PrintArray(int[] arr)
    {
        Console.WriteLine(String.Join<int>(" ", arr));
    }

    static int[] SwapHalfs(int[] arr)
    {
        int lastElOfHalf = arr[arr.Length / 2];
        for (int i = 0; i < arr.Length / 2; i++)
        {
            (arr[i], arr[i + arr.Length / 2]) = (arr[i + (int)Math.Ceiling((double)arr.Length / 2)], arr[i]);
        }
        if (arr.Length % 2 != 0) arr[arr.Length - 1] = lastElOfHalf;

        return arr;
    }

    static void Main()
    {
        int[] arr1 = {1, 2, 3, 4, 5, 6 };
        int[] arr2 = { 1, 2, 3, 4, 5, 6, 7 };

        PrintArray(arr1 = SwapHalfs(arr1));
        PrintArray(arr2 = SwapHalfs(arr2));
    }
}