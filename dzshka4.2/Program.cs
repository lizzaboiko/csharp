using System;

namespace dzshka4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 200;
            while (a<500)
            {
                if (a%17==0)
                {
                    Console.Write($"{a} ,");
                }
                a++;
            }
        }
    }
}
