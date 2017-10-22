using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public interface ISortingAlgorithm
    {

        void Sort(int[] collection);

        void Swap(ref int element1,ref int element2);
    }
}
