using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Chapter3
{
    public class InsertionSort : ISorting
    {
        private int[] array;

        public InsertionSort(int[] array)
        {
            this.array = array;
        }

        public string[] Sort(bool showSteps=false)
        {
            int lastIndex = array.Length - 1;
            int temp;
            for (int i = 1; i <= lastIndex; i++)
            {
                int indexInSortedArray = i;
                temp = array[i];
                while (indexInSortedArray > 0 && temp < array[indexInSortedArray-1] )
                {
                    array[indexInSortedArray] = array[indexInSortedArray-1];
                    indexInSortedArray--;
                }
                array[indexInSortedArray] = temp;
          
            }

            return null;
        }
    }
}
