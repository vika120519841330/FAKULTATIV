using System;

namespace facultative_5
{
    class BaseballVin
    //Известны результаты каждой из 4х четвертей баскетбольной встречи. Нужно определить победителя матча. Побеждает команда, набравшая больше очков в течение 
    //всего матча.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите результаты первой четверти баскетбольного матча:");
            byte A1 = Byte.Parse(Console.ReadLine());
            byte B1 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите результаты второй четверти баскетбольного матча:");
            byte A2 = Byte.Parse(Console.ReadLine());
            byte B2 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите результаты третьей четверти баскетбольного матча:");
            byte A3 = Byte.Parse(Console.ReadLine());
            byte B3 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите результаты последней четверти баскетбольного матча:");
            byte A4 = Byte.Parse(Console.ReadLine());
            byte B4 = Byte.Parse(Console.ReadLine());

            BaseballVin.resultGame(A1, B1, A2, B2, A3, B3, A4, B4);
        }
        static void resultGame (byte resA1, byte resB1, byte resA2, byte resB2, byte resA3, byte resB3, byte resA4, byte resB4)
        {
            byte resA = 0;
            byte resB = 0;
            byte[,] Array =
            {
                {resA1, resB1},
                {resA2, resB2},
                {resA3, resB3},
                {resA4, resB4}
            };
                for (int j = 0, i = 0; i < 4; i++)
                {
                    resA = (byte)(resA + Array[i, j]);
                }
                for (int j = 1, i = 0; i < 4; i++)
                {
                    resB = (byte)(resB + Array[i, j]);
                }

            if (resA > resB)
                Console.WriteLine("Победила первая команда");
            else if (resA < resB)
                Console.WriteLine("Победила вторая команда");
            else Console.WriteLine("Команды сыграли вничью");
        }
    }
}
