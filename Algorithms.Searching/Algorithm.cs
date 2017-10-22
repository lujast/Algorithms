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
                    rightIndex = middleIndex - 1;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }

            return null;
        }


        // computational complexity is linear O(log2(N));
        public int? BinarySearchUsingRecursion(int[] collection, int startingIndex, int endingIndex,
            int elementToFind)
        {
            if(collection== null || collection.Length==0)
            {
                return null;
            }

            if(startingIndex == endingIndex)
            {
                return collection[startingIndex] == elementToFind ? (Nullable<int>)startingIndex : null;
            }


            int middleIndex = (startingIndex + endingIndex) / 2;

            if (collection[middleIndex] == elementToFind)
            {
                return middleIndex;
            }

            if (collection[middleIndex] < elementToFind)
            {
                return BinarySearchUsingRecursion(collection, middleIndex+1,  endingIndex, elementToFind);
            }
            else
            {
                return BinarySearchUsingRecursion(collection, startingIndex, middleIndex-1, elementToFind);
            }

        }


    }
}
