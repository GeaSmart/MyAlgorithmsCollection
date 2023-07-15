using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithmsCollection.Algorithms
{
    public class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            bool response = false;
            var pila = new Stack<char>();
            foreach (var caracter in s)
            {
                response = false;
                switch (caracter)
                {
                    case '(':
                        pila.Push(')');
                        break;
                    case '[':
                        pila.Push(']');
                        break;
                    case '{':
                        pila.Push('}');
                        break;
                    default:
                        if (pila.Count > 0)
                        {
                            if (caracter == pila.Pop())
                                response = true;
                            else
                                return false;
                        }
                        else
                            return false;
                        break;
                }
            }
            return pila.Count == 0 ? response : false;
        }
    }
}
