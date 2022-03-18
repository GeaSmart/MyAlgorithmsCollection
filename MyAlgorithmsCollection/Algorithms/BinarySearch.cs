using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsBook.Algorithms
{
    public class BinarySearch
    {
        public static int Run(int[] arreglo, int x)
        {       
            int left = 0;
            int right = arreglo.Length - 1;

            while(left <= right)
            {
                int middle = left + (right-left) / 2;

                if (arreglo[middle] == x)
                    return middle;

                if (x > arreglo[middle])
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            return -1;
        }
    }
}
