using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Lib
{
    public class ArrayGenerator
    {
        public int[] Generate(int numbersCount, int minValue, int maxValue)
        {
            var random = new Random();
            var array = new int[numbersCount];
            
            for (int i = 0; i < numbersCount; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }

            return array;
        }

    }
}
