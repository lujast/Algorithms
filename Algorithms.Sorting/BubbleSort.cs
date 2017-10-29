using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class BubbleSort : ISortingAlgorithm
    {
        public void Sort(int[] collection)
        {

            for (int i = 0; i < collection.Length; i++)
            {
                for (int j = collection.Length - 1; j > i; j--)
                {
                    if (collection[j] < collection[j - 1])
                    {
                        Swap(ref collection[j], ref collection[j - 1]);
                    }
                }
            }
        }

        public void Swap(ref int element1, ref int element2)
        {
            int buffer = element1;
            element1 = element2;
            element2 = buffer;
        }
    }
}
