using System;

namespace facultative_1
{
    class SumWholeNum
    {
        //Требуется посчитать сумму целых чисел, расположенных между числами 1 и N включительно
        static void Main(string[] args)
        {
            uint N = 0;
            uint sum = 0;

            Console.WriteLine("Сколько целых положительных чисел Вы хотите просуммировать?");
            N = UInt32.Parse(Console.ReadLine());

            for (uint i = 1; i <= N; i++)
            {
              sum+=i;
            }
            Console.WriteLine($"Сумма целых чисел, расположенных между числами 1 и {N} включительно равна:\t {sum}");
        }
    }
}
