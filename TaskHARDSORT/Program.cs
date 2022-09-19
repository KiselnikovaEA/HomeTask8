using System;

namespace HomeTasks_KisEA
{
    class Program           // Программа сортирует по строкам и столбцам
    {                       // двумерный массив из вещественных чисел
        static void Main (string[] args)
        {
            double[,] createMatrix(int n, int m)
            {
                double[,] Matrix = new double[n, m];

                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        Matrix[i, j] = new Random().NextDouble()*10;
                    }
                }

                return Matrix;
            }

            void printMatrix(double[,] Matrix)
            {
                for(int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        Console.Write("{0:0.00}  ", Matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            double[,] sortMatrix(double[,] Matrix)
            {
                int n = Matrix.GetLength(0);
                int m = Matrix.GetLength(1);
                int tempSize = n*m;
                double[] tempArray = new double[tempSize];
                int i, j;
                double temp;
                int t = 0;
                for(i = 0; i < n; i++)
                {
                    for(j = 0; j < m; j++)
                    {
                        tempArray[t] = Matrix[i,j];
                        t = t + 1;
                    }
                }
                int minind;
                for(i = 0; i < tempSize; i++)
                {
                    minind = i;
                    for(j = i + 1; j < tempSize; j++)
                    {
                        if(tempArray[j] < tempArray[minind])
                        {
                            minind = j;                                                        
                        }
                    }
                    temp = tempArray[i];
                    tempArray[i] = tempArray[minind];
                    tempArray[minind] = temp;
                }
                //for(i = 0; i < tempSize; i++) Console.Write("{0:0.00}  ", tempArray[i]);
                t = 0;
                for(i = 0; i < n; i++)
                {
                    for(j = 0; j < m; j++)
                    {
                        Matrix[i,j] = tempArray[t];
                        t = t + 1;
                    }
                }
                return Matrix;
            }

            Console.WriteLine("Давайте создадим двумерный массив.");
            Console.Write("Количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Созданный массив:");
            double[,] a = createMatrix(n,m);
            printMatrix(a);
            a = sortMatrix(a);
            Console.WriteLine("Отсортированный массив:");
            printMatrix(a);
        }
    }
}