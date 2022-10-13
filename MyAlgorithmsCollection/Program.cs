using AlgorithmsBook.Algorithms;
using MyAlgorithmsCollection.Algorithms;
using System;

namespace AlgorithmsBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[] { 1, 1,1,1,1,1,1,2, 2, -4, 3, 3, -1, 2,2,9,1,1,0,9,7,7,7 };
            Console.WriteLine(string.Join(",",DeleteDuplicates.UniqueNumbersHashSet(lista)));
        }
    }
}
