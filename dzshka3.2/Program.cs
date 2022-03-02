using System;

namespace dzshka3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 14;
            int y = 1;
            int z = 5;
            x += y - x++ * z; // операции присваивания правоассоциативные, выполение справа налево
            Console.WriteLine($"x = {x} y = {y} z = {z}");
            z = --x - y * 5;
            Console.WriteLine($"x = {x} y = {y} z = {z}");
            y /= x + 5 % z;
            Console.WriteLine($"x = {x} y = {y} z = {z}");
            z = x++ + y * 5;
            Console.WriteLine($"x = {x} y = {y} z = {z}");
            x = y - x++ * z;
            Console.WriteLine($"x = {x} y = {y} z = {z}");
        }
    }
}
