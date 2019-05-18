using System;

namespace facultative_3
{
    class CrossTwoRounds
    {
        //На плоскости даны две окружности. Требуется проверить, имеют ли они хотя бы одну общую точку.

        static void Main(string[] args)
        {
            int x1, y1, r1;//радиус и координаты центра первой окружности
            int x2, y2, r2;//радиус и координаты центра второй окружности
            double distance; //расстояние между центрами двух окружностей

            Console.WriteLine("Введите радиус первой окружности:");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты первой окружности:");
            x1 = Int32.Parse(Console.ReadLine());
            y1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите радиус второй окружности:");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй окружности:");
            x2 = Int32.Parse(Console.ReadLine());
            y2 = Int32.Parse(Console.ReadLine());

            distance = Math.Sqrt( (double)(Math.Pow((x2-x1), 2)) + (double)(Math.Pow((y2-y1), 2)));

            if (distance <= (r1+r2))
                Console.WriteLine("Окружности имеют как минимум одну точку пересечения");
            else Console.WriteLine("Окружности не имеют точек пересечения");
        }
    }
}
