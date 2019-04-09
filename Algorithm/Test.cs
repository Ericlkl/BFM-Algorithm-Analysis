using System;
using System.Linq;

namespace Algorithm
{
    public class Test
    {
        public static long BFM_ExecutionTimeTest(int size)
        {
            var watch = new System.Diagnostics.Stopwatch();

            Random rnd = new Random();
            int[] arr = Enumerable.Range(0, size).OrderBy(c => rnd.Next()).ToArray();

            watch.Start();

            BFM.BruteForceMedian(arr);

            watch.Stop();

            return watch.ElapsedMilliseconds;
        }

        public static int BFM_BasicOperationTest(int size)
        {
            Random rnd = new Random();
            int[] arr = Enumerable.Range(0, size).OrderBy(c => rnd.Next()).ToArray();

            return BFM.BruteForceMedian_BO(arr);
        }

    }
}
