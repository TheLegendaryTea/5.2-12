using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] matr = new int[n, n];
            int[] array = new int[n];
            Random r = new Random();
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = r.Next(-10, 11);
                    Console.Write(matr[i, j].ToString() + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Массив из максимальных элементов в каждом столбце:");
            for (int j = 0; j < n; j++)
            {
                int max = int.MinValue;
                for (int i = 0; i < n; i++)
                {
                    if (matr[i, j] > max)
                    {
                        max = matr[i, j];
                    }
                }
                array[j] = max;
                Console.Write(array[j].ToString() + "\t");
            }
            Console.WriteLine();
        }
    }
}
