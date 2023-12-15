﻿namespace _04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            bool isFound = false;

            for (int i = 0; i < n; i++)
            {
                string characters = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = characters[j];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFound = true;
                        return;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
