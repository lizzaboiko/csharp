using System;
using ClassLibraryCone;

namespace dzshka53
{
    class MainClass
    {
        public static void Main(string[] args)
        {
        ConeSq cone = new ConeSq(3.22243, 9.999837);
            Console.WriteLine(cone.SquareBase());
            Console.WriteLine(cone.SquareCone());
        }
    }
}