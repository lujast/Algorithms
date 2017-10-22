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
        public void LinearSearch_SearchedElementExists_ReturnsIndex()
        {
            //Arrange
            var collection = new[] { 3, 4, 5, 2, 3, 12, 1 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.LinearSearch(collection, 2);

            //Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void LinearSearch_SearchedElementNotExists_ReturnsNull()
        {
            //Arrange
            var collection = new[] { 3, 4, 5, 2, 3, 12, 1 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.LinearSearch(collection, 10);

            //Assert
            Assert.AreEqual(null, result);
        }

        [Test]
        public void LinearSearch_CollectionIsNull_ReturnsNull()
        {
            //Arrange
            int[] collection = null;
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.LinearSearch(collection, 10);

            //Assert
            Assert.AreEqual(null, result);
        }

        [Test]
        public void LinearSearch_CollectionIsEmpty_ReturnsNull()
        {
            //Arrange
            int[] collection = new int[] { };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.LinearSearch(collection, 10);

            //Assert
            Assert.AreEqual(null, result);
        }

        [Test]
        public void LinearSearch_CollectionWithOneElementElementExists_ReturnsIndex()
        {
            //Arrange
            int[] collection = new int[] { 5 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.LinearSearch(collection, 5);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void LinearSearch_CollectionWithOneElementElementNotExists_ReturnsNull()
        {
            //Arrange
            int[] collection = new int[] { 5 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.LinearSearch(collection, 10);

            //Assert
            Assert.AreEqual(null, result);
        }

        //-- binary search tests
        [Test]
        public void BinarySearch_SearchedElementExists_ReturnsIndex()
        {
            //Arrange
            var collection = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearch(collection, 7);

            //Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void BinarySearch_SearchedElementNotExists_ReturnsNull()
        {
            //Arrange
            var collection = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearch(collection, 10);

            //Assert
            Assert.AreEqual(null, result);
        }

        [Test]
        public void BinarySearch_CollectionIsNull_ReturnsNull()
        {
            //Arrange
            int[] collection = null;
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearch(collection, 10);

            //Assert
            Assert.AreEqual(null, result);
        }

        [Test]
        public void BinarySearch_CollectionIsEmpty_ReturnsNull()
        {
            //Arrange
            int[] collection = new int[] { };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearch(collection, 10);

            //Assert
            Assert.AreEqual(null, result);
        }

        [Test]
        public void BinarySearch_CollectionWithOneElementElementExists_ReturnsIndex()
        {
            //Arrange
            int[] collection = new int[] { 5 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearch(collection, 5);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void BinarySearch_CollectionWithOneElementElementNotExists_ReturnsNull()
        {
            //Arrange
            int[] collection = new int[] { 5 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearch(collection, 10);

            //Assert
            Assert.AreEqual(null, result);
        }


        //-- binary search sing recursion tests
        [Test]
        public void BinarySearch2_SearchedElementExists_ReturnsIndex()
        {
            //Arrange
            var collection = new[] { 1,2,3,4,5,6,7,8 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearchUsingRecursion(collection,0,collection.Length-1 ,7);

            //Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void BinarySearch2_SearchedElementNotExists_ReturnsNull()
        {
            //Arrange
            var collection = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearchUsingRecursion(collection,0, collection.Length-1, 10);

            //Assert
            Assert.AreEqual(null, result);
        }

        [Test]
        public void BinarySearch2_CollectionIsNull_ReturnsNull()
        {
            //Arrange
            int[] collection = null;
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearchUsingRecursion(collection,0, 10, 10);

            //Assert
            Assert.AreEqual(null, result);
        }

        [Test]
        public void BinarySearch2_CollectionIsEmpty_ReturnsNull()
        {
            //Arrange
            int[] collection = new int[] { };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearchUsingRecursion(collection,0, collection.Length-1, 10);

            //Assert
            Assert.AreEqual(null, result);
        }

        [Test]
        public void BinarySearch2_CollectionWithOneElementElementExists_ReturnsIndex()
        {
            //Arrange
            int[] collection = new int[] { 5 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearchUsingRecursion(collection,0, collection.Length-1 ,5);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void BinarySearch2_CollectionWithOneElementElementNotExists_ReturnsNull()
        {
            //Arrange
            int[] collection = new int[] { 5 };
            var algotihm = new Algorithm();

            //Act
            var result = algotihm.BinarySearchUsingRecursion(collection,0,collection.Length-1, 10);

            //Assert
            Assert.AreEqual(null, result);
        }
    }
}