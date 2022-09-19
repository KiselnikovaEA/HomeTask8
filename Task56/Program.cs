using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа находит номер строки с наименьшей суммой элементов
    {
        static void Main (string[] args)
        {
            int[,] createMatrix(int n, int m)
            {
                int[,] Matrix = new int[n, m];

                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        Matrix[i, j] = new Random().Next(1, 10);
                    }
                }

                return Matrix;
            }

            void printMatrix(int[,] Matrix)
            {
                for(int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        Console.Write($"{Matrix[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            int findMinSumLine(int[,] Matrix)
            {
                int[] sumLines = new int[Matrix.GetLength(0)];              // создаю одномерный массив по количестку строк, чтоб считать сюда сумму элементов в строках

                for(int i = 0; i < Matrix.GetLength(0); i++)
                {
                    sumLines[i] = 0;
                    for(int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        sumLines[i] = sumLines[i] + Matrix[i,j];
                    }
                }
                for(int i = 0; i < sumLines.Length; i++) {Console.WriteLine($"{i+1}-я строка: {sumLines[i]} ");}
                Console.WriteLine();
                int minElement = 0;
                for(int i = 1; i < sumLines.Length; i++)
                {
                    if(sumLines[i] < sumLines[minElement]) minElement = i; 
                }
                return minElement + 1;
            }

            Console.WriteLine("Создание двумерного массива.");
            Console.Write("Количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] Massive = createMatrix(n,m);
            printMatrix(Massive);
            Console.WriteLine($"В {findMinSumLine(Massive)}-й строке наименьшая сумма элементов");

        }
    }
}