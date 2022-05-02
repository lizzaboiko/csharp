using System;
namespace ClassLibraryV2
{
    public static class ArrayWorker
   {
        public static int[] Invert(in int[] mass)
        {
            int[] invertmass = new int[mass.Length];
            for (int a = mass.Length-1; a>=0; a--)
            {
                invertmass[mass.Length-1-a] = mass[a]; 
            }
            //invertmass[0] = mass[mass.Length - 1];
            //invertmass[invertmass.Length - 1] = mass[0];
            return invertmass; 
        }

        public static int[] Insert(int[] source, int index, int newValue)
        {
            if (index > source.Length)
            {
                return source;
            }
            int[] sourceinserted = new int[source.Length+1];
            sourceinserted[index] = newValue;
            for (int a = 0; a < index ; a++)
            {
                sourceinserted[a] = source[a];
            }
            for (int a = index; a<=source.Length-1; a++)
            {
                sourceinserted[a+1] = source[a];
            }
            return sourceinserted;
        }
    } 
}

