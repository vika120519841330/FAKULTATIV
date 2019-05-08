using System;

namespace facultative_2
{
    class LeastCommonDiv
    {
        //Требуется написать программу, определяющую наименьшее общее кратное (НОК) чисел a и b.
        static void Main(string[] args)
        {
            uint a, b;
            uint min, max, nod = 1, nok = 1;

            Console.WriteLine("Введите два целых числа:");
            a = UInt32.Parse(Console.ReadLine());
            b = Convert.ToUInt32(Console.ReadLine());

            min = a <= b ? a : b;
            max = b > a ? b : a;
   
            for (int i = 2; i <= max; i++)
            {
               if ((a % i == 0)&&(b % i == 0))
                    nod = i;
            }

            Console.WriteLine($"Наибольший общий делитель двух чисел {a} и {b} равен: {nod}");

            nok = (a * b) / nod;
            Console.WriteLine($"Наименьшее общее кратное двух чисел {a} и {b} равно: {nok}");
        }
    }
}
