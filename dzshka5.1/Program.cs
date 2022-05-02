using System;
using ClassLibraryV2;

namespace dzshka5
{
    class MainClass
    {
        public static void Print(in int[] array)
        {
            for (int a=0; a < array.Length ; a++)
            {
                Console.Write(array[a]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            int[] array = { 1, 32, 3, 4, 5 };
            int[] inverted = ArrayWorker.Invert(in array);
            Print(in array);
            Print(in inverted);
            int[] source = { 1, 8, 7, 5, 9 };
            int[] sourceinserted = ArrayWorker.Insert(source, 9, 23) ;
            Print(source);
            Print(sourceinserted);
        }
    }
}
