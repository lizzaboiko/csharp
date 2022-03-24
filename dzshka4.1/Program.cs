using System;

namespace dzshka4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int a = int.Parse(Console.ReadLine());
            if (a>=0 & a<=30)
            { 
                Console.WriteLine("Ваше число в промежутке от 0 до 30");
            }
            else if (a >= 31 & a <= 60) 
           {
                Console.WriteLine("Ваше число в промежутке от 31 до 60");
            }
            else if (a >= 61 & a <= 100)
            {
                Console.WriteLine("Ваше число в промежутке от 61 до 100");
            }
            else
            {
                Console.WriteLine("Я такого числа не знаю");
            }
        }
    }
}