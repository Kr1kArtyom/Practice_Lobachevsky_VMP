using System;

class Program
{
    static void PrintArray(int[] arr)
    {
        Console.WriteLine(String.Join<int>(" ", arr));
    }

    static int[] InsertGroupOfElements(int[] arr, int[] group, int position)
    {
        int[] newarr = new int[arr.Length + group.Length];
        if (position > arr.Length - 1)
        {
            Array.Copy(arr, newarr, arr.Length);
            Array.Copy(group, 0, newarr, arr.Length, group.Length);
            return newarr;
        }

        Array.Copy(arr, 0, newarr, 0, position);

        for (int i = 0; i < group.Length; i++)
        {
            newarr[position + i] = group[i];
        }

        Array.Copy(arr, position, newarr, position + group.Length, arr.Length - position);

        return newarr;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] group = { 6, 7, 8 };
        int position = 2;

        PrintArray(arr = InsertGroupOfElements(arr, group, position));

        position = 10;

        PrintArray(arr = InsertGroupOfElements(arr, group, position));
    }
}