using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа находит номер строки с наименьшей суммой элементов
    {
        static void Main (string[] args)
        {
            int[,] createZeroMatrix(int n, int m)
            {
                int[,] Matrix = new int[n, m];

                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        Matrix[i, j] = 0;
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

            int[,] fillSpirally(int[,] Matrix)
            {
                int[] Start = new int[] {0,0};
                int n = Matrix.GetLength(0);
                int m = Matrix.GetLength(1);

                for(int j = 0; j < (m/2 + m%2); j++)
                {
                Start[0] = j;
                Start[1] = j;

                for(int i = Start[1]; i < m; i++)                       // первый цикл (идём вправо до упора)
                {
                    Matrix[Start[0],i] = new Random().Next(10,100);
                }
                Start[0] = Start[0] + 1;
                Start[1] = m - 1;

                printMatrix(Matrix);        /////

                if(Matrix[Start[0],Start[1]] != 0) return Matrix;

                for(int i = Start[0]; i < n; i++)                       // второй цикл (идём вниз до упора)
                {
                    Matrix[i,Start[1]] = new Random().Next(10,100);
                }
                Start[0] = n - 1;
                Start[1] = Start[1] - 1;

                printMatrix(Matrix);   /////////

                if(Matrix[Start[0],Start[1]] != 0) return Matrix;

                for(int i = Start[1]; i > (Start[1] - (m - 1)); i--)      // третий цикл (идём влево до упора)
                {
                    Matrix[Start[0],i] = new Random().Next(10,100);
                }
                Start[0] = Start[0] - 1;
                Start[1] = Start[1] - (m - 2);

                printMatrix(Matrix);   /////////

                if(Matrix[Start[0],Start[1]] != 0) return Matrix;

                for(int i = Start[0]; i > Start[0] - (n - 2) ; i--)       // четвертый цикл (идём вверх до упора)
                {
                    Matrix[i, Start[1]] = new Random().Next(10,100);
                }
                Start[0] = Start[0] - (n - 3);
                Start[1] = Start[1] + 1;

                printMatrix(Matrix);   /////////

                if(Matrix[Start[0],Start[1]] != 0) return Matrix;

                m = m - 1;
                n = n - 1;
                }
                return Matrix;
            }
            

            Console.WriteLine("Создание двумерного массива.");
            Console.Write("Количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] Massive = createZeroMatrix(n,m);
            printMatrix(Massive);
            Massive = fillSpirally(Massive);
            printMatrix(Massive);

        }
    }
}
