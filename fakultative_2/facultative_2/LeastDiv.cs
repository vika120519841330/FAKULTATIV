using System;

namespace facultative_2
{
    class LeastCommonDiv
    {
        //Требуется написать программу, определяющую наименьшее общее кратное (НОК) чисел a и b.
        static void Main(string[] args)
        {
            int a, b;
            int min, max, nok=1;
            bool flag = false;

            Console.WriteLine("Введите два целых числа:");
            a = Int32.Parse(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            min = a <= b ? a : b;
            max = b > a ? b : a;
   
            for (int i = min/2; i <= max/2; i++)
            {
               if ((a % i == 0)&&(b % i == 0)){ 
                    nok = i;
                    flag = true;
                }
               if (flag == true)
                    break;
            }
            Console.WriteLine($"Наименьшее общее кратное двух чисел {a} и {b} равно: {nok}");
        }
    }
}
