using AlgorithmsBook.Algorithms;
using MyAlgorithmsCollection.Algorithms;
using System;

namespace AlgorithmsBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[] { 1, 2, -4, 3, 3, -1, 2 };
            Console.WriteLine(SubvectorSumaMaxima.SumaMaxima(lista));
        }
    }
}
