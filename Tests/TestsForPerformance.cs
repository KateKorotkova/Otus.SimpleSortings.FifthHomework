using System;
using NUnit.Framework;
using Otus.SimpleSortings.FifthHomework.Logic;

namespace Tests
{
    public class TestsForPerformance
    {
        private Random _random = new Random();


        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(10000)]
        public void Bubble_Sort(int arraySize)
        {
            var array = GenerateArray(arraySize);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            new BubbleSort().Run(array);
            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(10000)]
        public void Insertion_Sort(int arraySize)
        {
            var array = GenerateArray(arraySize);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            new InsertionSort().Run(array);
            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(10000)]
        public void Shell_Sort(int arraySize)
        {
            var array = GenerateArray(arraySize);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            new ShellSort().Run(array);
            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
        }


        #region Helpers

        private int[] GenerateArray(int size)
        {
            var array = new int[size];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = _random.Next();
            }

            return array;
        }

        #endregion
    }
}