using AlgorithmsBook.Algorithms;
using MyAlgorithmsCollection.Algorithms;
using System;

namespace AlgorithmsBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidParentheses.IsValid("(){}[]"));
            Console.WriteLine(ValidParentheses.IsValid(")"));
            Console.WriteLine(ValidParentheses.IsValid("([{}][]())"));
            Console.WriteLine(ValidParentheses.IsValid("))"));
        }
    }
}
