using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithmsCollection.Algorithms
{
    public class LongestWord
    {
        public static string Run(string frase)
        {
            string[] arreglo = frase.Split(' ');

            int maxLength = 0;
            string longestWord = "";

            foreach(var palabra in arreglo)
            {
                if(palabra.Length > maxLength)
                {
                    maxLength = palabra.Length;
                    longestWord = palabra;
                }
            }
            return longestWord;
        }
    }
}
