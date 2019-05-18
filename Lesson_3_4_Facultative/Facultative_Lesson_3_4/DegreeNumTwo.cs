using System;
/*Вычислить, чему равно число 2 возведенное в степени от 0 до 10, т.е. 2^0, 2^1, ... , 2^10.
С использованием циклов for и while (предполагается их вложенность).*/
namespace Facultative_Lesson_3_4
{
    class DegreeNumTwo
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 0; i <= 10; i++)
            {
                while (i > 0)
                {
                    num = num * 2;
                    break;
                }
                Console.WriteLine($"Число 2 в степени {i} равно: {num} ");
            }
        }
    }
}
