using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    public class Algorithm
    {

        //
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

        //
        public int? BinarySearch(int[] collection, int elementToFind)
        {
            collection.OrderBy(x => x);

            return null;
        }
    }
}
