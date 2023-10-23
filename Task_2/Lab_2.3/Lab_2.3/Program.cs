using System;

class Program
{
    static void PrintArray(int[] arr)
    {
        Console.WriteLine(String.Join<int>(" ", arr));
    }

    static double AverageValue(int[] arr)
    {
        int sumElements = 0;
        int countElements = 0;
        foreach (int element in arr)
        {
            sumElements += element;
            countElements++;
        }
        return (double)sumElements / countElements;
    }

    static int FindMax(int[] arr)
    {
        int max = arr[0];
        foreach (int i in arr)
        {
            if (i > max) max = i;
        }
        return max;
    }

    static int FindMin(int[] arr)
    {
        int min = arr[0];
        foreach (int i in arr)
        {
            if (i < min) min = i;
        }
        return min;
    }

    static void Swap(ref int value1, ref int value2)
    {
        int temp = value1;
        value1 = value2;
        value2 = temp;
    }

    static int FindPivot(int[] arr, int minIndex, int maxIndex)
    {
        int pivot = minIndex - 1;
        for (int i = minIndex; i < maxIndex; i++)
        {
            if (arr[i] > arr[maxIndex])
            {
                pivot++;
                Swap(ref arr[pivot], ref arr[i]);
            }
        }
        pivot++;
        Swap(ref arr[pivot], ref arr[maxIndex]);
        return pivot;
    }

    static int[] QuickSort(int[] arr, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex) return arr;

        var pivot = FindPivot(arr, minIndex, maxIndex);
        QuickSort(arr, minIndex, pivot - 1);
        QuickSort(arr, pivot + 1, maxIndex);

        return arr;
    }

    static int[] FindCommonElements(int[] arr1, int[] arr2)
    {
        return arr1.Intersect(arr2).ToArray();
    }

    static int[] MultiplyArrayByNumber(int[] arr, int number)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i]*number;
        }
        return arr;
    }

    static int[] SumArray(int[] arr1, int[] arr2)
    {
        int[] sumArr = new int[arr1.Length];
        if (arr1.Length != arr2.Length) return sumArr;
        for (int i = 0; i < arr1.Length; i++)
        {
            sumArr[i] = arr1[i] + arr2[i];
        }
        return sumArr;
    }

    static int[] InitArray(int size, Random value)
    {
        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = value.Next() % 10;
        }

        return newArray;
    }

    static void Main()
    {
        int sizeArr = 10;
        Random random = new Random();

        int[] arr1 = InitArray(sizeArr, random);
        int[] arr2 = InitArray(sizeArr, random);
        int[] arr3 = new int[sizeArr];

        Console.WriteLine("Элементы первого массива:");
        PrintArray(arr1);
        Console.WriteLine("\nЭлементы второго массива:");
        PrintArray(arr2);

        Console.WriteLine("\nОбщие элементы массивов:");
        PrintArray(FindCommonElements(arr1, arr2));

        Console.WriteLine("\nСумма двух массивов");
        arr3 = SumArray(arr1, arr2);
        PrintArray(arr3);

        Console.WriteLine("\nРезультат умножения первого массива на число 2:");
        MultiplyArrayByNumber(arr1, 2);
        PrintArray(arr1);

        Console.WriteLine("\nОтсортированный второй массив: ");
        QuickSort(arr2, 0, arr2.Length - 1);
        PrintArray(arr2);

        Console.WriteLine("\nМинимальный элемент певрого массива: {0}\nМаксимальный элемент первого массива: {1}\nСреднее арифметическое элементов первого массива: {2}", FindMin(arr1), FindMax(arr1), AverageValue(arr1));
    }
}