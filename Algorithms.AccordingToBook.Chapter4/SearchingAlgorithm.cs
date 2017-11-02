using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Chapter4
{
    public class SearchingAlgorithm : ISearching
    {
        public int BinarySearch(int[] array, int value)
        {

            var lowerIndex = 0;
            var upperIndex = array.Length - 1;
            int middleIndex;
            while (lowerIndex <= upperIndex)
            {
                middleIndex = (lowerIndex + upperIndex) / 2;

                if (array[middleIndex] == value)
                {
                    return middleIndex;
                }
                else if (value < array[middleIndex])
                {
                    upperIndex = middleIndex - 1;
                }
                else
                {
                    lowerIndex = middleIndex + 1;
                }
            }

            return -1;
            
        }

        public int BinarySearchRecursion(int[] array, int value, int lowerBound, int upperBound)
        {

            if (lowerBound > upperBound)
            {
                return -1;
            }

            var middleIndex = (lowerBound + upperBound) / 2;

            if (value == array[middleIndex])
            {
                return middleIndex;
            }
            else if (value < array[middleIndex])
            {
                 return BinarySearchRecursion(array, value, lowerBound, middleIndex-1);
            }
            else
            {
                 return BinarySearchRecursion(array, value, middleIndex+1, upperBound);
            }
        }

        public int BinarySearchBuiltIn(int[] array, int value)
        {
            return Array.BinarySearch(array, value);
        }

        public int LinearSearch(int[] array, int value)
        {
            int arrayLength = array.Length;
            for (int i = 0; i < arrayLength-1; i++)
            {
                if(array[i] == value)
                {
                    return i;
                }                  
            }
            return -1;
        }

        public int Max(int[] array)
        {
            var max = array[0];
            var arrayLength = array.Length;

            for (int i = 1; i < arrayLength; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public int Min(int[] array)
        {
            var min = array[0];
            var arrayLength = array.Length;

            for (int i = 1; i < arrayLength; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
