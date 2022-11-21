using AlgorithmsBook.Algorithms;
using MyAlgorithmsCollection.Algorithms;
using System;

namespace AlgorithmsBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "hola mundo esta es una cadena de caracteres en la cual se hace algo muy sencillo.";
            Console.WriteLine(LongestWord.Run(frase));
        }
    }
}
