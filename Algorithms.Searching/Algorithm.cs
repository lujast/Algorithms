using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    public class Algorithm
    {

        // computational complexity is linear O(N);
        public int? LinearSearch(int[] collection, int elementToFind)
        {
            if (collection == null || collection.Length == 0)
            {
                return null;
            }

            int index = 0;
            while (index <= collection.Length - 1 && collection[index] != elementToFind)
            {
                index++;
            }

            return index <= collection.Length - 1 ? (Nullable<int>)index : null;
        }

        // computational complexity is linear O(log2(N));
        public int? BinarySearch(int[] collection, int elementToFind)
        {
            if (collection == null || collection.Length == 0)
            {
                return null;
            }

            collection.OrderBy(x => x);

            var leftIndex = 0;
            var rightIndex = collection.Length - 1;

            while (leftIndex <= rightIndex)
            {       
                int middleIndex = (leftIndex + rightIndex) / 2;
                if (collection[middleIndex] == elementToFind)
                {
                    return middleIndex;
                }
                else if (collection[middleIndex] > elementToFind)
                {
                    rightIndex = middleIndex-1;
                }
                else
                {
                    leftIndex = middleIndex+1;
                }
            }

            return null;
        }



        public int? BinarySearchWithRecursion(int[] collection, int elementToFind)
        {

            return null;
        }
    }
}
