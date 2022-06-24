using NUnit.Framework;
using Otus.SimpleSortings.FifthHomework.Logic;

namespace Tests
{
    public class Tests
    {
        private int[] _initialArray = { 32, 95, 16, 82, 24, 66, 35, 19, 75, 54, 40, 43, 93, 68 };
        private int[] _sortedArray = { 16, 19, 24, 32, 35, 40, 43, 54, 66, 68, 75, 82, 93, 95 };


        [Test]
        public void Can_Sort_Via_Bubble_Sorting()
        {
            var bubbleSorter = new BubbleSort();

            var sortedArray = bubbleSorter.Run(GetInitialArray());

            CollectionAssert.AreEqual(_sortedArray, sortedArray);
        }

        [Test]
        public void Can_Sort_Via_Insertion_Sorting()
        {
            var insertionSorter = new InsertionSort();

            var sortedArray = insertionSorter.Run(GetInitialArray());

            CollectionAssert.AreEqual(_sortedArray, sortedArray);
        }

        [Test]
        public void Can_Sort_Via_Shell_Sorting()
        {
            var shellSorter = new ShellSort();

            var sortedArray = shellSorter.Run(GetInitialArray());

            CollectionAssert.AreEqual(_sortedArray, sortedArray);
        }

        #region Helpers

        private int[] GetInitialArray()
        {
            var tmpArray = new int[_initialArray.Length];
            
            _initialArray.CopyTo(tmpArray, 0);
            
            return tmpArray;
        }

        #endregion
    }
}