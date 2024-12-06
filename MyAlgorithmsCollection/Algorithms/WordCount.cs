using System;
using System.Text;

namespace MyAlgorithmsCollection.Algorithms
{
    public class WordCount
    {
        public static int Run(string texto)
        {
            bool spaceDetected = false;
            StringBuilder cleanText = new StringBuilder();

            foreach (var caracter in texto)
            {
                if (caracter == ' ')
                {
                    if (spaceDetected)
                        continue;
                    else
                        spaceDetected = true;
                }
                else
                    spaceDetected = false;
                cleanText.Append(caracter);
            }
            return cleanText.ToString()
                .Trim()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Length;
        }
    }
}
