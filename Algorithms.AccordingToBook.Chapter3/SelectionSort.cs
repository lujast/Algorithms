using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Chapter3
{
    public class SelectionSort : ISorting
    {
        private int[] array;

        public SelectionSort(int[] array)
        {
            this.array = array;
        }

        public string[] Sort(bool showSteps=false)
        {
            int lastIndex = array.Length - 1;
            int minIndex;
            int temp;

            for (int i = 0; i < lastIndex - 1; i++)
            {
                minIndex = i;
                for (int j = i+1; j <= lastIndex; j++)
                {
                    if (array[j] < array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return null;

        }
    }
}
