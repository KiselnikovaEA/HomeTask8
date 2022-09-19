using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа формирует трёхмерный массив из неповторяющихся двузначных чисел
    {
        static void Main (string[] args)
        {
            int[,,] createCubeMatrix(int n, int m, int k)
            {

                int[] Array = new int[n*m*k];

                for(int i = 0; i < Array.Length; i++)  // Нагенерировала себе массив случайных чисел с проверкой неповторения
                {
                    Array[i] = new Random().Next(10,100);
                    for(int j = 0; j < i; j++)
                    {
                        if(Array[i] == Array[j])
                        {
                            i--;
                            break;
                        }
                    }
                }
                for(int i = 0; i < Array.Length; i++) Console.Write($"{Array[i]}  ");
                Console.WriteLine();

                int[,,] Matrix = new int[n, m, k];
                int a = 0;

                for(int i = 0; i < Matrix.GetLength(0); i++)  // Заполнила случайными числами из одномерного массива по порядку
                {
                    for(int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        for(int l = 0; l < Matrix.GetLength(2); l++)
                        {
                            Matrix[i,j,l] = Array[a];
                            a++;
                        }
                    }
                }
                return Matrix;
                
            }

            void printCubeMatrix(int[,,] Matrix)
            {
                for(int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        for(int l = 0; l < Matrix.GetLength(2); l++)
                        {
                            Console.Write($"{Matrix[i,j,l]} ({i},{j},{l})  ");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("Создание кубического массива.");
            Console.Write("Ширина: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Глубина: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[,,] cubeMatrix = createCubeMatrix(n,m,k);
            printCubeMatrix(cubeMatrix);

            //int[,,] cubeMassive = createCubeMatrix(n,m,k);
            //printMatrix(Massive);


        }
    }
}
