using System;

namespace facultative_4
{
    class CheckLuckyTicket
    {
        /*Вы пользуетесь общественным транспортом? Вероятно, вы расплачивались за проезд и получали билет с номером. 
        Счастливым билетом называют такой билет с шестизначным номером, где сумма первых трех цифр равна сумме последних трех.
        Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6. Вам требуется написать программу, которая проверяет счастливость билета.*/
        static uint num;
        static uint part_1, part_2;
        static void Main(string[] args)
        {

            Console.WriteLine("Введите шестизначный номер билета:");
            num = UInt32.Parse(Console.ReadLine());
            uint[] numArray = new uint[6];
            for (int i = numArray.Length - 1; i >= 0; i--)
            {
                numArray[i] = num % 10;
                num = (uint)num / 10;
            }
          
            for (int i = 0; i < 3; i++)
            {
                part_1 += numArray[i];
            }
            for (int i = 3; i < numArray.Length; i++)
            {
                part_2 += numArray[i];
            }

            if (part_1 == part_2)
                Console.WriteLine("Поздравляю! Вы обладатель счастливого билета!");
            else Console.WriteLine("Сожалеем..ваш билет не счастливый.");
        }
    }
}
