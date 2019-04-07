using System;
namespace Algorithm
{
    public class Test
    {
        public static long BFM_ExecutionTimeTest(int size)
        {
            var watch = new System.Diagnostics.Stopwatch();

            int[] array = Helper.GenerateRandomArray(size);

            watch.Start();

            BFM.BruteForceMedian(array);

            watch.Stop();

            return watch.ElapsedMilliseconds;
        }

        public static int BFM_BasicOperationTest(int size)
        {
            int[] array = Helper.GenerateRandomArray(size);
            return BFM.BruteForceMedian_BO(array);
        }

    }
}
