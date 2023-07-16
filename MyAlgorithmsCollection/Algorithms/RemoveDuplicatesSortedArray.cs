using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithmsCollection.Algorithms
{
    public class RemoveDuplicatesSortedArray
    {
        public static int RemoveDuplicates(int[] initialArray)
        {
            var hash = new HashSet<int>();
            int lastCounter = 0;
            int internalCounter = 0;
            foreach (var item in initialArray)
            {
                hash.Add(item);
                if (hash.Count > lastCounter)
                {
                    initialArray[internalCounter] = item;
                    internalCounter++;
                    lastCounter = hash.Count;
                }
            }
            return hash.Count;
        }
    }
}
