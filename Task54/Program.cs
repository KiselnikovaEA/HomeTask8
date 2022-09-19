using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа упорядочивает все строки двумрного массива по убыванию значения элементов
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

            int[,] sortMatrixLines(int[,] Matrix)
            {
                int maxind, buff;
                for(int i = 0; i < Matrix.GetLength(0); i++)
                {

                    for(int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        maxind = j;
                        for(int k = j; k < Matrix.GetLength(1); k++)
                        {
                            if(Matrix[i,k] > Matrix[i,maxind]) maxind = k;
                        }
                        buff = Matrix[i,j];
                        Matrix[i,j] = Matrix[i,maxind];
                        Matrix[i,maxind] = buff;
                    }                                   

                }
                return Matrix;
            }

            Console.WriteLine("Создание двумерного массива.");
            Console.Write("Количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] Massive = createMatrix(n,m);
            printMatrix(Massive);
            Massive = sortMatrixLines(Massive);
            printMatrix(Massive);


        }
    }
}