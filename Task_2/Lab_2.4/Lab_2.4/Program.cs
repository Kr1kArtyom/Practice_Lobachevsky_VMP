using System;

class Program
{
    static int FindRow(int[,]cinema, int numOfSeats)
    {
        for (int i = 0; i < cinema.GetLength(0); i++)
        {
            int maxNumOfSeats = 0;

            for(int j = 0; j < cinema.GetLength(1); j++)
            {
                if (cinema[i, j] == 0) maxNumOfSeats++;
            }

            if (maxNumOfSeats >= numOfSeats) return i + 1;
        }

        return 0;
    }

    static int[,] InitCinema(int rows, int seats)
    {
        int[,] cinema = new int[rows, seats];
        for (int i = 0; i < rows; i++)
        {
            string[] rowValues = Console.ReadLine().Split(' ');

            for (int j = 0; j < seats; j++)
            {
                cinema[i, j] = int.Parse(rowValues[j]);
            }
        }
        return cinema;
    }

    static void Main()
    {
        int n, m, k;
        Console.WriteLine("Введите количество рядов в кинотеатре:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("\nВведите количество мест в ряду:");
        m = int.Parse(Console.ReadLine());

        Console.WriteLine("\nВведите свободные и занятые места в кинотеатре:");
        int[,] cinema = InitCinema(n, m);

        Console.WriteLine("\nВведите количество соседних мест для покупки:");
        k = int.Parse(Console.ReadLine());

        Console.WriteLine("\nПодходящий ряд: {0}", FindRow(cinema, k));
    }
}