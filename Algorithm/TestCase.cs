using NUnit.Framework;
using System;

namespace Algorithm
{
    [TestFixture]
    public class TestCase
    {
        public int[] inputArray;
        [Test()]
        public void EvenAndRandomPositiionTest()
        {
            // Even, random
            inputArray = new int[] { 1, 6, 4, 9, 0, 12, 56, 3 };
            Assert.That(Algorithm.MainClass.BruteForceMedian(inputArray) == 4);

        }

        [Test()]
        public void OddAndRandomPositiionTest()
        {
            // Odd, random
            inputArray = new int[] { 5, 8, 2, 3, 0, 11, 4, 29, 7 };
            Assert.That(Algorithm.MainClass.BruteForceMedian(inputArray) == 5);

        }

        [Test()]
        public void SortedPositiionTest()
        {
            // Sorted
            inputArray = new int[] { 23, 30, 47, 55, 69, 70, 81, 99 };
            Assert.That(Algorithm.MainClass.BruteForceMedian(inputArray) == 55);

        }

        [Test()]
        public void ReverseOrderTest()
        {
            // Reverse order
            inputArray = new int[] { 123, 93, 87, 75, 60, 33, 12, 2, 1 };
            Assert.That(Algorithm.MainClass.BruteForceMedian(inputArray) == 60);

        }

        [Test()]
        public void ContainsNegativeValuesTest()
        {
            // Contains negative values
            inputArray = new int[] { -1, 6, 4, 0, 8, -3, 2, 5 };
            Assert.That(Algorithm.MainClass.BruteForceMedian(inputArray) == 2);

        }

        [Test()]
        public void DuplicateValuesTest()
        {
            // Contains duplicates
            inputArray = new int[] { 50, 4, 2, 3, 1, 9, 10, 2, 3 };
            Assert.That(Algorithm.MainClass.BruteForceMedian(inputArray) == 3);

        }

        [Test()]
        public void InvalidArraySizeTest()
        {
            // Invalid size input!"
            inputArray = new int[] { 3 };
            Assert.That(Algorithm.MainClass.BruteForceMedian(inputArray) == 3);

        }
    }
}
