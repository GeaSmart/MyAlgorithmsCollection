using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithmsCollection.Algorithms
{
    public class RemoveDuplicateSpaces
    {
        public static string Run(string frase)
        {
            string response = "";
            bool space = false;

            foreach(var caracter in frase)
            {
                if(caracter == ' ')
                {
                    if (!space)
                        response += caracter;
                    space = true;
                }
                else
                {
                    response += caracter;
                    space = false;
                }
            }
            return response;
        }
    }
}
