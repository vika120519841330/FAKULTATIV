using System;
/*Найти сумму 2х матриц.В каждом случае нужно обязательно проверить соответствие размеров матриц для определения
возможности выполнения указанных операций.*/
namespace Facultative_Lesson_4_Task_1
{
    class SumTwoMatrix
    {
        static void Main(string[] args)
        {
            int numLineA = 0; int numLineB = 0; //кол-во строк в матрице
            int numColA = 0;  int numColB = 0;//кол-во столбцов в матрице

            int[,] arrA =
            {
                {0, 1, 2 },
                {3, 4, 5 }
            };
            int sizeA = arrA.Length;

            int[,] arrB =
            {
                {6, 7, 8 },
                {9, 10, 11 }
            };
            int sizeB = arrB.Length; ;

            Console.WriteLine("Исходная матрица А:");
            for(int i = 0; i < 2; i++)
            {
                numColA = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arrA[i, j]}  ");
                    numColA = numColA + 1;
                }
                Console.WriteLine();
                numLineA = numLineA + 1;
            }
            
            Console.WriteLine("Исходная матрица В:");
            for (int i = 0; i < 2; i++)
            {
                numColB = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arrB[i, j]}  ");
                    numColB = numColB + 1;
                }
                Console.WriteLine();
                numLineB = numLineB + 1;
            }
            
             Console.WriteLine("Результирующая матрица, равная сумме матрицы А и В:");
            if ((sizeA == sizeB) && (numLineA == numLineB) && (numColA == numColB))
            {
                int[,] res = new int[numLineA, numColA];
                int k;
                for (int i = 0; i < numLineA; i++)
                {
                    for (int j = 0; j < numColA; j++)
                    {
                        k = arrA[i, j] + arrB[i, j];
                        res[i, j] = k;
                        Console.Write($"{res[i, j]}  ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрицу А и Матрицу В НЕЛЬЗЯ просуммироватьб т.к. они не равны!!");
                return;
            }
                
        }
    }
}
