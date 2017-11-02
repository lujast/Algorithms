using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.AccordingToBook.Lib;

namespace Algorithms.AccordingToBook.Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {


        }


        static void SortingTest()
        {
            var arrayLength = 100;

            int[] arrayForBubleSort=null;
            int[] arrayForSelectionSort=null;
            int[] arrayForInsertionSort=null;

            Console.WriteLine($"Sorting test for {arrayLength} numbers:");
            var arrayBase = new ArrayGenerator().Generate(arrayLength, 0, 100);


        }



    }
}
