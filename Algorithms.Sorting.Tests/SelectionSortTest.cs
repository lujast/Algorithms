using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Algorithms.Sorting.Tests
{

    [TestFixture]
    public class SelectionSortTest
    {
        [Test]
        public void Sort_InputCollectionNotSorted_ResultIsSorted()
        {
            //Arrange
            var collection = new[] { 3, 7, 1, 9, 5, 8 };
            var selectionSort = new SelectionSort();

            //Act
            selectionSort.Sort(collection);

            //Assert
            Assert.AreEqual(new[] { 1, 3, 5, 7, 8, 9 }, collection);

        }
    }
}
