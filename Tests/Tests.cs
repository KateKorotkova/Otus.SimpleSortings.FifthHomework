using NUnit.Framework;
using Otus.SimpleSortings.FifthHomework.Logic;

namespace Tests
{
    public class Tests
    {
        private int[] _initialArray = {3, 2, 10, 1, 5};
        private int[] _sortedArray = {1, 2, 3, 5, 10};

       
        [Test]
        public void Can_Sort_Via_Bubble_Sorting()
        {
            var bubbleSorter = new BubbleSort();

            var sortedArray = bubbleSorter.Run(_initialArray);

            CollectionAssert.AreEqual(_sortedArray, sortedArray);
        }

        [Test]
        public void Can_Sort_Via_Insertion_Sorting()
        {
            var insertionSorter = new InsertionSort();

            var sortedArray = insertionSorter.Run(_initialArray);

            CollectionAssert.AreEqual(_sortedArray, sortedArray);
        }
    }
}