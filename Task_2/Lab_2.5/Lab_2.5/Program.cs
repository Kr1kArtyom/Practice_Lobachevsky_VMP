using System;
using System.Drawing;

class Program
{
    static void PrintMatrix(int[] arr)
    {
        int sizeMatrix = (int)Math.Sqrt(arr.Length);
        for (int i = 0; i < sizeMatrix; i++)
        {
            for (int j = 0; j < sizeMatrix; j++)
            {
                Console.Write("{0} ", arr[i*sizeMatrix + j]);
            }
            Console.WriteLine();
        }
    }

    static int[] MatrixMultiplication(int[] arr1, int[] arr2)
    {
        int[] resArr = new int[arr1.Length];
        int sizeMatrix = (int)Math.Sqrt(resArr.Length);
        for (int i = 0; i < sizeMatrix; i++)
        {
            for (int j = 0; j < sizeMatrix; j++)
            {
                int sum = 0;
                for (int k = 0; k < sizeMatrix; k++)
                {
                    sum += arr1[i * sizeMatrix + k] * arr2[k * sizeMatrix + j];
                }
                resArr[i * sizeMatrix + j] = sum;
            }
        }
        return resArr;
    }

    static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] arr2 = { 3, 3, 3, 2, 2, 2, 1, 1, 1 };
        int[] arr3;
        Console.WriteLine("Первая матрица");
        PrintMatrix(arr1);
        Console.WriteLine("\nВторая матрица");
        PrintMatrix(arr2);

        Console.WriteLine("\nРезультат умножения двух матриц");
        PrintMatrix(arr3 = MatrixMultiplication(arr1, arr2));
    }
}