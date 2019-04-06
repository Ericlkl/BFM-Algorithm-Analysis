using System;
namespace Algorithm
{
    public class Helper
    {
        public static int[] GenerateRandomArray(int size)
        {
            int[] A = new int[size];

            int seed = (int)DateTime.Now.Ticks;
            Random rnd = new Random(seed);

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(1, 20000);
            }
            return A;
        }

        public static void BFM_ExecutionTimeTest(int size)
        {
            var watch = new System.Diagnostics.Stopwatch();

            int[] array = GenerateRandomArray(size);

            watch.Start();

            BFM.BruteForceMedian(array);

            watch.Stop();

            Console.WriteLine($"Array Size : {array.Length}  Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        public static void BFM_BasicOperationTest(int size)
        {
            int[] array = GenerateRandomArray(size);
            int basicOperation = BFM.BruteForceMedian_BO(array);
            Console.WriteLine($"Array Size : {array.Length}  Basic Operation: {basicOperation}");
        }
    }
}
