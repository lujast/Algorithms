using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Chapter3
{
    public class BubleSort : ISorting
    {
        private int[] array;

        public BubleSort(int[] array)
        {
            this.array = array;
        }


        public string[] Sort(bool showSteps = false)
        {
            int lastIndex = array.Length - 1;
            int temp;
            for (int i = lastIndex; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return null;
        }
    }
}
