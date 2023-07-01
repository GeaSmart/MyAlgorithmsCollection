using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithmsCollection.Algorithms
{
    public class RomanArabicConverter
    {
        public static int Convert(string romanNumber)
        {
            var values = new Dictionary<char, int>();
            values.Add('I', 1);
            values.Add('V', 5);
            values.Add('X', 10);
            values.Add('L', 50);
            values.Add('C', 100);
            values.Add('D', 500);
            values.Add('M', 1000);

            int result = 0;
            for (int i = 0; i < romanNumber.Length; i++)
            {
                if (i == romanNumber.Length - 1)
                {
                    result += values[romanNumber[i]];
                    break;
                }

                if (values[romanNumber[i]] < values[romanNumber[i + 1]])
                    result -= values[romanNumber[i]];
                else
                    result += values[romanNumber[i]];
            }
            return result;
        }
    }
}
