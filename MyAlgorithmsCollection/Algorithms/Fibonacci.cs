using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithmsCollection.Algorithms
{
    public class Fibonacci
    {
        public static void Run(int numberElements)
        {            
            int[] arreglo = new int[numberElements];
            arreglo[0] = 0;
            arreglo[1] = 1;

            for(int i = 2; i < numberElements; i++)
            {
                arreglo[i] = arreglo[i - 1] + arreglo[i - 2];
            }

            Console.WriteLine(string.Join(",",arreglo));
        }
    }
}
