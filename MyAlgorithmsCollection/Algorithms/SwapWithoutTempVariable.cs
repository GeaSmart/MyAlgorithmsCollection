using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithmsCollection.Algorithms
{
    public class SwapWithoutTempVariable
    {
        public static void Swap(int x, int y)
        {            
            //traditional swap with temp variable
            //int temp = x;
            //x = y;
            //y = temp;

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"{x},{y}");
        }
    }
}
