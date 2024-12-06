using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAlgorithmsCollection.Algorithms
{
    public class MostRepeatedWord
    {
        public static void Run(string text)
        {
            var dictionary = new Dictionary<string, int>();
            var words = text.Split(new char[] { ',', ' ', '.' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower());

            foreach (var word in words)
            {
                if (!dictionary.ContainsKey(word))
                    dictionary[word] = 1;
                else
                    dictionary[word]++;
            }
            var mostRepeatedWord = dictionary
                .OrderByDescending(x => x.Value)
                .FirstOrDefault().Key;

            Console.WriteLine(mostRepeatedWord);
        }

        public static void Run2(string text)
        {
            int maxCount = 0;
            string mostRepeatedWord = "";
            int counter = 0;

            var WordsArray = text.Split(
                new char[] { ' ', ',', '.' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower());

            HashSet<string> uniqueWords = new HashSet<string>();

            foreach (var word in WordsArray)
                uniqueWords.Add(word.ToLower());

            foreach (var word in uniqueWords)
            {
                foreach (var word2 in WordsArray)
                {
                    if (word == word2) counter++;
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    mostRepeatedWord = word;
                }
                counter = 0;
            }
            Console.WriteLine(mostRepeatedWord);
        } 
    }
}
