using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = GenerateNumbers(10);

            Console.WriteLine("BubleSort:");
            DisplayArray(array);
            var bubbleSort = new BubleSort(array);
            bubbleSort.Sort();
            DisplayArray(array);

            Console.WriteLine("\nSelectionSort");
            array = GenerateNumbers(10);
            DisplayArray(array);
            var selectionSort = new SelectionSort(array);
            selectionSort.Sort();
            DisplayArray(array);

            Console.WriteLine("\nInsertionSort");
            array = GenerateNumbers(10);
            DisplayArray(array);
            var insertionSort = new InsertionSort(array);
            insertionSort.Sort();
            DisplayArray(array);

        }


        public static int[] GenerateNumbers(int numbersCount)
        {
            var array = new int[numbersCount];
            var rand = new Random();
            for (int i = 0; i < numbersCount; i++)
            {
                array[i] = rand.Next(0, 100); 
            }
            return array;
        }

        public static void DisplayArray(int[] array)
        {
            var stringToView = new StringBuilder();
            foreach (var item in array)
            {
                stringToView.Append(item).Append(" ");
            }
            Console.WriteLine(stringToView.ToString());
        }


    }
}
