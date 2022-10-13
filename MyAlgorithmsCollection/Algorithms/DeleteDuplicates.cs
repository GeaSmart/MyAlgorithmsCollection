using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAlgorithmsCollection.Algorithms
{
    internal class DeleteDuplicates
    {
        public static int[] UniqueNumbersLinq(int[] arreglo)
        {
            return arreglo.Distinct().ToArray();
        }

        public static int[] UniqueNumbersIteration(int[] arreglo)
        {
            var response = new List<int>();

            for (int i = 0; i < arreglo.Length; i++)
            {
                if(!response.Contains(arreglo[i]))
                    response.Add(arreglo[i]);
            }
            return response.ToArray();
        }

        public static int[] UniqueNumbersHashSet(int[] arreglo)
        {
            HashSet<int> result = new HashSet<int>(arreglo);
            return result.ToArray();
        }
    }

    internal class DeleteDuplicates<T>
    {
        public static T[] UniqueNumbersLinq(T[] arreglo)
        {
            return arreglo.Distinct().ToArray();
        }

        public static T[] UniqueNumbersIteration(T[] arreglo)
        {
            var response = new List<T>();

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (!response.Contains(arreglo[i]))
                    response.Add(arreglo[i]);
            }
            return response.ToArray();
        }

        public static T[] UniqueNumbersHashSet(T[] arreglo)
        {
            HashSet<T> result = new HashSet<T>(arreglo);
            return result.ToArray();
        }
    }
}
