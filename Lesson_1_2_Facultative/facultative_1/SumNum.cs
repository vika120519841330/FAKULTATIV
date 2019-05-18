using System;

namespace facultative_1
{
    class SumWholeNum
    {
        //Требуется посчитать сумму целых чисел, расположенных между числами 1 и N включительно
        static void Main(string[] args)
        {
            int N = 0;//число м.б. как положительным так и отрицательным
            int sum = 0;

            Console.WriteLine("Введите целое число(положительное или отрицательное):");
            N = Int32.Parse(Console.ReadLine());

            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    sum += i;
                    Console.Write($"{sum}\t");
                }
            }
            else
            {
                for (int i = N; i <= 1; i++)
                {
                    sum += i;
                    Console.Write($"{sum}\t");
                }
            }
            Console.WriteLine($"\nСумма целых чисел, расположенных между числами 1 и {N} включительно равна:\t {sum}");
        }
    }
}
