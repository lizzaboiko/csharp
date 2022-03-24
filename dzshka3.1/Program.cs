using System;

namespace dzshka3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const decimal pi = 3.141592653m;
            Console.WriteLine("Введите радиус основания в см:");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите образующую в см:");
            int l = int.Parse(Console.ReadLine());
            decimal s = pi * r * (r + l);
            Console.WriteLine($"Площадь поверхности круглого конуса равна {s} см^2 ");
        }
    }
}
