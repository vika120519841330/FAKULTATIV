using System;
//Найти произведение 2х матриц.
namespace Facultative_Lesson_4_Task_2
{
    class MultipleTwoMatrix
    {
        static void Main(string[] args)
        {
            int numLineA = 0; int numLineB = 0; //кол-во строк в матрице
            int numColA = 0; int numColB = 0;//кол-во столбцов в матрице

            int[,] arrA =
            {
                {0, 1, 2},
                {3, 4, 5}
            };
            int sizeA = arrA.Length;

            int[,] arrB =
            {
                {6, 7},
                {8, 9},
                {10, 11}
            };
            int sizeB = arrB.Length; ;

            Console.WriteLine("Исходная матрица А:");
            for (int i = 0; i < 2; i++)
            {
                numColA = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arrA[i, j]}\t");
                    numColA = numColA + 1;
                }
                Console.WriteLine("\n");
                numLineA = numLineA + 1;
            }

            Console.WriteLine("Исходная матрица В:");
            for (int i = 0; i < 3; i++)
            {
                numColB = 0;
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{arrB[i, j]}\t");
                    numColB = numColB + 1;
                }
                Console.WriteLine("\n");
                numLineB = numLineB + 1;
            }

            if (numLineA == numColB)
            {
                int t = 0;
                int numColRes = numColA * numColB;
                int numLineRes = numLineA;
                int[,] res = new int[numLineRes, numColRes];
                Console.WriteLine($"Результат произведения матрицы А на матрицу В есть матрица размером {numLineRes}x{numColRes}:\n");

                for (int i = 0; i < numLineRes; i++)
                {
                    for (int j = 0; j < numColB; j++)
                    {
                        for (int k = 0; k < numColA; k++)
                        {
                            t = arrA[i, k] * arrB[k, j];
                            res[i, j] = t;
                            Console.Write($"{res[i, j]}\t");
                        }  
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("НЕЛЬЗЯ найти произведение матрицы А ина матрицу В,\n т.к. кол-во строк в матрице А не равно количеству столбцов в матрице В!!");
                return;
            }
            
        }
    }
}
