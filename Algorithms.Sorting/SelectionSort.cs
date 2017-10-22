using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SelectionSort : ISortingAlgorithm
    {


        public void Sort(int[] collection)
        {
            for (int i = 0; i < collection.Length - 1; i++)
            {
                var min = collection[i];

                for (int j = i + 1; j <= collection.Length - 1; j++)
                {
                    if (collection[j] < collection[i])
                    {
                        Swap(ref collection[j], ref collection[i]);
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
