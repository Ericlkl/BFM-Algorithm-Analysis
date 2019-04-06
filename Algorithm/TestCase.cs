using NUnit.Framework;
using System;

namespace Algorithm
{
    [TestFixture]
    public class TestCase
    {
        public int[] inputArray;

        [Test()]
        public void SortedPositionTest()
        {
            // Sorted
            inputArray = new int[] { 1,2,3,4,5,6,7 };
            Assert.That(BFM.BruteForceMedian(inputArray) == 4);

        }

        [Test()]
        public void EvenAndRandomPositiionTest()
        {
            // Even, random
            inputArray = new int[] { 8, 12, 7, 9 };
            Assert.That(BFM.BruteForceMedian(inputArray) == 8);

        }

        [Test()]
        public void OddAndRandomPositiionTest()
        {
            // Odd, random
            inputArray = new int[] { 8, 5, 9 , 1 , 4 };
            Assert.That(BFM.BruteForceMedian(inputArray) == 5);

        }

        [Test()]
        public void ReverseOrderTest()
        {
            // Reverse order
            inputArray = new int[] { 9, 8, 7, 6, 5, 4, 3 };
            Assert.That(BFM.BruteForceMedian(inputArray) == 6);

        }

        [Test()]
        public void ContainsNegativeValuesTest()
        {
            // Contains negative values
            inputArray = new int[] { -5, -3, 5, 4, -2 };
            Assert.That(BFM.BruteForceMedian(inputArray) == -2);

        }

        [Test()]
        public void DuplicateValuesTest()
        {
            // Contains duplicates
            inputArray = new int[] { 1, 2, 2, 2, 4, 5, 6, 6, 7 };
            Assert.That(BFM.BruteForceMedian(inputArray) == 4);

        }

        [Test()]
        public void InvalidArraySizeTest()
        {
            // Invalid size input!"
            inputArray = new int[] { };
            Assert.That(BFM.BruteForceMedian(inputArray) == -1);

        }

        [Test()]
        public void OneElementArrayTest()
        {
            // Sorted
            inputArray = new int[] { 4 };
            Assert.That(BFM.BruteForceMedian(inputArray) == 4);

        }
    }
}
