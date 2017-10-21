using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching.Tests
{

    [TestFixture]
    public class AlgorithmTest
    {
        [Test]
        public void LinearSearch_InputNotEmpty_ReturnsSortedCol()
        {

            //Arrange
            var collection = new[] { 3, 4, 5, 2, 3, 12, 1 };
            var algotihm = new Algorithm();

            //Act
            var result=algotihm.LinearSearch(collection, 2);

            //Assert
            Assert.AreEqual(3, result);
        }
    }
}
