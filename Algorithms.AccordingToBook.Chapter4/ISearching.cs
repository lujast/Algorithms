using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Chapter4
{
    public interface ISearching
    {
        int Min(int[] array);

        int Max(int[] array);

        int LinearSearch(int[] array, int value);

        int BinarySearch(int[] array, int value);

        int BinarySearchRecursion(int[] array, int value, int lowerBound, int upperBound);

        int BinarySearchBuiltIn(int[] array, int value);
    }
}
