using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithmsCollection.Algorithms
{
    class SubvectorSumaMaxima
    {
        public static int SumaMaxima(int[] vector)
        {
            int suma = 0;
            int maxSum = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i; j < vector.Length; j++)
                {
                    suma += vector[j];

                    if (suma > maxSum)
                        maxSum = suma;
                }
                suma = 0;
            }
            return maxSum;
        }
    }
}
