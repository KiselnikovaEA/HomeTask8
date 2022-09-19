using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа находит произведение двух матриц
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

            int checkMatrix(int[,] MatrixA, int[,] MatrixB)
            {
                if(MatrixA.GetLength(1) == MatrixB.GetLength(0)) return 1;
                else return 0;
            }

            int[,] findMatrixMultiplication(int[,] MatrixA, int[,] MatrixB)
            {
                int m = MatrixA.GetLength(0);
                int n = MatrixA.GetLength(1);
                int k = MatrixB.GetLength(1);
                int[,] MatrixC = new int[m,k];

                for(int i = 0; i < m; i++)
                {
                    for(int j = 0; j < k; j++)
                    {
                        MatrixC[i,j] = 0;
                        for(int s = 0; s < n; s++)
                        {
                            MatrixC[i,j] = MatrixC[i,j] + MatrixA[i,s]*MatrixB[s,j];
                        }
                    }
                }

                return MatrixC;
            }
            

            Console.WriteLine("Произведение двух матриц.");
            Console.WriteLine("Размерность первой матрицы");
            Console.Write("Количество строк: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Размерность второй матрицы");
            Console.Write("Количество строк: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[,] MatrixA = createMatrix(m,n1);
            int[,] MatrixB = createMatrix(n2,k);

            Console.WriteLine("Матрица А: ");
            printMatrix(MatrixA);
            Console.WriteLine("Матрица B: ");
            printMatrix(MatrixB);

            if(checkMatrix(MatrixA, MatrixB) == 1)
            {
                int[,] MatrixC = findMatrixMultiplication(MatrixA, MatrixB);
                Console.WriteLine("Матрица C: ");
                printMatrix(MatrixC);
            }
            else Console.WriteLine("Матрицы нельзя перемножить");

        }
    }
}